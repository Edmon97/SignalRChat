using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinServerApp
{

    public partial class ServerForm : Form
    {
        private IDisposable SignalR { get; set; }
        const string ServerURI = "http://test2305.somee.com";//http://localhost:8080

        IHubContext _context = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
        public ServerForm()
        {
            InitializeComponent();
        }

        #region Form Methods
        private void startBt_Click(object sender, EventArgs e)
        {
            WriteLog("Starting server...");
            startBt.Enabled = false;
            Task.Run(() => StartServer());
        }

        private void sendBt_Click(object sender, EventArgs e)
        {
            if (answerRichTextBox.Text != "")
            {
                string msg = answerRichTextBox.Text;
                msgRichTextBox.AppendText(Environment.NewLine + "Me: " + msg);
                answerRichTextBox.Text = "";
                string id = userListView.SelectedItems[0].Text;
                _context.Clients.Client(id).addMessage("Moderator", msg);
            }
            else
                MessageBox.Show("Enter answer");
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SignalR != null)
                SignalR.Dispose();
        }

        private void userListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = userListView.SelectedItems[0].Text;
            msgRichTextBox.Lines = ChatHub.Users[id].GetAllMessages();
        }
        #endregion

        #region Help Methods
        public void WriteLog(string message)
        {
            if (logRichTextBox.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    WriteLog(message)
                ));
                return;
            }
            logRichTextBox.AppendText(message + Environment.NewLine);
        }

        public void AddUser(string id)
        {
            userListView.Invoke((Action)(() =>
            {
                ListViewItem item = new ListViewItem(ChatHub.Users[id].GetAllPropertyValues());
                userListView.Items.Add(item);
            }));
        }

        public void DeleteUser(string id)
        {
            userListView.Invoke((Action)(() =>
            {
                ListViewItem item = userListView.FindItemWithText(id);
                userListView.Items.Remove(item);
            }));
        }

        public void IncMsgCount(string id)
        {
            userListView.Invoke((Action)(() =>
            {
                ListViewItem item = userListView.FindItemWithText(id);
                if (item != null)
                    item.SubItems[2].Text = ChatHub.Users[id].Messages.Count.ToString();
            }));
        }

        private void StartServer()
        {
            try
            {
                SignalR = WebApp.Start(ServerURI);
            }
            catch (TargetInvocationException)
            {
                WriteLog("Server failed to start. A server is already running on " + ServerURI);
                return;
            }
            WriteLog("Server started at " + ServerURI);
        }
        #endregion

    }

    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }

    public class ChatHub : Hub
    {
        public static Dictionary<string, User> Users = new Dictionary<string, User>();

        public void Connect(string userName)
        {
            var id = Context.ConnectionId;
            if (!Users.ContainsKey(id))
            {
                User user = new User() { ConnectionId = id, Name = userName };
                Users.Add(id, user);
                Program.MainForm.AddUser(id);
            }
        }

        public void SendMessage(string message)
        {
            var id = Context.ConnectionId;
            User user = Users[id];
            user.Messages.Add(new Message() { Text = message, ConnectionId = id });
            Program.MainForm.IncMsgCount(id);
        }

        public override Task OnConnected()
        {
            Program.MainForm.WriteLog("Client connected: " + Context.ConnectionId);
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            var id = Context.ConnectionId;
            Program.MainForm.WriteLog("Client disconnected: " + id);
            Program.MainForm.DeleteUser(id);
            Users.Remove(id);
            return base.OnDisconnected(stopCalled);
        }
    }
}
