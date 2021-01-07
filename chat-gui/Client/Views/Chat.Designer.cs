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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.messages = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userlist
            // 
            this.userlist.BackColor = System.Drawing.SystemColors.Info;
            this.userlist.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlist.FormattingEnabled = true;
            this.userlist.ItemHeight = 24;
            this.userlist.Location = new System.Drawing.Point(2, 126);
            this.userlist.Margin = new System.Windows.Forms.Padding(4);
            this.userlist.Name = "userlist";
            this.userlist.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.userlist.Size = new System.Drawing.Size(144, 460);
            this.userlist.TabIndex = 0;
            this.userlist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chatrooms
            // 
            this.chatrooms.BackColor = System.Drawing.SystemColors.MenuBar;
            this.chatrooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chatrooms.FormattingEnabled = true;
            this.chatrooms.Location = new System.Drawing.Point(169, 80);
            this.chatrooms.Margin = new System.Windows.Forms.Padding(4);
            this.chatrooms.Name = "chatrooms";
            this.chatrooms.Size = new System.Drawing.Size(556, 24);
            this.chatrooms.TabIndex = 1;
            this.chatrooms.SelectedIndexChanged += new System.EventHandler(this.chatrooms_SelectedIndexChanged);
            // 
            // createChatroomButton
            // 
            this.createChatroomButton.BackColor = System.Drawing.Color.White;
            this.createChatroomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createChatroomButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createChatroomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.createChatroomButton.Location = new System.Drawing.Point(750, 68);
            this.createChatroomButton.Margin = new System.Windows.Forms.Padding(4);
            this.createChatroomButton.Name = "createChatroomButton";
            this.createChatroomButton.Size = new System.Drawing.Size(104, 46);
            this.createChatroomButton.TabIndex = 2;
            this.createChatroomButton.Text = "Create a chatroom";
            this.createChatroomButton.UseVisualStyleBackColor = false;
            this.createChatroomButton.Click += new System.EventHandler(this.createChatroomButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.messageTextBox.Location = new System.Drawing.Point(169, 564);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(631, 30);
            this.messageTextBox.TabIndex = 4;
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            this.messageTextBox.Enter += new System.EventHandler(this.sendButton_Click);
            this.messageTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageTextBox_KeyUp);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Bahnschrift", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(286, 12);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(301, 52);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "welcomeLabel";
            this.welcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // messages
            // 
            this.messages.BackColor = System.Drawing.Color.White;
            this.messages.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.messages.FormattingEnabled = true;
            this.messages.ItemHeight = 23;
            this.messages.Location = new System.Drawing.Point(169, 126);
            this.messages.Margin = new System.Windows.Forms.Padding(4);
            this.messages.Name = "messages";
            this.messages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.messages.Size = new System.Drawing.Size(685, 418);
            this.messages.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 48);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Userlist";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.button1.Image = global::Client.Properties.Resources.close_window_32px;
            this.button1.Location = new System.Drawing.Point(824, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 31);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // sendButton
            // 
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.sendButton.Image = global::Client.Properties.Resources.sent3;
            this.sendButton.Location = new System.Drawing.Point(811, 558);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(43, 36);
            this.sendButton.TabIndex = 5;
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            this.sendButton.MouseLeave += new System.EventHandler(this.sendButton_MouseLeave);
            this.sendButton.MouseHover += new System.EventHandler(this.sendButton_MouseHover);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(872, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.createChatroomButton);
            this.Controls.Add(this.chatrooms);
            this.Controls.Add(this.userlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chat";
            this.Text = "Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chat_FormClosed);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userlist;
        private System.Windows.Forms.ComboBox chatrooms;
        private System.Windows.Forms.Button createChatroomButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ListBox messages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}