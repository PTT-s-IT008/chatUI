﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChatMessage = Chat.Net.Message;
using ChatUser = Chat.Auth.User;

namespace Client.Views
{
    /// <summary>
    /// WinForm used to perform login
    /// </summary>
    public partial class UserLogin : Form
    {
        #region Draggable
        private bool mouseDown;
        private Point lastLocation;

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void _MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
        protected Client client;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="clientParam">Client instance</param>
        public UserLogin(Client clientParam)
        {
            this.MouseDown += _MouseDown;
            this.MouseUp += _MouseUp;
            this.MouseMove += _MouseMove;
            InitializeComponent();
            client = clientParam;
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Action perform on Login button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            ChatMessage messageJoin = new ChatMessage(ChatMessage.Header.JOIN);
            messageJoin.addData(usernameTextBox.Text);
            messageJoin.addData(passwordTextBox.Text);
            client.sendMessage(messageJoin);

            ChatMessage reply = client.getMessage();

            if (reply == null)
            {
                MessageBox.Show("Error on Server",
                     "Connection error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }

            if (reply.MessageList.First() == "success")
            {
                client.User = new ChatUser(usernameTextBox.Text, passwordTextBox.Text);
                var frm = new Chat(client);
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Close(); };
                frm.Show();
                this.Hide();
            }
            else if (reply.MessageList.First() == "error")
            {
                MessageBox.Show("Wrong password",
                     "Connection error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Action performed on Register button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ChatMessage messageRegister = new ChatMessage(ChatMessage.Header.REGISTER);
            messageRegister.addData(usernameTextBox.Text);
            messageRegister.addData(passwordTextBox.Text);

            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Fill username and password",
                    "Username and password cannot be empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                client.sendMessage(messageRegister);

                ChatMessage register = client.getMessage();

                if (register == null)
                {
                    MessageBox.Show("Server failure",
                         "Connection error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }

                if (register.MessageList.First() == "success")
                {
                    MessageBox.Show("Registration success. You can now login using your credentials.",
                        "Registration success.",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);

                    Welcome frm = new Welcome();
                    frm.Show();
                    this.Hide();

                }
                else if (register.MessageList.First() == "error")
                {
                    MessageBox.Show("Could not register",
                         "Connection error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Allow user to use "Enter" key to login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Welcome frm = new Welcome();
            frm.Show();
            this.Hide();

        }

        private void UserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
