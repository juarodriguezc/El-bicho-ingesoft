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
            this.lbl_addUser = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
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
            this.SuspendLayout();
            // 
            // lbl_addUser
            // 
            this.lbl_addUser.AutoSize = true;
            this.lbl_addUser.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addUser.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_addUser.Location = new System.Drawing.Point(34, 9);
            this.lbl_addUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addUser.Name = "lbl_addUser";
            this.lbl_addUser.Size = new System.Drawing.Size(468, 63);
            this.lbl_addUser.TabIndex = 7;
            this.lbl_addUser.Text = "AÑADIR USUARIO";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nombre.Location = new System.Drawing.Point(33, 150);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(206, 25);
            this.txt_nombre.TabIndex = 8;
            this.txt_nombre.Text = "NOMBRE";
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_Enter);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 37;
            this.lineShape1.X2 = 234;
            this.lineShape1.Y1 = 180;
            this.lineShape1.Y2 = 180;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(532, 553);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 274;
            this.lineShape6.X2 = 469;
            this.lineShape6.Y1 = 450;
            this.lineShape6.Y2 = 450;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 33;
            this.lineShape5.X2 = 233;
            this.lineShape5.Y1 = 450;
            this.lineShape5.Y2 = 450;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 40;
            this.lineShape3.X2 = 470;
            this.lineShape3.Y1 = 250;
            this.lineShape3.Y2 = 250;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 264;
            this.lineShape2.X2 = 470;
            this.lineShape2.Y1 = 179;
            this.lineShape2.Y2 = 179;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.White;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.DimGray;
            this.txt_apellido.Location = new System.Drawing.Point(262, 150);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(222, 25);
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
            this.txt_correo.Location = new System.Drawing.Point(33, 220);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(434, 25);
            this.txt_correo.TabIndex = 11;
            this.txt_correo.Text = "CORREO";
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.BackColor = System.Drawing.Color.White;
            this.txt_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_contrasenia.Location = new System.Drawing.Point(40, 420);
            this.txt_contrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contrasenia.MaxLength = 25;
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(204, 25);
            this.txt_contrasenia.TabIndex = 13;
            this.txt_contrasenia.Text = "CONTRASEÑA";
            this.txt_contrasenia.Enter += new System.EventHandler(this.txt_contrasenia_Enter);
            this.txt_contrasenia.Leave += new System.EventHandler(this.txt_contrasenia_Leave);
            // 
            // txt_v_contra
            // 
            this.txt_v_contra.BackColor = System.Drawing.Color.White;
            this.txt_v_contra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_v_contra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_v_contra.ForeColor = System.Drawing.Color.DimGray;
            this.txt_v_contra.Location = new System.Drawing.Point(274, 420);
            this.txt_v_contra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_v_contra.MaxLength = 25;
            this.txt_v_contra.Name = "txt_v_contra";
            this.txt_v_contra.Size = new System.Drawing.Size(204, 25);
            this.txt_v_contra.TabIndex = 14;
            this.txt_v_contra.Text = "VERIFICACIÓN";
            this.txt_v_contra.Enter += new System.EventHandler(this.txt_v_contra_Enter);
            this.txt_v_contra.Leave += new System.EventHandler(this.txt_v_contra_Leave);
            // 
            // pick_fecha_nacimiento
            // 
            this.pick_fecha_nacimiento.CustomFormat = "dd-MM-yyyy";
            this.pick_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_fecha_nacimiento.Location = new System.Drawing.Point(302, 283);
            this.pick_fecha_nacimiento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.pick_fecha_nacimiento.Name = "pick_fecha_nacimiento";
            this.pick_fecha_nacimiento.Size = new System.Drawing.Size(169, 32);
            this.pick_fecha_nacimiento.TabIndex = 15;
            this.pick_fecha_nacimiento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.pick_fecha_nacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.AutoSize = true;
            this.fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nacimiento.ForeColor = System.Drawing.Color.DimGray;
            this.fecha_nacimiento.Location = new System.Drawing.Point(33, 290);
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.Size = new System.Drawing.Size(238, 23);
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
            this.bt_adduser.ForeColor = System.Drawing.Color.LightGray;
            this.bt_adduser.Location = new System.Drawing.Point(297, 498);
            this.bt_adduser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_adduser.Name = "bt_adduser";
            this.bt_adduser.Size = new System.Drawing.Size(174, 33);
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
            this.backHome.Location = new System.Drawing.Point(35, 498);
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
            this.tipo_usuario.Location = new System.Drawing.Point(33, 360);
            this.tipo_usuario.Name = "tipo_usuario";
            this.tipo_usuario.Size = new System.Drawing.Size(175, 23);
            this.tipo_usuario.TabIndex = 35;
            this.tipo_usuario.Text = "TIPO DE USUARIO";
            // 
            // comboBox_cargo
            // 
            this.comboBox_cargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cargo.FormattingEnabled = true;
            this.comboBox_cargo.Items.AddRange(new object[] {
            "Empleado",
            "Jefe de área",
            "Administrador"});
            this.comboBox_cargo.Location = new System.Drawing.Point(243, 357);
            this.comboBox_cargo.Name = "comboBox_cargo";
            this.comboBox_cargo.Size = new System.Drawing.Size(227, 31);
            this.comboBox_cargo.TabIndex = 36;
            this.comboBox_cargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dato_erroneo_nombre
            // 
            this.dato_erroneo_nombre.AutoSize = true;
            this.dato_erroneo_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_nombre.Location = new System.Drawing.Point(36, 185);
            this.dato_erroneo_nombre.Name = "dato_erroneo_nombre";
            this.dato_erroneo_nombre.Size = new System.Drawing.Size(108, 20);
            this.dato_erroneo_nombre.TabIndex = 37;
            this.dato_erroneo_nombre.Text = "Dato erróneo";
            this.dato_erroneo_nombre.Visible = false;
            // 
            // dato_erroneo_apellido
            // 
            this.dato_erroneo_apellido.AutoSize = true;
            this.dato_erroneo_apellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_apellido.Location = new System.Drawing.Point(260, 185);
            this.dato_erroneo_apellido.Name = "dato_erroneo_apellido";
            this.dato_erroneo_apellido.Size = new System.Drawing.Size(108, 20);
            this.dato_erroneo_apellido.TabIndex = 38;
            this.dato_erroneo_apellido.Text = "Dato erróneo";
            this.dato_erroneo_apellido.Visible = false;
            // 
            // dato_erroneo_email
            // 
            this.dato_erroneo_email.AutoSize = true;
            this.dato_erroneo_email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_email.Location = new System.Drawing.Point(36, 255);
            this.dato_erroneo_email.Name = "dato_erroneo_email";
            this.dato_erroneo_email.Size = new System.Drawing.Size(108, 20);
            this.dato_erroneo_email.TabIndex = 39;
            this.dato_erroneo_email.Text = "Dato erróneo";
            this.dato_erroneo_email.Visible = false;
            // 
            // dato_erroneo_contrasenia
            // 
            this.dato_erroneo_contrasenia.AutoSize = true;
            this.dato_erroneo_contrasenia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_contrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_contrasenia.Location = new System.Drawing.Point(41, 455);
            this.dato_erroneo_contrasenia.Name = "dato_erroneo_contrasenia";
            this.dato_erroneo_contrasenia.Size = new System.Drawing.Size(108, 20);
            this.dato_erroneo_contrasenia.TabIndex = 40;
            this.dato_erroneo_contrasenia.Text = "Dato erróneo";
            this.dato_erroneo_contrasenia.Visible = false;
            // 
            // dato_erroneo_verificar
            // 
            this.dato_erroneo_verificar.AutoSize = true;
            this.dato_erroneo_verificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_verificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_verificar.Location = new System.Drawing.Point(270, 455);
            this.dato_erroneo_verificar.Name = "dato_erroneo_verificar";
            this.dato_erroneo_verificar.Size = new System.Drawing.Size(227, 20);
            this.dato_erroneo_verificar.TabIndex = 41;
            this.dato_erroneo_verificar.Text = "Las contraseñas no coinciden";
            this.dato_erroneo_verificar.Visible = false;
            // 
            // Form_add_user
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 553);
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
            this.Controls.Add(this.txt_v_contra);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_addUser);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form_add_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_add_user";
            this.Load += new System.EventHandler(this.Form_add_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_addUser;
        private System.Windows.Forms.TextBox txt_nombre;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txt_apellido;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.TextBox txt_correo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
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
    }
}