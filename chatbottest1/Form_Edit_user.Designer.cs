namespace chatbottest1
{
    partial class Form_Edit_user
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lbl_editUser = new System.Windows.Forms.Label();
            this.pick_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.fecha_nacimiento = new System.Windows.Forms.Label();
            this.tipo_usuario = new System.Windows.Forms.Label();
            this.comboBox_cargo = new System.Windows.Forms.ComboBox();
            this.bt_saveuser = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.dato_erroneo_nombre = new System.Windows.Forms.Label();
            this.dato_erroneo_apellido = new System.Windows.Forms.Label();
            this.dato_erroneo_email = new System.Windows.Forms.Label();
            this.dato_erroneo_contrasenia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nombre.Location = new System.Drawing.Point(580, 110);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(280, 25);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "NOMBRE";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.White;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.DimGray;
            this.txt_apellido.Location = new System.Drawing.Point(580, 150);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(299, 25);
            this.txt_apellido.TabIndex = 2;
            this.txt_apellido.Text = "APELLIDO";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.White;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_correo.Location = new System.Drawing.Point(580, 190);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(299, 25);
            this.txt_correo.TabIndex = 3;
            this.txt_correo.Text = "CORREO";
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.BackColor = System.Drawing.Color.White;
            this.txt_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_contrasenia.Location = new System.Drawing.Point(580, 230);
            this.txt_contrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(299, 25);
            this.txt_contrasenia.TabIndex = 4;
            this.txt_contrasenia.Text = "CONTRASEÑA";
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 580;
            this.lineShape3.X2 = 860;
            this.lineShape3.Y1 = 140;
            this.lineShape3.Y2 = 140;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2,
            this.lineShape1,
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(882, 453);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 580;
            this.lineShape4.X2 = 860;
            this.lineShape4.Y1 = 260;
            this.lineShape4.Y2 = 260;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 580;
            this.lineShape2.X2 = 860;
            this.lineShape2.Y1 = 220;
            this.lineShape2.Y2 = 220;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 580;
            this.lineShape1.X2 = 860;
            this.lineShape1.Y1 = 180;
            this.lineShape1.Y2 = 180;
            // 
            // lbl_editUser
            // 
            this.lbl_editUser.AutoSize = true;
            this.lbl_editUser.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editUser.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_editUser.Location = new System.Drawing.Point(586, 27);
            this.lbl_editUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_editUser.Name = "lbl_editUser";
            this.lbl_editUser.Size = new System.Drawing.Size(271, 39);
            this.lbl_editUser.TabIndex = 8;
            this.lbl_editUser.Text = "EDITAR USUARIO";
            // 
            // pick_fecha_nacimiento
            // 
            this.pick_fecha_nacimiento.CustomFormat = "dd-MM-yyyy";
            this.pick_fecha_nacimiento.Enabled = false;
            this.pick_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_fecha_nacimiento.Location = new System.Drawing.Point(692, 296);
            this.pick_fecha_nacimiento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.pick_fecha_nacimiento.Name = "pick_fecha_nacimiento";
            this.pick_fecha_nacimiento.Size = new System.Drawing.Size(169, 32);
            this.pick_fecha_nacimiento.TabIndex = 16;
            this.pick_fecha_nacimiento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.AutoSize = true;
            this.fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nacimiento.ForeColor = System.Drawing.Color.DimGray;
            this.fecha_nacimiento.Location = new System.Drawing.Point(576, 270);
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.Size = new System.Drawing.Size(238, 23);
            this.fecha_nacimiento.TabIndex = 17;
            this.fecha_nacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // tipo_usuario
            // 
            this.tipo_usuario.AutoSize = true;
            this.tipo_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_usuario.ForeColor = System.Drawing.Color.DimGray;
            this.tipo_usuario.Location = new System.Drawing.Point(576, 331);
            this.tipo_usuario.Name = "tipo_usuario";
            this.tipo_usuario.Size = new System.Drawing.Size(175, 23);
            this.tipo_usuario.TabIndex = 36;
            this.tipo_usuario.Text = "TIPO DE USUARIO";
            // 
            // comboBox_cargo
            // 
            this.comboBox_cargo.Enabled = false;
            this.comboBox_cargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cargo.FormattingEnabled = true;
            this.comboBox_cargo.Items.AddRange(new object[] {
            "Empleado",
            "Jefe de área",
            "Administrador"});
            this.comboBox_cargo.Location = new System.Drawing.Point(692, 355);
            this.comboBox_cargo.Name = "comboBox_cargo";
            this.comboBox_cargo.Size = new System.Drawing.Size(169, 31);
            this.comboBox_cargo.TabIndex = 37;
            // 
            // bt_saveuser
            // 
            this.bt_saveuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_saveuser.FlatAppearance.BorderSize = 0;
            this.bt_saveuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_saveuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_saveuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_saveuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_saveuser.ForeColor = System.Drawing.Color.LightGray;
            this.bt_saveuser.Location = new System.Drawing.Point(728, 408);
            this.bt_saveuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_saveuser.Name = "bt_saveuser";
            this.bt_saveuser.Size = new System.Drawing.Size(133, 33);
            this.bt_saveuser.TabIndex = 39;
            this.bt_saveuser.Text = "GUARDAR";
            this.bt_saveuser.UseVisualStyleBackColor = false;
            this.bt_saveuser.Click += new System.EventHandler(this.bt_saveuser_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_editar.FlatAppearance.BorderSize = 0;
            this.bt_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar.ForeColor = System.Drawing.Color.LightGray;
            this.bt_editar.Location = new System.Drawing.Point(580, 411);
            this.bt_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(85, 28);
            this.bt_editar.TabIndex = 40;
            this.bt_editar.Text = "EDITAR";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // dato_erroneo_nombre
            // 
            this.dato_erroneo_nombre.AutoSize = true;
            this.dato_erroneo_nombre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_nombre.Location = new System.Drawing.Point(562, 111);
            this.dato_erroneo_nombre.Name = "dato_erroneo_nombre";
            this.dato_erroneo_nombre.Size = new System.Drawing.Size(23, 30);
            this.dato_erroneo_nombre.TabIndex = 41;
            this.dato_erroneo_nombre.Text = "*";
            this.dato_erroneo_nombre.Visible = false;
            // 
            // dato_erroneo_apellido
            // 
            this.dato_erroneo_apellido.AutoSize = true;
            this.dato_erroneo_apellido.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_apellido.Location = new System.Drawing.Point(562, 151);
            this.dato_erroneo_apellido.Name = "dato_erroneo_apellido";
            this.dato_erroneo_apellido.Size = new System.Drawing.Size(23, 30);
            this.dato_erroneo_apellido.TabIndex = 42;
            this.dato_erroneo_apellido.Text = "*";
            this.dato_erroneo_apellido.Visible = false;
            // 
            // dato_erroneo_email
            // 
            this.dato_erroneo_email.AutoSize = true;
            this.dato_erroneo_email.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_email.Location = new System.Drawing.Point(562, 190);
            this.dato_erroneo_email.Name = "dato_erroneo_email";
            this.dato_erroneo_email.Size = new System.Drawing.Size(23, 30);
            this.dato_erroneo_email.TabIndex = 43;
            this.dato_erroneo_email.Text = "*";
            this.dato_erroneo_email.Visible = false;
            // 
            // dato_erroneo_contrasenia
            // 
            this.dato_erroneo_contrasenia.AutoSize = true;
            this.dato_erroneo_contrasenia.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_contrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_contrasenia.Location = new System.Drawing.Point(562, 231);
            this.dato_erroneo_contrasenia.Name = "dato_erroneo_contrasenia";
            this.dato_erroneo_contrasenia.Size = new System.Drawing.Size(23, 30);
            this.dato_erroneo_contrasenia.TabIndex = 44;
            this.dato_erroneo_contrasenia.Text = "*";
            this.dato_erroneo_contrasenia.Visible = false;
            // 
            // Form_Edit_user
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.dato_erroneo_contrasenia);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.dato_erroneo_email);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.dato_erroneo_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dato_erroneo_nombre);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_saveuser);
            this.Controls.Add(this.comboBox_cargo);
            this.Controls.Add(this.tipo_usuario);
            this.Controls.Add(this.fecha_nacimiento);
            this.Controls.Add(this.pick_fecha_nacimiento);
            this.Controls.Add(this.lbl_editUser);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form_Edit_user";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_user";
            this.Load += new System.EventHandler(this.Edit_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lbl_editUser;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.DateTimePicker pick_fecha_nacimiento;
        private System.Windows.Forms.Label fecha_nacimiento;
        private System.Windows.Forms.Label tipo_usuario;
        private System.Windows.Forms.ComboBox comboBox_cargo;
        private System.Windows.Forms.Button bt_saveuser;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Label dato_erroneo_nombre;
        private System.Windows.Forms.Label dato_erroneo_apellido;
        private System.Windows.Forms.Label dato_erroneo_email;
        private System.Windows.Forms.Label dato_erroneo_contrasenia;
    }
}