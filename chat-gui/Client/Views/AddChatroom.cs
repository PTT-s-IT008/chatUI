using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatMessage = Chat.Net.Message;

namespace Client.Views
{
    /// <summary>
    /// WinForm to add a chatroom
    /// </summary>
    public partial class AddChatroom : Form
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
        private Client client;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="clientParam">Get the client instance</param>
        public AddChatroom(Client clientParam)
        {
            this.MouseMove += _MouseMove;
            this.MouseUp += _MouseUp;
            this.MouseDown += _MouseDown;
            InitializeComponent();
            client = clientParam;
        }

        /// <summary>
        /// Action performed on Create chatroom button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createChatroomButton_Click(object sender, EventArgs e)
        {
            ChatMessage chatroomsMessage = new ChatMessage(ChatMessage.Header.CREATE_CR);
            chatroomsMessage.addData(chatroomTextBox.Text);

            if (chatroomTextBox.Text != "")
            {
                client.sendMessage(chatroomsMessage);

                ChatMessage reply = client.getMessage();

                if (reply == null)
                {
                    MessageBox.Show("Server failure",
                        "Connection error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (reply.MessageList.First() == "success")
                {
                    this.Close();
                }
                else if (reply.MessageList.First() == "error")
                {
                    MessageBox.Show(reply.MessageList[1],
                        "Could not create chatroom",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a chatroom name",
                        "Chatroom empty",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
