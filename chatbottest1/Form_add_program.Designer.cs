namespace chatbottest1
{
    partial class Form_add_program
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
            this.lbl_add_program = new System.Windows.Forms.Label();
            this.lbl_errorNombrePrograma = new System.Windows.Forms.Label();
            this.txt_programa = new System.Windows.Forms.TextBox();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pick_fecha_inicioPrograma = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.Label();
            this.pick_fecha_finPrograma = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.Button();
            this.bt_adduser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipoPrograma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_company = new System.Windows.Forms.ComboBox();
            this.lbl_fechaInicioErronea = new System.Windows.Forms.Label();
            this.lbl_FechaFinErronea = new System.Windows.Forms.Label();
            this.lbl_errorCompania = new System.Windows.Forms.Label();
            this.lbl_error_tipo_programa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_add_program
            // 
            this.lbl_add_program.AutoSize = true;
            this.lbl_add_program.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_program.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_add_program.Location = new System.Drawing.Point(33, 40);
            this.lbl_add_program.Name = "lbl_add_program";
            this.lbl_add_program.Size = new System.Drawing.Size(446, 49);
            this.lbl_add_program.TabIndex = 9;
            this.lbl_add_program.Text = "AÑADIR PROGRAMA";
            // 
            // lbl_errorNombrePrograma
            // 
            this.lbl_errorNombrePrograma.AutoSize = true;
            this.lbl_errorNombrePrograma.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorNombrePrograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_errorNombrePrograma.Location = new System.Drawing.Point(159, 166);
            this.lbl_errorNombrePrograma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_errorNombrePrograma.Name = "lbl_errorNombrePrograma";
            this.lbl_errorNombrePrograma.Size = new System.Drawing.Size(198, 17);
            this.lbl_errorNombrePrograma.TabIndex = 50;
            this.lbl_errorNombrePrograma.Text = "Ingrese el nombre del programa";
            this.lbl_errorNombrePrograma.Visible = false;
            // 
            // txt_programa
            // 
            this.txt_programa.BackColor = System.Drawing.Color.White;
            this.txt_programa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_programa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_programa.ForeColor = System.Drawing.Color.DimGray;
            this.txt_programa.Location = new System.Drawing.Point(71, 131);
            this.txt_programa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_programa.Name = "txt_programa";
            this.txt_programa.Size = new System.Drawing.Size(383, 20);
            this.txt_programa.TabIndex = 49;
            this.txt_programa.Text = "NOMBRE DEL PROGRAMA";
            this.txt_programa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_programa.Enter += new System.EventHandler(this.txt_programa_Enter);
            this.txt_programa.Leave += new System.EventHandler(this.txt_programa_Leave);
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 54;
            this.lineShape4.X2 = 434;
            this.lineShape4.Y1 = 158;
            this.lineShape4.Y2 = 159;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(506, 518);
            this.shapeContainer1.TabIndex = 51;
            this.shapeContainer1.TabStop = false;
            // 
            // pick_fecha_inicioPrograma
            // 
            this.pick_fecha_inicioPrograma.CustomFormat = "dd-MM-yyyy";
            this.pick_fecha_inicioPrograma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_fecha_inicioPrograma.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_fecha_inicioPrograma.Location = new System.Drawing.Point(258, 265);
            this.pick_fecha_inicioPrograma.Margin = new System.Windows.Forms.Padding(2);
            this.pick_fecha_inicioPrograma.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.pick_fecha_inicioPrograma.Name = "pick_fecha_inicioPrograma";
            this.pick_fecha_inicioPrograma.Size = new System.Drawing.Size(196, 27);
            this.pick_fecha_inicioPrograma.TabIndex = 57;
            this.pick_fecha_inicioPrograma.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSize = true;
            this.fechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio.ForeColor = System.Drawing.Color.DimGray;
            this.fechaInicio.Location = new System.Drawing.Point(49, 265);
            this.fechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(122, 21);
            this.fechaInicio.TabIndex = 56;
            this.fechaInicio.Text = "FECHA INICIO";
            // 
            // pick_fecha_finPrograma
            // 
            this.pick_fecha_finPrograma.CustomFormat = "dd-MM-yyyy";
            this.pick_fecha_finPrograma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_fecha_finPrograma.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_fecha_finPrograma.Location = new System.Drawing.Point(258, 325);
            this.pick_fecha_finPrograma.Margin = new System.Windows.Forms.Padding(2);
            this.pick_fecha_finPrograma.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.pick_fecha_finPrograma.Name = "pick_fecha_finPrograma";
            this.pick_fecha_finPrograma.Size = new System.Drawing.Size(196, 27);
            this.pick_fecha_finPrograma.TabIndex = 59;
            this.pick_fecha_finPrograma.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(49, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "FECHA FINALIZACION";
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
            this.backHome.Location = new System.Drawing.Point(53, 450);
            this.backHome.Margin = new System.Windows.Forms.Padding(2);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(169, 27);
            this.backHome.TabIndex = 61;
            this.backHome.Text = "VOLVER";
            this.backHome.UseVisualStyleBackColor = false;
            this.backHome.Click += new System.EventHandler(this.backHome_Click);
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
            this.bt_adduser.Location = new System.Drawing.Point(269, 450);
            this.bt_adduser.Margin = new System.Windows.Forms.Padding(2);
            this.bt_adduser.Name = "bt_adduser";
            this.bt_adduser.Size = new System.Drawing.Size(185, 27);
            this.bt_adduser.TabIndex = 60;
            this.bt_adduser.Text = "AÑADIR";
            this.bt_adduser.UseVisualStyleBackColor = false;
            this.bt_adduser.Click += new System.EventHandler(this.bt_adduser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(49, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "TIPO DE PROGRAMA";
            // 
            // cmb_tipoPrograma
            // 
            this.cmb_tipoPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoPrograma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoPrograma.FormattingEnabled = true;
            this.cmb_tipoPrograma.Items.AddRange(new object[] {
            "Voluntariado",
            "Colombian programs",
            "Campers abroad"});
            this.cmb_tipoPrograma.Location = new System.Drawing.Point(258, 385);
            this.cmb_tipoPrograma.Name = "cmb_tipoPrograma";
            this.cmb_tipoPrograma.Size = new System.Drawing.Size(196, 29);
            this.cmb_tipoPrograma.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(49, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "COMPAÑIA";
            // 
            // cmb_company
            // 
            this.cmb_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_company.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_company.FormattingEnabled = true;
            this.cmb_company.Location = new System.Drawing.Point(258, 205);
            this.cmb_company.Name = "cmb_company";
            this.cmb_company.Size = new System.Drawing.Size(196, 29);
            this.cmb_company.TabIndex = 65;
            // 
            // lbl_fechaInicioErronea
            // 
            this.lbl_fechaInicioErronea.AutoSize = true;
            this.lbl_fechaInicioErronea.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaInicioErronea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_fechaInicioErronea.Location = new System.Drawing.Point(51, 288);
            this.lbl_fechaInicioErronea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fechaInicioErronea.Name = "lbl_fechaInicioErronea";
            this.lbl_fechaInicioErronea.Size = new System.Drawing.Size(95, 17);
            this.lbl_fechaInicioErronea.TabIndex = 66;
            this.lbl_fechaInicioErronea.Text = "Fecha erronea";
            this.lbl_fechaInicioErronea.Visible = false;
            // 
            // lbl_FechaFinErronea
            // 
            this.lbl_FechaFinErronea.AutoSize = true;
            this.lbl_FechaFinErronea.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaFinErronea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_FechaFinErronea.Location = new System.Drawing.Point(50, 346);
            this.lbl_FechaFinErronea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FechaFinErronea.Name = "lbl_FechaFinErronea";
            this.lbl_FechaFinErronea.Size = new System.Drawing.Size(95, 17);
            this.lbl_FechaFinErronea.TabIndex = 67;
            this.lbl_FechaFinErronea.Text = "Fecha erronea";
            this.lbl_FechaFinErronea.Visible = false;
            // 
            // lbl_errorCompania
            // 
            this.lbl_errorCompania.AutoSize = true;
            this.lbl_errorCompania.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorCompania.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_errorCompania.Location = new System.Drawing.Point(50, 229);
            this.lbl_errorCompania.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_errorCompania.Name = "lbl_errorCompania";
            this.lbl_errorCompania.Size = new System.Drawing.Size(165, 17);
            this.lbl_errorCompania.TabIndex = 68;
            this.lbl_errorCompania.Text = "Seleccione una compañia";
            this.lbl_errorCompania.Visible = false;
            // 
            // lbl_error_tipo_programa
            // 
            this.lbl_error_tipo_programa.AutoSize = true;
            this.lbl_error_tipo_programa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_tipo_programa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_error_tipo_programa.Location = new System.Drawing.Point(50, 406);
            this.lbl_error_tipo_programa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_error_tipo_programa.Name = "lbl_error_tipo_programa";
            this.lbl_error_tipo_programa.Size = new System.Drawing.Size(198, 17);
            this.lbl_error_tipo_programa.TabIndex = 69;
            this.lbl_error_tipo_programa.Text = "Seleccione el tipo de programa";
            this.lbl_error_tipo_programa.Visible = false;
            // 
            // Form_add_program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(506, 518);
            this.Controls.Add(this.lbl_error_tipo_programa);
            this.Controls.Add(this.lbl_errorCompania);
            this.Controls.Add(this.lbl_FechaFinErronea);
            this.Controls.Add(this.lbl_fechaInicioErronea);
            this.Controls.Add(this.cmb_company);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_tipoPrograma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.bt_adduser);
            this.Controls.Add(this.pick_fecha_finPrograma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pick_fecha_inicioPrograma);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.lbl_errorNombrePrograma);
            this.Controls.Add(this.txt_programa);
            this.Controls.Add(this.lbl_add_program);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form_add_program";
            this.Text = "Form_add_program";
            this.Load += new System.EventHandler(this.Form_add_program_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_add_program;
        private System.Windows.Forms.Label lbl_errorNombrePrograma;
        private System.Windows.Forms.TextBox txt_programa;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.DateTimePicker pick_fecha_inicioPrograma;
        private System.Windows.Forms.Label fechaInicio;
        private System.Windows.Forms.DateTimePicker pick_fecha_finPrograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Button bt_adduser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tipoPrograma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_company;
        private System.Windows.Forms.Label lbl_fechaInicioErronea;
        private System.Windows.Forms.Label lbl_FechaFinErronea;
        private System.Windows.Forms.Label lbl_errorCompania;
        private System.Windows.Forms.Label lbl_error_tipo_programa;
    }
}