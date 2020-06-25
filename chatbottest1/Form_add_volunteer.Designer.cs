namespace chatbottest1
{
    partial class Form_add_volunteer
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
            this.dato_erroneo_cedula = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.dato_erroneo_apellido = new System.Windows.Forms.Label();
            this.dato_erroneo_nombre = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.dato_erroneo_email = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.fecha_nacimiento = new System.Windows.Forms.Label();
            this.pick_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.dato_erroneo_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.comboBox_genero = new System.Windows.Forms.ComboBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.Button();
            this.bt_adduser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_addUser
            // 
            this.lbl_addUser.AutoSize = true;
            this.lbl_addUser.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addUser.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_addUser.Location = new System.Drawing.Point(65, 9);
            this.lbl_addUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addUser.Name = "lbl_addUser";
            this.lbl_addUser.Size = new System.Drawing.Size(465, 49);
            this.lbl_addUser.TabIndex = 8;
            this.lbl_addUser.Text = "AÑADIR VOLUNTARIO";
            this.lbl_addUser.Click += new System.EventHandler(this.lbl_addUser_Click);
            // 
            // dato_erroneo_cedula
            // 
            this.dato_erroneo_cedula.AutoSize = true;
            this.dato_erroneo_cedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_cedula.Location = new System.Drawing.Point(19, 106);
            this.dato_erroneo_cedula.Name = "dato_erroneo_cedula";
            this.dato_erroneo_cedula.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_cedula.TabIndex = 45;
            this.dato_erroneo_cedula.Text = "Dato erróneo";
            this.dato_erroneo_cedula.Visible = false;
            // 
            // txt_cedula
            // 
            this.txt_cedula.BackColor = System.Drawing.Color.White;
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cedula.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txt_cedula.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cedula.Location = new System.Drawing.Point(20, 78);
            this.txt_cedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(219, 18);
            this.txt_cedula.TabIndex = 44;
            this.txt_cedula.Text = "NUMERO DE IDENTIFICACION";
            // 
            // dato_erroneo_apellido
            // 
            this.dato_erroneo_apellido.AutoSize = true;
            this.dato_erroneo_apellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_apellido.Location = new System.Drawing.Point(250, 169);
            this.dato_erroneo_apellido.Name = "dato_erroneo_apellido";
            this.dato_erroneo_apellido.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_apellido.TabIndex = 49;
            this.dato_erroneo_apellido.Text = "Dato erróneo";
            this.dato_erroneo_apellido.Visible = false;
            // 
            // dato_erroneo_nombre
            // 
            this.dato_erroneo_nombre.AutoSize = true;
            this.dato_erroneo_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_nombre.Location = new System.Drawing.Point(21, 169);
            this.dato_erroneo_nombre.Name = "dato_erroneo_nombre";
            this.dato_erroneo_nombre.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_nombre.TabIndex = 48;
            this.dato_erroneo_nombre.Text = "Dato erróneo";
            this.dato_erroneo_nombre.Visible = false;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.White;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.DimGray;
            this.txt_apellido.Location = new System.Drawing.Point(253, 136);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(222, 20);
            this.txt_apellido.TabIndex = 47;
            this.txt_apellido.Text = "APELLIDO";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nombre.Location = new System.Drawing.Point(22, 136);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(206, 20);
            this.txt_nombre.TabIndex = 46;
            this.txt_nombre.Text = "NOMBRE";
            // 
            // dato_erroneo_email
            // 
            this.dato_erroneo_email.AutoSize = true;
            this.dato_erroneo_email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_email.Location = new System.Drawing.Point(21, 262);
            this.dato_erroneo_email.Name = "dato_erroneo_email";
            this.dato_erroneo_email.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_email.TabIndex = 51;
            this.dato_erroneo_email.Text = "Dato erróneo";
            this.dato_erroneo_email.Visible = false;
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.White;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_correo.Location = new System.Drawing.Point(22, 233);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(434, 20);
            this.txt_correo.TabIndex = 50;
            this.txt_correo.Text = "CORREO";
            // 
            // lineShape8
            // 
            this.lineShape8.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 23;
            this.lineShape8.X2 = 423;
            this.lineShape8.Y1 = 256;
            this.lineShape8.Y2 = 256;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 20;
            this.lineShape4.X2 = 233;
            this.lineShape4.Y1 = 103;
            this.lineShape4.Y2 = 103;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 251;
            this.lineShape2.X2 = 457;
            this.lineShape2.Y1 = 160;
            this.lineShape2.Y2 = 160;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 22;
            this.lineShape1.X2 = 219;
            this.lineShape1.Y1 = 160;
            this.lineShape1.Y2 = 160;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape1,
            this.lineShape2,
            this.lineShape4,
            this.lineShape8});
            this.shapeContainer1.Size = new System.Drawing.Size(538, 450);
            this.shapeContainer1.TabIndex = 52;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 23;
            this.lineShape3.X2 = 215;
            this.lineShape3.Y1 = 313;
            this.lineShape3.Y2 = 313;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.AutoSize = true;
            this.fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nacimiento.ForeColor = System.Drawing.Color.DimGray;
            this.fecha_nacimiento.Location = new System.Drawing.Point(16, 200);
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.Size = new System.Drawing.Size(199, 21);
            this.fecha_nacimiento.TabIndex = 54;
            this.fecha_nacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // pick_fecha_nacimiento
            // 
            this.pick_fecha_nacimiento.CustomFormat = "dd-MM-yyyy";
            this.pick_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_fecha_nacimiento.Location = new System.Drawing.Point(291, 195);
            this.pick_fecha_nacimiento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.pick_fecha_nacimiento.Name = "pick_fecha_nacimiento";
            this.pick_fecha_nacimiento.Size = new System.Drawing.Size(169, 27);
            this.pick_fecha_nacimiento.TabIndex = 53;
            this.pick_fecha_nacimiento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dato_erroneo_telefono
            // 
            this.dato_erroneo_telefono.AutoSize = true;
            this.dato_erroneo_telefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_telefono.Location = new System.Drawing.Point(19, 320);
            this.dato_erroneo_telefono.Name = "dato_erroneo_telefono";
            this.dato_erroneo_telefono.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_telefono.TabIndex = 58;
            this.dato_erroneo_telefono.Text = "Dato erróneo";
            this.dato_erroneo_telefono.Visible = false;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.White;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.DimGray;
            this.txt_telefono.Location = new System.Drawing.Point(20, 291);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(213, 20);
            this.txt_telefono.TabIndex = 57;
            this.txt_telefono.Text = "TELEFONO";
            // 
            // comboBox_genero
            // 
            this.comboBox_genero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_genero.FormattingEnabled = true;
            this.comboBox_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox_genero.Location = new System.Drawing.Point(229, 350);
            this.comboBox_genero.Name = "comboBox_genero";
            this.comboBox_genero.Size = new System.Drawing.Size(227, 29);
            this.comboBox_genero.TabIndex = 56;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_genero.Location = new System.Drawing.Point(18, 353);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(78, 21);
            this.lbl_genero.TabIndex = 55;
            this.lbl_genero.Text = "GENERO";
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
            this.backHome.Location = new System.Drawing.Point(60, 406);
            this.backHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(101, 33);
            this.backHome.TabIndex = 60;
            this.backHome.Text = "VOLVER";
            this.backHome.UseVisualStyleBackColor = false;
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
            this.bt_adduser.Location = new System.Drawing.Point(235, 406);
            this.bt_adduser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_adduser.Name = "bt_adduser";
            this.bt_adduser.Size = new System.Drawing.Size(232, 33);
            this.bt_adduser.TabIndex = 59;
            this.bt_adduser.Text = "AÑADIR";
            this.bt_adduser.UseVisualStyleBackColor = false;
            this.bt_adduser.Click += new System.EventHandler(this.bt_adduser_Click);
            // 
            // Form_add_volunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.bt_adduser);
            this.Controls.Add(this.dato_erroneo_telefono);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.comboBox_genero);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.fecha_nacimiento);
            this.Controls.Add(this.pick_fecha_nacimiento);
            this.Controls.Add(this.dato_erroneo_email);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.dato_erroneo_apellido);
            this.Controls.Add(this.dato_erroneo_nombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.dato_erroneo_cedula);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.lbl_addUser);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form_add_volunteer";
            this.Text = "Añadir voluntario";
            this.Load += new System.EventHandler(this.Form_add_volunteer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_addUser;
        private System.Windows.Forms.Label dato_erroneo_cedula;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label dato_erroneo_apellido;
        private System.Windows.Forms.Label dato_erroneo_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label dato_erroneo_email;
        private System.Windows.Forms.TextBox txt_correo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label fecha_nacimiento;
        private System.Windows.Forms.DateTimePicker pick_fecha_nacimiento;
        private System.Windows.Forms.Label dato_erroneo_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.ComboBox comboBox_genero;
        private System.Windows.Forms.Label lbl_genero;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Button bt_adduser;
    }
}