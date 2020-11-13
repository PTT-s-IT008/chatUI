using CLIENT;
using SERVER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Server_Optional
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void host_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ServerForm = new server();
            
            ServerForm.Closed += (s, args) => this.Show();
            ServerForm.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void Welcome_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ClientForm = new client();

            ClientForm.Closed += (s, args) => this.Show();
            ClientForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
