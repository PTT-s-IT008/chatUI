namespace Client.Views
{
    partial class Chat
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
            this.userlist = new System.Windows.Forms.ListBox();
            this.chatrooms = new System.Windows.Forms.ComboBox();
            this.createChatroomButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.messages = new System.Windows.Forms.ListBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userlist
            // 
            this.userlist.FormattingEnabled = true;
            this.userlist.ItemHeight = 16;
            this.userlist.Location = new System.Drawing.Point(16, 31);
            this.userlist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userlist.Name = "userlist";
            this.userlist.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.userlist.Size = new System.Drawing.Size(144, 420);
            this.userlist.TabIndex = 0;
            this.userlist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chatrooms
            // 
            this.chatrooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chatrooms.FormattingEnabled = true;
            this.chatrooms.Location = new System.Drawing.Point(169, 31);
            this.chatrooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatrooms.Name = "chatrooms";
            this.chatrooms.Size = new System.Drawing.Size(517, 24);
            this.chatrooms.TabIndex = 1;
            this.chatrooms.SelectedIndexChanged += new System.EventHandler(this.chatrooms_SelectedIndexChanged);
            // 
            // createChatroomButton
            // 
            this.createChatroomButton.Location = new System.Drawing.Point(696, 31);
            this.createChatroomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createChatroomButton.Name = "createChatroomButton";
            this.createChatroomButton.Size = new System.Drawing.Size(160, 28);
            this.createChatroomButton.TabIndex = 2;
            this.createChatroomButton.Text = "Create a chatroom";
            this.createChatroomButton.UseVisualStyleBackColor = true;
            this.createChatroomButton.Click += new System.EventHandler(this.createChatroomButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(169, 427);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(592, 22);
            this.messageTextBox.TabIndex = 4;
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            this.messageTextBox.Enter += new System.EventHandler(this.sendButton_Click);
            this.messageTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageTextBox_KeyUp);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(771, 426);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(85, 27);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messages
            // 
            this.messages.FormattingEnabled = true;
            this.messages.ItemHeight = 16;
            this.messages.Location = new System.Drawing.Point(169, 66);
            this.messages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messages.Name = "messages";
            this.messages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.messages.Size = new System.Drawing.Size(685, 356);
            this.messages.TabIndex = 6;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(16, 7);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(97, 17);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "welcomeLabel";
            this.welcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 548);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.createChatroomButton);
            this.Controls.Add(this.chatrooms);
            this.Controls.Add(this.userlist);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userlist;
        private System.Windows.Forms.ComboBox chatrooms;
        private System.Windows.Forms.Button createChatroomButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ListBox messages;
        private System.Windows.Forms.Label welcomeLabel;
    }
}