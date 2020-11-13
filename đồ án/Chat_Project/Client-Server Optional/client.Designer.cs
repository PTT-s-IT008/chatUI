namespace CLIENT
{
    partial class client
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
            this.IPBox = new System.Windows.Forms.TextBox();
            this.ConfirmIP = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msgListview = new System.Windows.Forms.ListView();
            this.msgBox = new System.Windows.Forms.RichTextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(134, 13);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(204, 27);
            this.IPBox.TabIndex = 0;
            // 
            // ConfirmIP
            // 
            this.ConfirmIP.Location = new System.Drawing.Point(641, 12);
            this.ConfirmIP.Name = "ConfirmIP";
            this.ConfirmIP.Size = new System.Drawing.Size(121, 29);
            this.ConfirmIP.TabIndex = 1;
            this.ConfirmIP.Text = "CONNECT";
            this.ConfirmIP.UseVisualStyleBackColor = true;
            this.ConfirmIP.Click += new System.EventHandler(this.ConfirmIP_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(494, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(120, 27);
            this.nameBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your username";
            // 
            // msgListview
            // 
            this.msgListview.HideSelection = false;
            this.msgListview.Location = new System.Drawing.Point(26, 63);
            this.msgListview.Name = "msgListview";
            this.msgListview.Size = new System.Drawing.Size(588, 268);
            this.msgListview.TabIndex = 5;
            this.msgListview.UseCompatibleStateImageBehavior = false;
            this.msgListview.View = System.Windows.Forms.View.List;
            // 
            // msgBox
            // 
            this.msgBox.Enabled = false;
            this.msgBox.Location = new System.Drawing.Point(26, 350);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(588, 72);
            this.msgBox.TabIndex = 6;
            this.msgBox.Text = "";
            // 
            // SendBtn
            // 
            this.SendBtn.Enabled = false;
            this.SendBtn.Location = new System.Drawing.Point(641, 350);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(121, 72);
            this.SendBtn.TabIndex = 7;
            this.SendBtn.Text = "SEND";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.msgListview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.ConfirmIP);
            this.Controls.Add(this.IPBox);
            this.Name = "client";
            this.Text = "client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.client_FormClosed);
            this.Load += new System.EventHandler(this.client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Button ConfirmIP;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView msgListview;
        private System.Windows.Forms.RichTextBox msgBox;
        private System.Windows.Forms.Button SendBtn;
    }
}

