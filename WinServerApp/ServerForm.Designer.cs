namespace WinServerApp
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startBt = new System.Windows.Forms.Button();
            this.userListView = new System.Windows.Forms.ListView();
            this.connectionIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msgRichTextBox = new System.Windows.Forms.RichTextBox();
            this.answerRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logRichTextBox.Location = new System.Drawing.Point(12, 329);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.ReadOnly = true;
            this.logRichTextBox.Size = new System.Drawing.Size(600, 108);
            this.logRichTextBox.TabIndex = 0;
            this.logRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Logs";
            // 
            // startBt
            // 
            this.startBt.Location = new System.Drawing.Point(12, 2);
            this.startBt.Name = "startBt";
            this.startBt.Size = new System.Drawing.Size(121, 23);
            this.startBt.TabIndex = 4;
            this.startBt.Text = "Start";
            this.startBt.UseVisualStyleBackColor = true;
            this.startBt.Click += new System.EventHandler(this.startBt_Click);
            // 
            // userListView
            // 
            this.userListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.connectionIdColumn,
            this.nameColumn,
            this.countColumn});
            this.userListView.FullRowSelect = true;
            this.userListView.Location = new System.Drawing.Point(12, 47);
            this.userListView.MultiSelect = false;
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(202, 276);
            this.userListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.userListView.TabIndex = 5;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            this.userListView.SelectedIndexChanged += new System.EventHandler(this.userListView_SelectedIndexChanged);
            // 
            // connectionIdColumn
            // 
            this.connectionIdColumn.Text = "ConnectionId";
            this.connectionIdColumn.Width = 77;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            // 
            // countColumn
            // 
            this.countColumn.Text = "Count";
            // 
            // msgRichTextBox
            // 
            this.msgRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgRichTextBox.Location = new System.Drawing.Point(220, 47);
            this.msgRichTextBox.Name = "msgRichTextBox";
            this.msgRichTextBox.ReadOnly = true;
            this.msgRichTextBox.Size = new System.Drawing.Size(392, 213);
            this.msgRichTextBox.TabIndex = 6;
            this.msgRichTextBox.Text = "";
            // 
            // answerRichTextBox
            // 
            this.answerRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerRichTextBox.Location = new System.Drawing.Point(221, 266);
            this.answerRichTextBox.Name = "answerRichTextBox";
            this.answerRichTextBox.Size = new System.Drawing.Size(331, 56);
            this.answerRichTextBox.TabIndex = 7;
            this.answerRichTextBox.Text = "";
            // 
            // sendBt
            // 
            this.sendBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBt.Location = new System.Drawing.Point(559, 267);
            this.sendBt.Name = "sendBt";
            this.sendBt.Size = new System.Drawing.Size(53, 55);
            this.sendBt.TabIndex = 8;
            this.sendBt.Text = "Send";
            this.sendBt.UseVisualStyleBackColor = true;
            this.sendBt.Click += new System.EventHandler(this.sendBt_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 449);
            this.Controls.Add(this.sendBt);
            this.Controls.Add(this.answerRichTextBox);
            this.Controls.Add(this.msgRichTextBox);
            this.Controls.Add(this.userListView);
            this.Controls.Add(this.startBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logRichTextBox);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBt;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader countColumn;
        private System.Windows.Forms.ColumnHeader connectionIdColumn;
        private System.Windows.Forms.RichTextBox msgRichTextBox;
        private System.Windows.Forms.RichTextBox answerRichTextBox;
        private System.Windows.Forms.Button sendBt;
    }
}

