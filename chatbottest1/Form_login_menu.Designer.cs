using System.Drawing;

namespace chatbottest1
{
    partial class Form_login_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login_menu));
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.lbl_bienvenido = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.line_Correo = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel_logo_login = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linklbl_olvidar = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.lbl_error_data = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel_forgot = new System.Windows.Forms.Panel();
            this.labelInfoReccu = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.Button();
            this.recup_datos = new System.Windows.Forms.Button();
            this.lbl_recuperarcontrasenia = new System.Windows.Forms.Label();
            this.emailTxbRecContr = new System.Windows.Forms.TextBox();
            this.emailRecContraLbl = new System.Windows.Forms.Label();
            this.cod_incorrecto = new System.Windows.Forms.Label();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_email_ver = new System.Windows.Forms.Label();
            this.ttl_ver = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_verificacion = new System.Windows.Forms.Panel();
            this.bt_volver_inicio_codigo = new System.Windows.Forms.Button();
            this.lbl_cod_expirado = new System.Windows.Forms.Label();
            this.lbl_codigo_incorrecto = new System.Windows.Forms.Label();
            this.lbl_verificar_codigo = new System.Windows.Forms.Button();
            this.txt_codigo_ver = new System.Windows.Forms.TextBox();
            this.lbl_ingrese_cod = new System.Windows.Forms.Label();
            this.lbl_enviadocod = new System.Windows.Forms.Label();
            this.lbl_tituloverificacion = new System.Windows.Forms.Label();
            this.panel_cambio_contrasenia = new System.Windows.Forms.Panel();
            this.bt_cancelar_cambio = new System.Windows.Forms.Button();
            this.lbl_cont_req = new System.Windows.Forms.Label();
            this.lbl_verCon = new System.Windows.Forms.Label();
            this.btn_cambio_cont = new System.Windows.Forms.Button();
            this.txt_rep_cont_ver = new System.Windows.Forms.TextBox();
            this.txt_cont_ver = new System.Windows.Forms.TextBox();
            this.lbl_re_n_contra = new System.Windows.Forms.Label();
            this.lbl_n_contra = new System.Windows.Forms.Label();
            this.lbl_title_cambiocontra = new System.Windows.Forms.Label();
            this.panel_cambio_correcto = new System.Windows.Forms.Panel();
            this.lbl_cambio_correcto = new System.Windows.Forms.Label();
            this.btn_volver_login = new System.Windows.Forms.Button();
            this.panel_logo_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_login.SuspendLayout();
            this.panel_forgot.SuspendLayout();
            this.panel_verificacion.SuspendLayout();
            this.panel_cambio_contrasenia.SuspendLayout();
            this.panel_cambio_correcto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.White;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_correo.Location = new System.Drawing.Point(200, 160);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(431, 20);
            this.txt_correo.TabIndex = 0;
            this.txt_correo.Text = "CORREO";
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_contrasenia.Location = new System.Drawing.Point(200, 230);
            this.txt_contrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(431, 20);
            this.txt_contrasenia.TabIndex = 1;
            this.txt_contrasenia.Text = "CONTRASEÑA";
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
            this.bt_ingresar.Location = new System.Drawing.Point(249, 408);
            this.bt_ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(323, 33);
            this.bt_ingresar.TabIndex = 2;
            this.bt_ingresar.Text = "ACCEDER";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // lbl_bienvenido
            // 
            this.lbl_bienvenido.AutoSize = true;
            this.lbl_bienvenido.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienvenido.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_bienvenido.Location = new System.Drawing.Point(48, 48);
            this.lbl_bienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bienvenido.Name = "lbl_bienvenido";
            this.lbl_bienvenido.Size = new System.Drawing.Size(308, 56);
            this.lbl_bienvenido.TabIndex = 6;
            this.lbl_bienvenido.Text = "BIENVENIDO";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 200;
            this.lineShape1.X2 = 630;
            this.lineShape1.Y1 = 260;
            this.lineShape1.Y2 = 260;
            // 
            // line_Correo
            // 
            this.line_Correo.BorderColor = System.Drawing.Color.DimGray;
            this.line_Correo.Name = "line_Correo";
            this.line_Correo.X1 = 200;
            this.line_Correo.X2 = 630;
            this.line_Correo.Y1 = 190;
            this.line_Correo.Y2 = 190;
            // 
            // panel_logo_login
            // 
            this.panel_logo_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel_logo_login.Controls.Add(this.pictureBox1);
            this.panel_logo_login.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_logo_login.Location = new System.Drawing.Point(812, 0);
            this.panel_logo_login.Name = "panel_logo_login";
            this.panel_logo_login.Size = new System.Drawing.Size(450, 673);
            this.panel_logo_login.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-61, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 355);
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
            this.linklbl_olvidar.Location = new System.Drawing.Point(428, 313);
            this.linklbl_olvidar.Name = "linklbl_olvidar";
            this.linklbl_olvidar.Size = new System.Drawing.Size(166, 17);
            this.linklbl_olvidar.TabIndex = 11;
            this.linklbl_olvidar.TabStop = true;
            this.linklbl_olvidar.Text = "¿Olvidaste tu contraseña?";
            this.linklbl_olvidar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_olvidar_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(242, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "ACCEDE A TU CUENTA";
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.lbl_error_data);
            this.panel_login.Controls.Add(this.bt_ingresar);
            this.panel_login.Controls.Add(this.linklbl_olvidar);
            this.panel_login.Controls.Add(this.txt_contrasenia);
            this.panel_login.Controls.Add(this.label4);
            this.panel_login.Controls.Add(this.txt_correo);
            this.panel_login.Controls.Add(this.shapeContainer2);
            this.panel_login.Location = new System.Drawing.Point(0, 149);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(818, 494);
            this.panel_login.TabIndex = 13;
            this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_login_Paint);
            // 
            // lbl_error_data
            // 
            this.lbl_error_data.AutoSize = true;
            this.lbl_error_data.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_error_data.Location = new System.Drawing.Point(196, 277);
            this.lbl_error_data.Name = "lbl_error_data";
            this.lbl_error_data.Size = new System.Drawing.Size(110, 19);
            this.lbl_error_data.TabIndex = 37;
            this.lbl_error_data.Text = "Datos erróneos";
            this.lbl_error_data.Visible = false;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.line_Correo});
            this.shapeContainer2.Size = new System.Drawing.Size(818, 494);
            this.shapeContainer2.TabIndex = 13;
            this.shapeContainer2.TabStop = false;
            // 
            // panel_forgot
            // 
            this.panel_forgot.Controls.Add(this.labelInfoReccu);
            this.panel_forgot.Controls.Add(this.backHome);
            this.panel_forgot.Controls.Add(this.recup_datos);
            this.panel_forgot.Controls.Add(this.lbl_recuperarcontrasenia);
            this.panel_forgot.Controls.Add(this.emailTxbRecContr);
            this.panel_forgot.Controls.Add(this.emailRecContraLbl);
            this.panel_forgot.Location = new System.Drawing.Point(0, 149);
            this.panel_forgot.Name = "panel_forgot";
            this.panel_forgot.Size = new System.Drawing.Size(818, 494);
            this.panel_forgot.TabIndex = 14;
            this.panel_forgot.Visible = false;
            // 
            // labelInfoReccu
            // 
            this.labelInfoReccu.AutoSize = true;
            this.labelInfoReccu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoReccu.ForeColor = System.Drawing.Color.DimGray;
            this.labelInfoReccu.Location = new System.Drawing.Point(186, 145);
            this.labelInfoReccu.Name = "labelInfoReccu";
            this.labelInfoReccu.Size = new System.Drawing.Size(348, 42);
            this.labelInfoReccu.TabIndex = 34;
            this.labelInfoReccu.Text = "Ingresa tu email para realizar el proceso de \r\nrecuperación de contraseña";
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
            this.backHome.Location = new System.Drawing.Point(60, 408);
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
            this.recup_datos.Location = new System.Drawing.Point(564, 408);
            this.recup_datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recup_datos.Name = "recup_datos";
            this.recup_datos.Size = new System.Drawing.Size(162, 33);
            this.recup_datos.TabIndex = 32;
            this.recup_datos.Text = "RECUPERAR";
            this.recup_datos.UseVisualStyleBackColor = false;
            this.recup_datos.Click += new System.EventHandler(this.recup_datos_Click);
            // 
            // lbl_recuperarcontrasenia
            // 
            this.lbl_recuperarcontrasenia.AutoSize = true;
            this.lbl_recuperarcontrasenia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recuperarcontrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_recuperarcontrasenia.Location = new System.Drawing.Point(216, 55);
            this.lbl_recuperarcontrasenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recuperarcontrasenia.Name = "lbl_recuperarcontrasenia";
            this.lbl_recuperarcontrasenia.Size = new System.Drawing.Size(320, 30);
            this.lbl_recuperarcontrasenia.TabIndex = 31;
            this.lbl_recuperarcontrasenia.Text = "RECUPERAR CONTRASEÑA";
            this.lbl_recuperarcontrasenia.Click += new System.EventHandler(this.label5_Click);
            // 
            // emailTxbRecContr
            // 
            this.emailTxbRecContr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxbRecContr.ForeColor = System.Drawing.Color.DimGray;
            this.emailTxbRecContr.Location = new System.Drawing.Point(305, 257);
            this.emailTxbRecContr.MaxLength = 80;
            this.emailTxbRecContr.Multiline = true;
            this.emailTxbRecContr.Name = "emailTxbRecContr";
            this.emailTxbRecContr.Size = new System.Drawing.Size(370, 30);
            this.emailTxbRecContr.TabIndex = 28;
            this.emailTxbRecContr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTxbRecContr_KeyDown);
            // 
            // emailRecContraLbl
            // 
            this.emailRecContraLbl.AutoSize = true;
            this.emailRecContraLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRecContraLbl.ForeColor = System.Drawing.Color.DimGray;
            this.emailRecContraLbl.Location = new System.Drawing.Point(147, 260);
            this.emailRecContraLbl.Name = "emailRecContraLbl";
            this.emailRecContraLbl.Size = new System.Drawing.Size(56, 21);
            this.emailRecContraLbl.TabIndex = 27;
            this.emailRecContraLbl.Text = "E-mail";
            // 
            // cod_incorrecto
            // 
            this.cod_incorrecto.Location = new System.Drawing.Point(0, 0);
            this.cod_incorrecto.Name = "cod_incorrecto";
            this.cod_incorrecto.Size = new System.Drawing.Size(100, 23);
            this.cod_incorrecto.TabIndex = 0;
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(0, 0);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(75, 23);
            this.btn_verificar.TabIndex = 0;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_version.Location = new System.Drawing.Point(13, 646);
            this.lbl_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(68, 15);
            this.lbl_version.TabIndex = 5;
            this.lbl_version.Text = "Version 2.0";
            // 
            // lbl_email_ver
            // 
            this.lbl_email_ver.Location = new System.Drawing.Point(0, 0);
            this.lbl_email_ver.Name = "lbl_email_ver";
            this.lbl_email_ver.Size = new System.Drawing.Size(100, 23);
            this.lbl_email_ver.TabIndex = 0;
            // 
            // ttl_ver
            // 
            this.ttl_ver.Location = new System.Drawing.Point(0, 0);
            this.ttl_ver.Name = "ttl_ver";
            this.ttl_ver.Size = new System.Drawing.Size(100, 23);
            this.ttl_ver.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // panel_verificacion
            // 
            this.panel_verificacion.Controls.Add(this.bt_volver_inicio_codigo);
            this.panel_verificacion.Controls.Add(this.lbl_cod_expirado);
            this.panel_verificacion.Controls.Add(this.lbl_codigo_incorrecto);
            this.panel_verificacion.Controls.Add(this.lbl_verificar_codigo);
            this.panel_verificacion.Controls.Add(this.txt_codigo_ver);
            this.panel_verificacion.Controls.Add(this.lbl_ingrese_cod);
            this.panel_verificacion.Controls.Add(this.lbl_enviadocod);
            this.panel_verificacion.Controls.Add(this.lbl_tituloverificacion);
            this.panel_verificacion.Location = new System.Drawing.Point(0, 150);
            this.panel_verificacion.Name = "panel_verificacion";
            this.panel_verificacion.Size = new System.Drawing.Size(815, 494);
            this.panel_verificacion.TabIndex = 17;
            this.panel_verificacion.Visible = false;
            // 
            // bt_volver_inicio_codigo
            // 
            this.bt_volver_inicio_codigo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_volver_inicio_codigo.FlatAppearance.BorderSize = 0;
            this.bt_volver_inicio_codigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_volver_inicio_codigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_volver_inicio_codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_volver_inicio_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_volver_inicio_codigo.ForeColor = System.Drawing.Color.LightGray;
            this.bt_volver_inicio_codigo.Location = new System.Drawing.Point(60, 429);
            this.bt_volver_inicio_codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_volver_inicio_codigo.Name = "bt_volver_inicio_codigo";
            this.bt_volver_inicio_codigo.Size = new System.Drawing.Size(101, 33);
            this.bt_volver_inicio_codigo.TabIndex = 45;
            this.bt_volver_inicio_codigo.Text = "VOLVER";
            this.bt_volver_inicio_codigo.UseVisualStyleBackColor = false;
            this.bt_volver_inicio_codigo.Click += new System.EventHandler(this.bt_volver_inicio_codigo_Click);
            // 
            // lbl_cod_expirado
            // 
            this.lbl_cod_expirado.AutoSize = true;
            this.lbl_cod_expirado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_expirado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_cod_expirado.Location = new System.Drawing.Point(245, 408);
            this.lbl_cod_expirado.Name = "lbl_cod_expirado";
            this.lbl_cod_expirado.Size = new System.Drawing.Size(273, 38);
            this.lbl_cod_expirado.TabIndex = 40;
            this.lbl_cod_expirado.Text = "El codigo ha expirado. \r\nSe ha enviado uno nuevo a su correo.\r\n";
            this.lbl_cod_expirado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_cod_expirado.Visible = false;
            // 
            // lbl_codigo_incorrecto
            // 
            this.lbl_codigo_incorrecto.AutoSize = true;
            this.lbl_codigo_incorrecto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_incorrecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_codigo_incorrecto.Location = new System.Drawing.Point(320, 297);
            this.lbl_codigo_incorrecto.Name = "lbl_codigo_incorrecto";
            this.lbl_codigo_incorrecto.Size = new System.Drawing.Size(134, 19);
            this.lbl_codigo_incorrecto.TabIndex = 39;
            this.lbl_codigo_incorrecto.Text = "Código Incorrecto";
            this.lbl_codigo_incorrecto.Visible = false;
            // 
            // lbl_verificar_codigo
            // 
            this.lbl_verificar_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_verificar_codigo.FlatAppearance.BorderSize = 0;
            this.lbl_verificar_codigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lbl_verificar_codigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_verificar_codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_verificar_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_verificar_codigo.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_verificar_codigo.Location = new System.Drawing.Point(314, 355);
            this.lbl_verificar_codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_verificar_codigo.Name = "lbl_verificar_codigo";
            this.lbl_verificar_codigo.Size = new System.Drawing.Size(179, 33);
            this.lbl_verificar_codigo.TabIndex = 38;
            this.lbl_verificar_codigo.Text = "VERIFICAR";
            this.lbl_verificar_codigo.UseVisualStyleBackColor = false;
            this.lbl_verificar_codigo.Click += new System.EventHandler(this.lbl_verificar_codigo_Click);
            // 
            // txt_codigo_ver
            // 
            this.txt_codigo_ver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_ver.ForeColor = System.Drawing.Color.DimGray;
            this.txt_codigo_ver.Location = new System.Drawing.Point(314, 252);
            this.txt_codigo_ver.MaxLength = 80;
            this.txt_codigo_ver.Multiline = true;
            this.txt_codigo_ver.Name = "txt_codigo_ver";
            this.txt_codigo_ver.Size = new System.Drawing.Size(179, 30);
            this.txt_codigo_ver.TabIndex = 37;
            // 
            // lbl_ingrese_cod
            // 
            this.lbl_ingrese_cod.AutoSize = true;
            this.lbl_ingrese_cod.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingrese_cod.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_ingrese_cod.Location = new System.Drawing.Point(258, 154);
            this.lbl_ingrese_cod.Name = "lbl_ingrese_cod";
            this.lbl_ingrese_cod.Size = new System.Drawing.Size(218, 22);
            this.lbl_ingrese_cod.TabIndex = 36;
            this.lbl_ingrese_cod.Text = "Ingrese aquí el código:";
            // 
            // lbl_enviadocod
            // 
            this.lbl_enviadocod.AutoSize = true;
            this.lbl_enviadocod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enviadocod.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_enviadocod.Location = new System.Drawing.Point(165, 91);
            this.lbl_enviadocod.Name = "lbl_enviadocod";
            this.lbl_enviadocod.Size = new System.Drawing.Size(414, 21);
            this.lbl_enviadocod.TabIndex = 35;
            this.lbl_enviadocod.Text = "Se ha enviado un codigo de verificación a tu correo";
            // 
            // lbl_tituloverificacion
            // 
            this.lbl_tituloverificacion.AutoSize = true;
            this.lbl_tituloverificacion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloverificacion.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_tituloverificacion.Location = new System.Drawing.Point(279, 36);
            this.lbl_tituloverificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tituloverificacion.Name = "lbl_tituloverificacion";
            this.lbl_tituloverificacion.Size = new System.Drawing.Size(184, 30);
            this.lbl_tituloverificacion.TabIndex = 13;
            this.lbl_tituloverificacion.Text = "VERIFICACIÓN";
            // 
            // panel_cambio_contrasenia
            // 
            this.panel_cambio_contrasenia.Controls.Add(this.bt_cancelar_cambio);
            this.panel_cambio_contrasenia.Controls.Add(this.lbl_cont_req);
            this.panel_cambio_contrasenia.Controls.Add(this.lbl_verCon);
            this.panel_cambio_contrasenia.Controls.Add(this.btn_cambio_cont);
            this.panel_cambio_contrasenia.Controls.Add(this.txt_rep_cont_ver);
            this.panel_cambio_contrasenia.Controls.Add(this.txt_cont_ver);
            this.panel_cambio_contrasenia.Controls.Add(this.lbl_re_n_contra);
            this.panel_cambio_contrasenia.Controls.Add(this.lbl_n_contra);
            this.panel_cambio_contrasenia.Controls.Add(this.lbl_title_cambiocontra);
            this.panel_cambio_contrasenia.Location = new System.Drawing.Point(0, 150);
            this.panel_cambio_contrasenia.Name = "panel_cambio_contrasenia";
            this.panel_cambio_contrasenia.Size = new System.Drawing.Size(809, 492);
            this.panel_cambio_contrasenia.TabIndex = 18;
            this.panel_cambio_contrasenia.Visible = false;
            // 
            // bt_cancelar_cambio
            // 
            this.bt_cancelar_cambio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_cancelar_cambio.FlatAppearance.BorderSize = 0;
            this.bt_cancelar_cambio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_cancelar_cambio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_cancelar_cambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_cancelar_cambio.ForeColor = System.Drawing.Color.LightGray;
            this.bt_cancelar_cambio.Location = new System.Drawing.Point(44, 429);
            this.bt_cancelar_cambio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cancelar_cambio.Name = "bt_cancelar_cambio";
            this.bt_cancelar_cambio.Size = new System.Drawing.Size(128, 33);
            this.bt_cancelar_cambio.TabIndex = 44;
            this.bt_cancelar_cambio.Text = "CANCELAR";
            this.bt_cancelar_cambio.UseVisualStyleBackColor = false;
            this.bt_cancelar_cambio.Click += new System.EventHandler(this.bt_cancelar_cambio_Click);
            // 
            // lbl_cont_req
            // 
            this.lbl_cont_req.AutoSize = true;
            this.lbl_cont_req.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cont_req.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_cont_req.Location = new System.Drawing.Point(217, 318);
            this.lbl_cont_req.Name = "lbl_cont_req";
            this.lbl_cont_req.Size = new System.Drawing.Size(310, 19);
            this.lbl_cont_req.TabIndex = 43;
            this.lbl_cont_req.Text = "Las contraseña no cumple con los requisitos";
            this.lbl_cont_req.Visible = false;
            // 
            // lbl_verCon
            // 
            this.lbl_verCon.AutoSize = true;
            this.lbl_verCon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_verCon.Location = new System.Drawing.Point(217, 318);
            this.lbl_verCon.Name = "lbl_verCon";
            this.lbl_verCon.Size = new System.Drawing.Size(214, 19);
            this.lbl_verCon.TabIndex = 42;
            this.lbl_verCon.Text = "Las contraseñas no coinciden";
            this.lbl_verCon.Visible = false;
            // 
            // btn_cambio_cont
            // 
            this.btn_cambio_cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.btn_cambio_cont.FlatAppearance.BorderSize = 0;
            this.btn_cambio_cont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_cambio_cont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cambio_cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambio_cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_cambio_cont.ForeColor = System.Drawing.Color.LightGray;
            this.btn_cambio_cont.Location = new System.Drawing.Point(419, 392);
            this.btn_cambio_cont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cambio_cont.Name = "btn_cambio_cont";
            this.btn_cambio_cont.Size = new System.Drawing.Size(270, 33);
            this.btn_cambio_cont.TabIndex = 41;
            this.btn_cambio_cont.Text = "GUARDAR";
            this.btn_cambio_cont.UseVisualStyleBackColor = false;
            this.btn_cambio_cont.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_rep_cont_ver
            // 
            this.txt_rep_cont_ver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rep_cont_ver.ForeColor = System.Drawing.Color.DimGray;
            this.txt_rep_cont_ver.Location = new System.Drawing.Point(419, 256);
            this.txt_rep_cont_ver.MaxLength = 80;
            this.txt_rep_cont_ver.Multiline = true;
            this.txt_rep_cont_ver.Name = "txt_rep_cont_ver";
            this.txt_rep_cont_ver.PasswordChar = '•';
            this.txt_rep_cont_ver.Size = new System.Drawing.Size(270, 30);
            this.txt_rep_cont_ver.TabIndex = 40;
            // 
            // txt_cont_ver
            // 
            this.txt_cont_ver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cont_ver.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cont_ver.Location = new System.Drawing.Point(419, 160);
            this.txt_cont_ver.MaxLength = 80;
            this.txt_cont_ver.Multiline = true;
            this.txt_cont_ver.Name = "txt_cont_ver";
            this.txt_cont_ver.PasswordChar = '•';
            this.txt_cont_ver.Size = new System.Drawing.Size(270, 30);
            this.txt_cont_ver.TabIndex = 39;
            // 
            // lbl_re_n_contra
            // 
            this.lbl_re_n_contra.AutoSize = true;
            this.lbl_re_n_contra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_re_n_contra.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_re_n_contra.Location = new System.Drawing.Point(81, 259);
            this.lbl_re_n_contra.Name = "lbl_re_n_contra";
            this.lbl_re_n_contra.Size = new System.Drawing.Size(233, 21);
            this.lbl_re_n_contra.TabIndex = 38;
            this.lbl_re_n_contra.Text = "Repita la nueva contraseña:";
            // 
            // lbl_n_contra
            // 
            this.lbl_n_contra.AutoSize = true;
            this.lbl_n_contra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n_contra.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_n_contra.Location = new System.Drawing.Point(81, 167);
            this.lbl_n_contra.Name = "lbl_n_contra";
            this.lbl_n_contra.Size = new System.Drawing.Size(161, 21);
            this.lbl_n_contra.TabIndex = 37;
            this.lbl_n_contra.Text = "Nueva contraseña:";
            // 
            // lbl_title_cambiocontra
            // 
            this.lbl_title_cambiocontra.AutoSize = true;
            this.lbl_title_cambiocontra.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_cambiocontra.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_title_cambiocontra.Location = new System.Drawing.Point(214, 54);
            this.lbl_title_cambiocontra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title_cambiocontra.Name = "lbl_title_cambiocontra";
            this.lbl_title_cambiocontra.Size = new System.Drawing.Size(321, 30);
            this.lbl_title_cambiocontra.TabIndex = 14;
            this.lbl_title_cambiocontra.Text = "CAMBIO DE CONTRASEÑA";
            // 
            // panel_cambio_correcto
            // 
            this.panel_cambio_correcto.Controls.Add(this.lbl_cambio_correcto);
            this.panel_cambio_correcto.Controls.Add(this.btn_volver_login);
            this.panel_cambio_correcto.Location = new System.Drawing.Point(0, 150);
            this.panel_cambio_correcto.Name = "panel_cambio_correcto";
            this.panel_cambio_correcto.Size = new System.Drawing.Size(803, 493);
            this.panel_cambio_correcto.TabIndex = 19;
            this.panel_cambio_correcto.Visible = false;
            // 
            // lbl_cambio_correcto
            // 
            this.lbl_cambio_correcto.AutoSize = true;
            this.lbl_cambio_correcto.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio_correcto.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_cambio_correcto.Location = new System.Drawing.Point(53, 159);
            this.lbl_cambio_correcto.Name = "lbl_cambio_correcto";
            this.lbl_cambio_correcto.Size = new System.Drawing.Size(596, 30);
            this.lbl_cambio_correcto.TabIndex = 43;
            this.lbl_cambio_correcto.Text = "Su contraseña ha sido cambiada correctamente";
            // 
            // btn_volver_login
            // 
            this.btn_volver_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.btn_volver_login.FlatAppearance.BorderSize = 0;
            this.btn_volver_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_volver_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_volver_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_volver_login.ForeColor = System.Drawing.Color.LightGray;
            this.btn_volver_login.Location = new System.Drawing.Point(305, 370);
            this.btn_volver_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_volver_login.Name = "btn_volver_login";
            this.btn_volver_login.Size = new System.Drawing.Size(179, 33);
            this.btn_volver_login.TabIndex = 42;
            this.btn_volver_login.Text = "VOLVER";
            this.btn_volver_login.UseVisualStyleBackColor = false;
            this.btn_volver_login.Click += new System.EventHandler(this.btn_volver_login_Click_1);
            // 
            // Form_login_menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel_logo_login);
            this.Controls.Add(this.lbl_bienvenido);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.panel_forgot);
            this.Controls.Add(this.panel_cambio_correcto);
            this.Controls.Add(this.panel_cambio_contrasenia);
            this.Controls.Add(this.panel_verificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_login_menu";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login chatBot";
            this.Load += new System.EventHandler(this.Login_menu_Load);
            this.Shown += new System.EventHandler(this.Form_login_menu_Shown);
            this.panel_logo_login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_forgot.ResumeLayout(false);
            this.panel_forgot.PerformLayout();
            this.panel_verificacion.ResumeLayout(false);
            this.panel_verificacion.PerformLayout();
            this.panel_cambio_contrasenia.ResumeLayout(false);
            this.panel_cambio_contrasenia.PerformLayout();
            this.panel_cambio_correcto.ResumeLayout(false);
            this.panel_cambio_correcto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.Label lbl_bienvenido;
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
        private System.Windows.Forms.Label lbl_recuperarcontrasenia;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Button recup_datos;
        private System.Windows.Forms.Label labelInfoReccu;
        private System.Windows.Forms.Label lbl_error_data;



        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_email_ver;
        private System.Windows.Forms.Label ttl_ver;
        private System.Windows.Forms.Label cod_incorrecto;
        private System.Windows.Forms.Button btn_verificar;

        
       
       
        
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        



        private System.Windows.Forms.Panel panel_verificacion;
        private System.Windows.Forms.Label lbl_cod_expirado;
        private System.Windows.Forms.Label lbl_codigo_incorrecto;
        private System.Windows.Forms.Button lbl_verificar_codigo;
        private System.Windows.Forms.TextBox txt_codigo_ver;
        private System.Windows.Forms.Label lbl_ingrese_cod;
        private System.Windows.Forms.Label lbl_enviadocod;
        private System.Windows.Forms.Label lbl_tituloverificacion;
        private System.Windows.Forms.Panel panel_cambio_contrasenia;
        private System.Windows.Forms.Label lbl_verCon;
        private System.Windows.Forms.Button btn_cambio_cont;
        private System.Windows.Forms.TextBox txt_rep_cont_ver;
        private System.Windows.Forms.TextBox txt_cont_ver;
        private System.Windows.Forms.Label lbl_re_n_contra;
        private System.Windows.Forms.Label lbl_n_contra;
        private System.Windows.Forms.Label lbl_title_cambiocontra;
        private System.Windows.Forms.Panel panel_cambio_correcto;
        private System.Windows.Forms.Label lbl_cambio_correcto;
        private System.Windows.Forms.Button btn_volver_login;
        private System.Windows.Forms.Button bt_cancelar_cambio;
        private System.Windows.Forms.Button bt_volver_inicio_codigo;
        private System.Windows.Forms.Label lbl_cont_req;
    }
}