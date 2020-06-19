namespace chatbottest1
{
    partial class Principal_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtChat = new System.Windows.Forms.Label();
            this.imgChat = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgChat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 350);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(239, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 350);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtChat);
            this.panel3.Controls.Add(this.imgChat);
            this.panel3.Location = new System.Drawing.Point(35, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 129);
            this.panel3.TabIndex = 1;
            // 
            // txtChat
            // 
            this.txtChat.AutoSize = true;
            this.txtChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtChat.Location = new System.Drawing.Point(3, 76);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(88, 36);
            this.txtChat.TabIndex = 1;
            this.txtChat.Text = "Chatea con \r\nnosotros";
            this.txtChat.Click += new System.EventHandler(this.txtChat_Click);
            // 
            // imgChat
            // 
            this.imgChat.Image = ((System.Drawing.Image)(resources.GetObject("imgChat.Image")));
            this.imgChat.Location = new System.Drawing.Point(18, 0);
            this.imgChat.Name = "imgChat";
            this.imgChat.Size = new System.Drawing.Size(67, 70);
            this.imgChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgChat.TabIndex = 0;
            this.imgChat.TabStop = false;
            this.imgChat.Click += new System.EventHandler(this.imgChat_Click);
            // 
            // Principal_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 374);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Principal_Menu";
            this.Text = "Principal_Menu";
            this.Load += new System.EventHandler(this.Principal_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtChat;
        private System.Windows.Forms.PictureBox imgChat;
    }
}