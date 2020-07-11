namespace chatbottest1
{
    partial class Chatbot
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chatbot));
            this.panel_chat = new System.Windows.Forms.Panel();
            this.lbl_conectando = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_iniciando = new System.Windows.Forms.Label();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_sendMessage = new System.Windows.Forms.Button();
            this.panel_chat_bar = new System.Windows.Forms.Panel();
            this.bt_sendmessage_ellipse = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.profile_photo = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.label2 = new System.Windows.Forms.Label();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_help2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panel_chat.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_chat_bar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_chat
            // 
            this.panel_chat.Controls.Add(this.lbl_conectando);
            this.panel_chat.Controls.Add(this.label1);
            this.panel_chat.Controls.Add(this.lbl_iniciando);
            this.panel_chat.Controls.Add(this.lbl_hour);
            this.panel_chat.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_chat.Location = new System.Drawing.Point(21, 181);
            this.panel_chat.Margin = new System.Windows.Forms.Padding(2);
            this.panel_chat.Name = "panel_chat";
            this.panel_chat.Size = new System.Drawing.Size(895, 392);
            this.panel_chat.TabIndex = 0;
            this.panel_chat.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Panel_chat_ControlAdded);
            this.panel_chat.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_chat_Paint);
            // 
            // lbl_conectando
            // 
            this.lbl_conectando.AutoSize = true;
            this.lbl_conectando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lbl_conectando.ForeColor = System.Drawing.Color.Black;
            this.lbl_conectando.Location = new System.Drawing.Point(51, 346);
            this.lbl_conectando.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_conectando.Name = "lbl_conectando";
            this.lbl_conectando.Padding = new System.Windows.Forms.Padding(8);
            this.lbl_conectando.Size = new System.Drawing.Size(287, 36);
            this.lbl_conectando.TabIndex = 4;
            this.lbl_conectando.Text = "Conectando con Microsoft Azure ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(339, 116);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para usar el chatbot escribe en la barra de\r\n comandos lo que desees realizar.\r\n\r" +
    "\nPara más información haz clic en el botón \r\nde ayuda o escribe ayuda en el chat" +
    "bot.";
            // 
            // lbl_iniciando
            // 
            this.lbl_iniciando.AutoSize = true;
            this.lbl_iniciando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lbl_iniciando.ForeColor = System.Drawing.Color.Black;
            this.lbl_iniciando.Location = new System.Drawing.Point(51, 291);
            this.lbl_iniciando.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_iniciando.Name = "lbl_iniciando";
            this.lbl_iniciando.Padding = new System.Windows.Forms.Padding(8);
            this.lbl_iniciando.Size = new System.Drawing.Size(279, 36);
            this.lbl_iniciando.TabIndex = 1;
            this.lbl_iniciando.Text = "Iniciando el Chatbot Empresarial ...";
            // 
            // lbl_hour
            // 
            this.lbl_hour.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hour.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_hour.Location = new System.Drawing.Point(36, 226);
            this.lbl_hour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(835, 20);
            this.lbl_hour.TabIndex = 0;
            this.lbl_hour.Text = "01/01/01     00:00 AM";
            this.lbl_hour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_hour.Click += new System.EventHandler(this.lbl_hour_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(20, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(730, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Escribe lo que deseas hacer";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label7.Location = new System.Drawing.Point(657, 584);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "label1";
            this.label7.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 75);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_sendMessage
            // 
            this.bt_sendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_sendMessage.FlatAppearance.BorderSize = 0;
            this.bt_sendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sendMessage.Location = new System.Drawing.Point(0, 0);
            this.bt_sendMessage.Margin = new System.Windows.Forms.Padding(0);
            this.bt_sendMessage.Name = "bt_sendMessage";
            this.bt_sendMessage.Size = new System.Drawing.Size(32, 28);
            this.bt_sendMessage.TabIndex = 2;
            this.bt_sendMessage.UseVisualStyleBackColor = false;
            this.bt_sendMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_chat_bar
            // 
            this.panel_chat_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel_chat_bar.Controls.Add(this.textBox1);
            this.panel_chat_bar.Location = new System.Drawing.Point(60, 606);
            this.panel_chat_bar.Margin = new System.Windows.Forms.Padding(2);
            this.panel_chat_bar.Name = "panel_chat_bar";
            this.panel_chat_bar.Size = new System.Drawing.Size(832, 43);
            this.panel_chat_bar.TabIndex = 5;
            this.panel_chat_bar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_chat_bar_Paint);
            // 
            // bt_sendmessage_ellipse
            // 
            this.bt_sendmessage_ellipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_sendmessage_ellipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sendmessage_ellipse.BackgroundImage")));
            this.bt_sendmessage_ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_sendmessage_ellipse.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.bt_sendmessage_ellipse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_sendmessage_ellipse.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_sendmessage_ellipse.FillGradientColor = System.Drawing.Color.LightGreen;
            this.bt_sendmessage_ellipse.Location = new System.Drawing.Point(869, 600);
            this.bt_sendmessage_ellipse.Name = "bt_sendmessage_ellipse";
            this.bt_sendmessage_ellipse.SelectionColor = System.Drawing.Color.Transparent;
            this.bt_sendmessage_ellipse.Size = new System.Drawing.Size(50, 50);
            this.bt_sendmessage_ellipse.Click += new System.EventHandler(this.bt_sendmessage_ellipse_Click);
            this.bt_sendmessage_ellipse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_sendmessage_ellipse_MouseDown);
            this.bt_sendmessage_ellipse.MouseLeave += new System.EventHandler(this.bt_sendmessage_ellipse_MouseLeave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.bt_sendmessage_ellipse});
            this.shapeContainer1.Size = new System.Drawing.Size(983, 674);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.shapeContainer2);
            this.panel2.Location = new System.Drawing.Point(21, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 70);
            this.panel2.TabIndex = 7;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.bt_help2,
            this.ovalShape1,
            this.profile_photo,
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(895, 70);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 55;
            this.lineShape1.X2 = 880;
            this.lineShape1.Y1 = 65;
            this.lineShape1.Y2 = 65;
            // 
            // profile_photo
            // 
            this.profile_photo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.profile_photo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile_photo.BackgroundImage")));
            this.profile_photo.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.profile_photo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.profile_photo.Location = new System.Drawing.Point(69, 1);
            this.profile_photo.Name = "profile_photo";
            this.profile_photo.SelectionColor = System.Drawing.Color.Transparent;
            this.profile_photo.Size = new System.Drawing.Size(60, 60);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(138, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "YMCA Bot";
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ovalShape1.Location = new System.Drawing.Point(142, 42);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.SelectionColor = System.Drawing.Color.Transparent;
            this.ovalShape1.Size = new System.Drawing.Size(10, 10);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(155, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "online";
            // 
            // bt_help2
            // 
            this.bt_help2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_help2.BackgroundImage")));
            this.bt_help2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_help2.BorderColor = System.Drawing.Color.Transparent;
            this.bt_help2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.bt_help2.Location = new System.Drawing.Point(811, 10);
            this.bt_help2.Name = "bt_help2";
            this.bt_help2.SelectionColor = System.Drawing.Color.Transparent;
            this.bt_help2.Size = new System.Drawing.Size(50, 50);
            this.bt_help2.Click += new System.EventHandler(this.bt_help2_Click);
            // 
            // Chatbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel_chat);
            this.Controls.Add(this.shapeContainer1);
            this.Controls.Add(this.panel_chat_bar);
            this.Controls.Add(this.bt_sendMessage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Chatbot";
            this.Size = new System.Drawing.Size(983, 674);
            this.Load += new System.EventHandler(this.Chatbot_Load);
            this.panel_chat.ResumeLayout(false);
            this.panel_chat.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_chat_bar.ResumeLayout(false);
            this.panel_chat_bar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_chat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_sendMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_hour;
        private System.Windows.Forms.Label lbl_iniciando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_chat_bar;
        private System.Windows.Forms.Label lbl_conectando;
        private Microsoft.VisualBasic.PowerPacks.OvalShape bt_sendmessage_ellipse;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape profile_photo;
        private Microsoft.VisualBasic.PowerPacks.OvalShape bt_help2;
    }
}
