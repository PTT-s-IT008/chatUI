using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Views
{
    public partial class Welcome : Form
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

        public Welcome()
        {
            this.MouseDown += _MouseDown;
            this.MouseMove += _MouseMove;
            this.MouseUp += _MouseUp;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new Client();

            client.setServer(IPAddress.Parse(textBox1.Text), Int32.Parse(textBox2.Text));

            try
            {
                client.connect();
                client.run();

                var frm = new UserLogin(client);
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Close(); };
                frm.Show();
                this.Hide();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,
                    "Connection error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
