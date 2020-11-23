using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Drawing.Configuration;
using System.Text;
using System.Windows.Forms;


namespace Client_Server_Optional
{
    class RoundedTextbox : TextBox
    {
        public Color color = Color.White;
        public int borderRadius = 25;
        public RoundedTextbox()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            SolidBrush brush = new SolidBrush(color);
            
            
        }
    }
}
