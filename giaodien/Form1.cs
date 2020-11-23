using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace giaodien
{
    public partial class Welcome : Form
    {
        //field
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Welcome()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 75);
            panel1.Controls.Add(leftBorderBtn);
            currentBtn = iconButton1;
            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = Color.FromArgb(0, 247, 75);
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = Color.FromArgb(0, 247, 75);
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            leftBorderBtn.BackColor = Color.FromArgb(0, 247, 75);
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
            timer1.Start();
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(253, 138, 114);
            public static Color color2 = Color.FromArgb(247, 0, 75);
            public static Color color3 = Color.FromArgb(0, 247, 75);
        }
        public void ActivateBtn(object senderBtn, Color color)
        {
            if(senderBtn!=null)
            {
                DisableBtn();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //left border button
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }    
        }
        private void DisableBtn()
        {
            if(currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(33, 22, 32);
                currentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        
        private void iconButton2_MouseHover(object sender, EventArgs e)
        {
            iconButton2.IconColor = Color.Red;
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.IconColor = Color.White;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_MouseHover(object sender, EventArgs e)
        {
            iconButton3.IconColor = Color.Aqua;
        }

        private void iconButton3_MouseLeave(object sender, EventArgs e)
        {
            iconButton3.IconColor = Color.White;

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color1);
        }

        private void Joining_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color2);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text= System.DateTime.Now.ToString("hh:mm:ss tt");
            label3.Text = System.DateTime.Now.ToLongDateString();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


        }
    }
   

}
