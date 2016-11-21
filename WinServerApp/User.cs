using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinServerApp
{
    public class User
    {
        public string ConnectionId { get; set; }
        public string Name { get; set; }
        public List<Message> Messages { get; set; }

        public User()
        {
            Messages = new List<Message>();
        }

        public string[] GetAllPropertyValues()
        {
            return new string[] { ConnectionId, Name, Messages.Count.ToString() };
        }

        public string[] GetAllMessages()
        {
            List<string> list = new List<string>();
            foreach (Message msg in Messages)
                list.Add(((msg.ConnectionId == ConnectionId) ? "Me: " : "Manager: ") + msg.Text);
            return list.ToArray();
        }
    }
}
