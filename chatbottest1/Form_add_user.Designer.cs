﻿namespace chatbottest1
{
    partial class Form_add_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add_user));
            this.lbl_addUser = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.txt_v_contra = new System.Windows.Forms.TextBox();
            this.pick_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.fecha_nacimiento = new System.Windows.Forms.Label();
            this.bt_adduser = new System.Windows.Forms.Button();
            this.backHome = new System.Windows.Forms.Button();
            this.tipo_usuario = new System.Windows.Forms.Label();
            this.comboBox_cargo = new System.Windows.Forms.ComboBox();
            this.dato_erroneo_nombre = new System.Windows.Forms.Label();
            this.dato_erroneo_apellido = new System.Windows.Forms.Label();
            this.dato_erroneo_email = new System.Windows.Forms.Label();
            this.dato_erroneo_contrasenia = new System.Windows.Forms.Label();
            this.dato_erroneo_verificar = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.dato_erroneo_cedula = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.comboBox_genero = new System.Windows.Forms.ComboBox();
            this.dato_erroneo_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.dato_erroneo_user = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_pais_origen = new System.Windows.Forms.Label();
            this.comboBox_pais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_addUser
            // 
            this.lbl_addUser.AutoSize = true;
            this.lbl_addUser.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addUser.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_addUser.Location = new System.Drawing.Point(51, 19);
            this.lbl_addUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addUser.Name = "lbl_addUser";
            this.lbl_addUser.Size = new System.Drawing.Size(380, 49);
            this.lbl_addUser.TabIndex = 7;
            this.lbl_addUser.Text = "AÑADIR USUARIO";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nombre.Location = new System.Drawing.Point(28, 134);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(206, 20);
            this.txt_nombre.TabIndex = 8;
            this.txt_nombre.Text = "NOMBRE";
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_Enter);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.ovalShape1,
            this.lineShape8,
            this.lineShape7,
            this.lineShape3,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(494, 591);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 27;
            this.lineShape1.X2 = 233;
            this.lineShape1.Y1 = 160;
            this.lineShape1.Y2 = 160;
            // 
            // ovalShape1
            // 
            this.ovalShape1.BorderColor = System.Drawing.Color.DimGray;
            this.ovalShape1.Location = new System.Drawing.Point(28, 115);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(200, 1);
            // 
            // lineShape8
            // 
            this.lineShape8.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 26;
            this.lineShape8.X2 = 464;
            this.lineShape8.Y1 = 210;
            this.lineShape8.Y2 = 208;
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 256;
            this.lineShape7.X2 = 448;
            this.lineShape7.Y1 = 297;
            this.lineShape7.Y2 = 297;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 27;
            this.lineShape3.X2 = 219;
            this.lineShape3.Y1 = 297;
            this.lineShape3.Y2 = 297;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 258;
            this.lineShape2.X2 = 464;
            this.lineShape2.Y1 = 161;
            this.lineShape2.Y2 = 161;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.White;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.DimGray;
            this.txt_apellido.Location = new System.Drawing.Point(258, 134);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(222, 20);
            this.txt_apellido.TabIndex = 10;
            this.txt_apellido.Text = "APELLIDO";
            this.txt_apellido.Enter += new System.EventHandler(this.txt_apellido_Enter);
            this.txt_apellido.Leave += new System.EventHandler(this.txt_apellido_Leave);
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.White;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_correo.Location = new System.Drawing.Point(26, 184);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(434, 20);
            this.txt_correo.TabIndex = 11;
            this.txt_correo.Text = "CORREO";
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.BackColor = System.Drawing.Color.White;
            this.txt_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_contrasenia.Location = new System.Drawing.Point(236, 450);
            this.txt_contrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contrasenia.MaxLength = 25;
            this.txt_contrasenia.Multiline = true;
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.PasswordChar = '●';
            this.txt_contrasenia.Size = new System.Drawing.Size(228, 27);
            this.txt_contrasenia.TabIndex = 13;
            this.txt_contrasenia.TextChanged += new System.EventHandler(this.txt_contrasenia_TextChanged);
            this.txt_contrasenia.Enter += new System.EventHandler(this.txt_contrasenia_Enter);
            this.txt_contrasenia.Leave += new System.EventHandler(this.txt_contrasenia_Leave);
            // 
            // txt_v_contra
            // 
            this.txt_v_contra.BackColor = System.Drawing.Color.White;
            this.txt_v_contra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_v_contra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_v_contra.ForeColor = System.Drawing.Color.DimGray;
            this.txt_v_contra.Location = new System.Drawing.Point(238, 496);
            this.txt_v_contra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_v_contra.MaxLength = 25;
            this.txt_v_contra.Multiline = true;
            this.txt_v_contra.Name = "txt_v_contra";
            this.txt_v_contra.PasswordChar = '●';
            this.txt_v_contra.Size = new System.Drawing.Size(227, 27);
            this.txt_v_contra.TabIndex = 14;
            this.txt_v_contra.TextChanged += new System.EventHandler(this.txt_v_contra_TextChanged);
            this.txt_v_contra.Enter += new System.EventHandler(this.txt_v_contra_Enter);
            this.txt_v_contra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_v_contra_KeyDown);
            this.txt_v_contra.Leave += new System.EventHandler(this.txt_v_contra_Leave);
            // 
            // pick_fecha_nacimiento
            // 
            this.pick_fecha_nacimiento.CustomFormat = "dd-MM-yyyy";
            this.pick_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_fecha_nacimiento.Location = new System.Drawing.Point(269, 234);
            this.pick_fecha_nacimiento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.pick_fecha_nacimiento.Name = "pick_fecha_nacimiento";
            this.pick_fecha_nacimiento.Size = new System.Drawing.Size(196, 27);
            this.pick_fecha_nacimiento.TabIndex = 15;
            this.pick_fecha_nacimiento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.pick_fecha_nacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.AutoSize = true;
            this.fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nacimiento.ForeColor = System.Drawing.Color.DimGray;
            this.fecha_nacimiento.Location = new System.Drawing.Point(26, 234);
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.Size = new System.Drawing.Size(199, 21);
            this.fecha_nacimiento.TabIndex = 16;
            this.fecha_nacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // bt_adduser
            // 
            this.bt_adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_adduser.FlatAppearance.BorderSize = 0;
            this.bt_adduser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_adduser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_adduser.ForeColor = System.Drawing.Color.White;
            this.bt_adduser.Location = new System.Drawing.Point(217, 547);
            this.bt_adduser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_adduser.Name = "bt_adduser";
            this.bt_adduser.Size = new System.Drawing.Size(232, 33);
            this.bt_adduser.TabIndex = 17;
            this.bt_adduser.Text = "AÑADIR";
            this.bt_adduser.UseVisualStyleBackColor = false;
            this.bt_adduser.Click += new System.EventHandler(this.bt_adduser_Click);
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
            this.backHome.Location = new System.Drawing.Point(43, 547);
            this.backHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(101, 33);
            this.backHome.TabIndex = 34;
            this.backHome.Text = "VOLVER";
            this.backHome.UseVisualStyleBackColor = false;
            this.backHome.Click += new System.EventHandler(this.backHome_Click);
            // 
            // tipo_usuario
            // 
            this.tipo_usuario.AutoSize = true;
            this.tipo_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_usuario.ForeColor = System.Drawing.Color.DimGray;
            this.tipo_usuario.Location = new System.Drawing.Point(28, 378);
            this.tipo_usuario.Name = "tipo_usuario";
            this.tipo_usuario.Size = new System.Drawing.Size(147, 21);
            this.tipo_usuario.TabIndex = 35;
            this.tipo_usuario.Text = "TIPO DE USUARIO";
            // 
            // comboBox_cargo
            // 
            this.comboBox_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cargo.FormattingEnabled = true;
            this.comboBox_cargo.Items.AddRange(new object[] {
            "Empleado",
            "Jefe de área",
            "Administrador"});
            this.comboBox_cargo.Location = new System.Drawing.Point(237, 370);
            this.comboBox_cargo.Name = "comboBox_cargo";
            this.comboBox_cargo.Size = new System.Drawing.Size(227, 29);
            this.comboBox_cargo.TabIndex = 36;
            this.comboBox_cargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dato_erroneo_nombre
            // 
            this.dato_erroneo_nombre.AutoSize = true;
            this.dato_erroneo_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_nombre.Location = new System.Drawing.Point(27, 165);
            this.dato_erroneo_nombre.Name = "dato_erroneo_nombre";
            this.dato_erroneo_nombre.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_nombre.TabIndex = 37;
            this.dato_erroneo_nombre.Text = "Dato erróneo";
            this.dato_erroneo_nombre.Visible = false;
            // 
            // dato_erroneo_apellido
            // 
            this.dato_erroneo_apellido.AutoSize = true;
            this.dato_erroneo_apellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_apellido.Location = new System.Drawing.Point(254, 165);
            this.dato_erroneo_apellido.Name = "dato_erroneo_apellido";
            this.dato_erroneo_apellido.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_apellido.TabIndex = 38;
            this.dato_erroneo_apellido.Text = "Dato erróneo";
            this.dato_erroneo_apellido.Visible = false;
            // 
            // dato_erroneo_email
            // 
            this.dato_erroneo_email.AutoSize = true;
            this.dato_erroneo_email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_email.Location = new System.Drawing.Point(27, 217);
            this.dato_erroneo_email.Name = "dato_erroneo_email";
            this.dato_erroneo_email.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_email.TabIndex = 39;
            this.dato_erroneo_email.Text = "Dato erróneo";
            this.dato_erroneo_email.Visible = false;
            // 
            // dato_erroneo_contrasenia
            // 
            this.dato_erroneo_contrasenia.AutoSize = true;
            this.dato_erroneo_contrasenia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_contrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_contrasenia.Location = new System.Drawing.Point(376, 477);
            this.dato_erroneo_contrasenia.Name = "dato_erroneo_contrasenia";
            this.dato_erroneo_contrasenia.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_contrasenia.TabIndex = 40;
            this.dato_erroneo_contrasenia.Text = "Dato erróneo";
            this.dato_erroneo_contrasenia.Visible = false;
            // 
            // dato_erroneo_verificar
            // 
            this.dato_erroneo_verificar.AutoSize = true;
            this.dato_erroneo_verificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_verificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_verificar.Location = new System.Drawing.Point(281, 525);
            this.dato_erroneo_verificar.Name = "dato_erroneo_verificar";
            this.dato_erroneo_verificar.Size = new System.Drawing.Size(184, 17);
            this.dato_erroneo_verificar.TabIndex = 41;
            this.dato_erroneo_verificar.Text = "Las contraseñas no coinciden";
            this.dato_erroneo_verificar.Visible = false;
            // 
            // txt_cedula
            // 
            this.txt_cedula.BackColor = System.Drawing.Color.White;
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cedula.Location = new System.Drawing.Point(28, 90);
            this.txt_cedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cedula.MaxLength = 20;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(227, 20);
            this.txt_cedula.TabIndex = 42;
            this.txt_cedula.Text = "CEDULA";
            this.txt_cedula.Enter += new System.EventHandler(this.txt_cedula_Enter);
            this.txt_cedula.Leave += new System.EventHandler(this.txt_cedula_Leave);
            // 
            // dato_erroneo_cedula
            // 
            this.dato_erroneo_cedula.AutoSize = true;
            this.dato_erroneo_cedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_cedula.Location = new System.Drawing.Point(27, 120);
            this.dato_erroneo_cedula.Name = "dato_erroneo_cedula";
            this.dato_erroneo_cedula.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_cedula.TabIndex = 43;
            this.dato_erroneo_cedula.Text = "Dato erróneo";
            this.dato_erroneo_cedula.Visible = false;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_genero.Location = new System.Drawing.Point(28, 340);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(78, 21);
            this.lbl_genero.TabIndex = 44;
            this.lbl_genero.Text = "GÉNERO";
            // 
            // comboBox_genero
            // 
            this.comboBox_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_genero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_genero.FormattingEnabled = true;
            this.comboBox_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox_genero.Location = new System.Drawing.Point(237, 332);
            this.comboBox_genero.Name = "comboBox_genero";
            this.comboBox_genero.Size = new System.Drawing.Size(227, 29);
            this.comboBox_genero.TabIndex = 45;
            // 
            // dato_erroneo_telefono
            // 
            this.dato_erroneo_telefono.AutoSize = true;
            this.dato_erroneo_telefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_telefono.Location = new System.Drawing.Point(29, 306);
            this.dato_erroneo_telefono.Name = "dato_erroneo_telefono";
            this.dato_erroneo_telefono.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_telefono.TabIndex = 47;
            this.dato_erroneo_telefono.Text = "Dato erróneo";
            this.dato_erroneo_telefono.Visible = false;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.White;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.DimGray;
            this.txt_telefono.Location = new System.Drawing.Point(26, 271);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(213, 20);
            this.txt_telefono.TabIndex = 46;
            this.txt_telefono.Text = "TELEFONO";
            this.txt_telefono.Enter += new System.EventHandler(this.txt_telefono_Enter);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // dato_erroneo_user
            // 
            this.dato_erroneo_user.AutoSize = true;
            this.dato_erroneo_user.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_user.Location = new System.Drawing.Point(255, 306);
            this.dato_erroneo_user.Name = "dato_erroneo_user";
            this.dato_erroneo_user.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_user.TabIndex = 49;
            this.dato_erroneo_user.Text = "Dato erróneo";
            this.dato_erroneo_user.Visible = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.White;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.DimGray;
            this.txt_usuario.Location = new System.Drawing.Point(256, 271);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(208, 20);
            this.txt_usuario.TabIndex = 48;
            this.txt_usuario.Text = "USUARIO";
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // lbl_pais_origen
            // 
            this.lbl_pais_origen.AutoSize = true;
            this.lbl_pais_origen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pais_origen.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_pais_origen.Location = new System.Drawing.Point(28, 413);
            this.lbl_pais_origen.Name = "lbl_pais_origen";
            this.lbl_pais_origen.Size = new System.Drawing.Size(138, 21);
            this.lbl_pais_origen.TabIndex = 50;
            this.lbl_pais_origen.Text = "PAÍS DE ORIGEN";
            // 
            // comboBox_pais
            // 
            this.comboBox_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pais.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_pais.FormattingEnabled = true;
            this.comboBox_pais.Items.AddRange(new object[] {
            "Afganistán",
            "Akrotiri",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Anguila",
            "Antártida",
            "Antigua y Barbuda",
            "Antillas Neerlandesas",
            "Arabia Saudí",
            "Arctic Ocean",
            "Argelia",
            "Argentina",
            "Armenia",
            "Aruba",
            "Ashmore andCartier Islands",
            "Atlantic Ocean",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bahráin",
            "Bangladesh",
            "Barbados",
            "Bélgica",
            "Belice",
            "Benín",
            "Bermudas",
            "Bielorrusia",
            "Birmania Myanmar",
            "Bolivia",
            "Bosnia y Hercegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Clipperton Island",
            "Colombia",
            "Comoras",
            "Congo",
            "Coral Sea Islands",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dhekelia",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "El Vaticano",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Gaza Strip",
            "Georgia",
            "Ghana",
            "Gibraltar",
            "Granada",
            "Grecia",
            "Groenlandia",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinea Ecuatorial",
            "Guinea-Bissau",
            "Guyana",
            "Haití",
            "Honduras",
            "Hong Kong",
            "Hungría",
            "India",
            "Indian Ocean",
            "Indonesia",
            "Irán",
            "Iraq",
            "Irlanda",
            "Isla Bouvet",
            "Isla Christmas",
            "Isla Norfolk",
            "Islandia",
            "Islas Caimán",
            "Islas Cocos",
            "Islas Cook",
            "Islas Feroe",
            "Islas Georgia del Sur y Sandwich del Sur",
            "Islas Heard y McDonald",
            "Islas Malvinas",
            "Islas Marianas del Norte",
            "IslasMarshall",
            "Islas Pitcairn",
            "Islas Salomón",
            "Islas Turcas y Caicos",
            "Islas Vírgenes Americanas",
            "Islas Vírgenes Británicas",
            "Israel",
            "Italia",
            "Jamaica",
            "Jan Mayen",
            "Japón",
            "Jersey",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguizistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macao",
            "Macedonia",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Man, Isle of",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "Mayotte",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montserrat",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Niue",
            "Noruega",
            "Nueva Caledonia",
            "Nueva Zelanda",
            "Omán",
            "Pacific Ocean",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa-Nueva Guinea",
            "Paracel Islands",
            "Paraguay",
            "Perú",
            "Polinesia Francesa",
            "Polonia",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Sáhara Occidental",
            "Samoa",
            "Samoa Americana",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Pedro y Miquelón",
            "San Vicente y las Granadinas",
            "Santa Helena",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Southern Ocean",
            "Spratly Islands",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Suecia",
            "Suiza",
            "Surinam",
            "Svalbard y Jan Mayen",
            "Tailandia",
            "Taiwán",
            "Tanzania",
            "Tayikistán",
            "TerritorioBritánicodel Océano Indico",
            "Territorios Australes Franceses",
            "Timor Oriental",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Unión Europea",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Wake Island",
            "Wallis y Futuna",
            "West Bank",
            "World",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.comboBox_pais.Location = new System.Drawing.Point(238, 405);
            this.comboBox_pais.Name = "comboBox_pais";
            this.comboBox_pais.Size = new System.Drawing.Size(227, 29);
            this.comboBox_pais.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(26, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(28, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "VERIFICACIÓN";
            // 
            // Form_add_user
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_pais);
            this.Controls.Add(this.lbl_pais_origen);
            this.Controls.Add(this.dato_erroneo_user);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.dato_erroneo_telefono);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.comboBox_genero);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.dato_erroneo_cedula);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.dato_erroneo_verificar);
            this.Controls.Add(this.dato_erroneo_contrasenia);
            this.Controls.Add(this.dato_erroneo_email);
            this.Controls.Add(this.dato_erroneo_apellido);
            this.Controls.Add(this.dato_erroneo_nombre);
            this.Controls.Add(this.comboBox_cargo);
            this.Controls.Add(this.tipo_usuario);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.bt_adduser);
            this.Controls.Add(this.fecha_nacimiento);
            this.Controls.Add(this.pick_fecha_nacimiento);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_addUser);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.txt_v_contra);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_add_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir usuario";
            this.Load += new System.EventHandler(this.Form_add_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_addUser;
        private System.Windows.Forms.TextBox txt_nombre;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txt_apellido;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.TextBox txt_v_contra;
        private System.Windows.Forms.DateTimePicker pick_fecha_nacimiento;
        private System.Windows.Forms.Label fecha_nacimiento;
        private System.Windows.Forms.Button bt_adduser;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Label tipo_usuario;
        private System.Windows.Forms.ComboBox comboBox_cargo;
        private System.Windows.Forms.Label dato_erroneo_nombre;
        private System.Windows.Forms.Label dato_erroneo_apellido;
        private System.Windows.Forms.Label dato_erroneo_email;
        private System.Windows.Forms.Label dato_erroneo_contrasenia;
        private System.Windows.Forms.Label dato_erroneo_verificar;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label dato_erroneo_cedula;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.ComboBox comboBox_genero;
        private System.Windows.Forms.Label dato_erroneo_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private System.Windows.Forms.Label dato_erroneo_user;
        private System.Windows.Forms.TextBox txt_usuario;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private System.Windows.Forms.Label lbl_pais_origen;
        private System.Windows.Forms.ComboBox comboBox_pais;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}