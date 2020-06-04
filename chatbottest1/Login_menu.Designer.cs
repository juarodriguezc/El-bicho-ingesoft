namespace chatbottest1
{
    partial class Login_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_menu));
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.line_Correo = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel_logo_login = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linklbl_olvidar = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel_forgot = new System.Windows.Forms.Panel();
            this.lbl_mailsent = new System.Windows.Forms.Label();
            this.labelInfoReccu = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.Button();
            this.recup_datos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTxbRecContr = new System.Windows.Forms.TextBox();
            this.emailRecContraLbl = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.panel_logo_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_login.SuspendLayout();
            this.panel_forgot.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.White;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_correo.Location = new System.Drawing.Point(100, 80);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(321, 25);
            this.txt_correo.TabIndex = 0;
            this.txt_correo.Text = "CORREO";
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_contrasenia.Location = new System.Drawing.Point(103, 160);
            this.txt_contrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(321, 25);
            this.txt_contrasenia.TabIndex = 1;
            this.txt_contrasenia.Text = "CONTRASEÑA";
            this.txt_contrasenia.TextChanged += new System.EventHandler(this.txt_contrasenia_TextChanged);
            this.txt_contrasenia.Enter += new System.EventHandler(this.txt_contrasenia_Enter);
            this.txt_contrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_contrasenia_KeyDown);
            this.txt_contrasenia.Leave += new System.EventHandler(this.txt_contrasenia_Leave);
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_ingresar.FlatAppearance.BorderSize = 0;
            this.bt_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_ingresar.ForeColor = System.Drawing.Color.LightGray;
            this.bt_ingresar.Location = new System.Drawing.Point(103, 265);
            this.bt_ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(323, 33);
            this.bt_ingresar.TabIndex = 2;
            this.bt_ingresar.Text = "ACCEDER";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(13, 473);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(84, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 63);
            this.label2.TabIndex = 6;
            this.label2.Text = "BIENVENIDO";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 100;
            this.lineShape1.X2 = 420;
            this.lineShape1.Y1 = 190;
            this.lineShape1.Y2 = 190;
            // 
            // line_Correo
            // 
            this.line_Correo.BorderColor = System.Drawing.Color.DimGray;
            this.line_Correo.Name = "line_Correo";
            this.line_Correo.X1 = 100;
            this.line_Correo.X2 = 424;
            this.line_Correo.Y1 = 110;
            this.line_Correo.Y2 = 110;
            // 
            // panel_logo_login
            // 
            this.panel_logo_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel_logo_login.Controls.Add(this.pictureBox1);
            this.panel_logo_login.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_logo_login.Location = new System.Drawing.Point(502, 0);
            this.panel_logo_login.Name = "panel_logo_login";
            this.panel_logo_login.Size = new System.Drawing.Size(280, 453);
            this.panel_logo_login.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-45, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linklbl_olvidar
            // 
            this.linklbl_olvidar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.linklbl_olvidar.AutoSize = true;
            this.linklbl_olvidar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_olvidar.LinkColor = System.Drawing.Color.DimGray;
            this.linklbl_olvidar.Location = new System.Drawing.Point(236, 202);
            this.linklbl_olvidar.Name = "linklbl_olvidar";
            this.linklbl_olvidar.Size = new System.Drawing.Size(203, 20);
            this.linklbl_olvidar.TabIndex = 11;
            this.linklbl_olvidar.TabStop = true;
            this.linklbl_olvidar.Text = "¿Olvidaste tu contraseña?";
            this.linklbl_olvidar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_olvidar_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(371, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "LOGIN";
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.bt_ingresar);
            this.panel_login.Controls.Add(this.linklbl_olvidar);
            this.panel_login.Controls.Add(this.txt_contrasenia);
            this.panel_login.Controls.Add(this.label4);
            this.panel_login.Controls.Add(this.txt_correo);
            this.panel_login.Controls.Add(this.shapeContainer2);
            this.panel_login.Location = new System.Drawing.Point(0, 91);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(502, 342);
            this.panel_login.TabIndex = 13;
            this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_login_Paint);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.line_Correo});
            this.shapeContainer2.Size = new System.Drawing.Size(502, 342);
            this.shapeContainer2.TabIndex = 13;
            this.shapeContainer2.TabStop = false;
            // 
            // panel_forgot
            // 
            this.panel_forgot.Controls.Add(this.lbl_mailsent);
            this.panel_forgot.Controls.Add(this.labelInfoReccu);
            this.panel_forgot.Controls.Add(this.backHome);
            this.panel_forgot.Controls.Add(this.recup_datos);
            this.panel_forgot.Controls.Add(this.label5);
            this.panel_forgot.Controls.Add(this.emailTxbRecContr);
            this.panel_forgot.Controls.Add(this.emailRecContraLbl);
            this.panel_forgot.Location = new System.Drawing.Point(0, 94);
            this.panel_forgot.Name = "panel_forgot";
            this.panel_forgot.Size = new System.Drawing.Size(502, 339);
            this.panel_forgot.TabIndex = 14;
            // 
            // lbl_mailsent
            // 
            this.lbl_mailsent.AutoSize = true;
            this.lbl_mailsent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mailsent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_mailsent.Location = new System.Drawing.Point(134, 219);
            this.lbl_mailsent.Name = "lbl_mailsent";
            this.lbl_mailsent.Size = new System.Drawing.Size(355, 21);
            this.lbl_mailsent.TabIndex = 35;
            this.lbl_mailsent.Text = "Se ha enviado la contraseña a tu correo.";
            this.lbl_mailsent.Visible = false;
            // 
            // labelInfoReccu
            // 
            this.labelInfoReccu.AutoSize = true;
            this.labelInfoReccu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoReccu.ForeColor = System.Drawing.Color.DimGray;
            this.labelInfoReccu.Location = new System.Drawing.Point(34, 104);
            this.labelInfoReccu.Name = "labelInfoReccu";
            this.labelInfoReccu.Size = new System.Drawing.Size(461, 42);
            this.labelInfoReccu.TabIndex = 34;
            this.labelInfoReccu.Text = "Ingresa tu email para que se te envíe una contraseña\r\n temporal de recuperación.";
            // 
            // backHome
            // 
            this.backHome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backHome.FlatAppearance.BorderSize = 0;
            this.backHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.backHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.backHome.ForeColor = System.Drawing.Color.LightGray;
            this.backHome.Location = new System.Drawing.Point(60, 277);
            this.backHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(101, 33);
            this.backHome.TabIndex = 33;
            this.backHome.Text = "VOLVER";
            this.backHome.UseVisualStyleBackColor = false;
            this.backHome.Click += new System.EventHandler(this.backHome_Click);
            // 
            // recup_datos
            // 
            this.recup_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.recup_datos.FlatAppearance.BorderSize = 0;
            this.recup_datos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.recup_datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recup_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recup_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.recup_datos.ForeColor = System.Drawing.Color.LightGray;
            this.recup_datos.Location = new System.Drawing.Point(277, 277);
            this.recup_datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recup_datos.Name = "recup_datos";
            this.recup_datos.Size = new System.Drawing.Size(162, 33);
            this.recup_datos.TabIndex = 32;
            this.recup_datos.Text = "RECUPERAR";
            this.recup_datos.UseVisualStyleBackColor = false;
            this.recup_datos.Click += new System.EventHandler(this.recup_datos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(175, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "RECUPERAR CONTRASEÑA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // emailTxbRecContr
            // 
            this.emailTxbRecContr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxbRecContr.ForeColor = System.Drawing.Color.DimGray;
            this.emailTxbRecContr.Location = new System.Drawing.Point(138, 175);
            this.emailTxbRecContr.MaxLength = 80;
            this.emailTxbRecContr.Multiline = true;
            this.emailTxbRecContr.Name = "emailTxbRecContr";
            this.emailTxbRecContr.Size = new System.Drawing.Size(301, 30);
            this.emailTxbRecContr.TabIndex = 28;
            this.emailTxbRecContr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTxbRecContr_KeyDown);
            // 
            // emailRecContraLbl
            // 
            this.emailRecContraLbl.AutoSize = true;
            this.emailRecContraLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRecContraLbl.ForeColor = System.Drawing.Color.DimGray;
            this.emailRecContraLbl.Location = new System.Drawing.Point(56, 178);
            this.emailRecContraLbl.Name = "emailRecContraLbl";
            this.emailRecContraLbl.Size = new System.Drawing.Size(69, 23);
            this.emailRecContraLbl.TabIndex = 27;
            this.emailRecContraLbl.Text = "E-mail";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(0, 437);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(80, 17);
            this.version.TabIndex = 15;
            this.version.Text = "Version 1.0";
            // 
            // Login_menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.version);
            this.Controls.Add(this.panel_logo_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.panel_forgot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login_menu";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBot";
            this.Load += new System.EventHandler(this.Login_menu_Load);
            this.panel_logo_login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_forgot.ResumeLayout(false);
            this.panel_forgot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.LineShape line_Correo;
        private System.Windows.Forms.Panel panel_logo_login;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.LinkLabel linklbl_olvidar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_login;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Panel panel_forgot;
        private System.Windows.Forms.TextBox emailTxbRecContr;
        private System.Windows.Forms.Label emailRecContraLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Button recup_datos;
        private System.Windows.Forms.Label labelInfoReccu;
        private System.Windows.Forms.Label lbl_mailsent;
        private System.Windows.Forms.Label version;
    }
}