namespace SERVER
{
    partial class server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.msgBox = new System.Windows.Forms.RichTextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.msgListView = new System.Windows.Forms.ListView();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(600, 46);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(188, 291);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // msgBox
            // 
            this.msgBox.Enabled = false;
            this.msgBox.Location = new System.Drawing.Point(12, 344);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(562, 94);
            this.msgBox.TabIndex = 3;
            this.msgBox.Text = "";
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendBtn.ForeColor = System.Drawing.Color.Black;
            this.SendBtn.Location = new System.Drawing.Point(600, 344);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(122, 94);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "SEND";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // msgListView
            // 
            this.msgListView.HideSelection = false;
            this.msgListView.Location = new System.Drawing.Point(12, 46);
            this.msgListView.Name = "msgListView";
            this.msgListView.Size = new System.Drawing.Size(562, 291);
            this.msgListView.TabIndex = 5;
            this.msgListView.UseCompatibleStateImageBehavior = false;
            this.msgListView.View = System.Windows.Forms.View.List;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(442, 27);
            this.nameBox.TabIndex = 7;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(461, 13);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(113, 29);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "HOST";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.msgListView);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "server";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "server";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.server_FormClosed);
            this.Load += new System.EventHandler(this.server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RichTextBox msgBox;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.ListView msgListView;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button confirmButton;
    }
}

