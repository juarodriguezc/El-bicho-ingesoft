namespace chatbottest1
{
    partial class Form_AddPersonaPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddPersonaPrograma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGrid_voluntarios = new System.Windows.Forms.DataGridView();
            this.lbl_editUser = new System.Windows.Forms.Label();
            this.dataGrid_voluntariosProg = new System.Windows.Forms.DataGridView();
            this.Id_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_quitar = new System.Windows.Forms.Button();
            this.comboBox_programas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_saveuser = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_voluntarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_voluntariosProg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 75);
            this.panel2.TabIndex = 53;
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
            // 
            // dataGrid_voluntarios
            // 
            this.dataGrid_voluntarios.AllowUserToAddRows = false;
            this.dataGrid_voluntarios.AllowUserToDeleteRows = false;
            this.dataGrid_voluntarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_voluntarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_voluntarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_voluntarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_voluntarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_voluntarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_voluntarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_voluntarios.ColumnHeadersHeight = 45;
            this.dataGrid_voluntarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_voluntarios.EnableHeadersVisualStyles = false;
            this.dataGrid_voluntarios.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_voluntarios.Location = new System.Drawing.Point(22, 202);
            this.dataGrid_voluntarios.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid_voluntarios.MultiSelect = false;
            this.dataGrid_voluntarios.Name = "dataGrid_voluntarios";
            this.dataGrid_voluntarios.ReadOnly = true;
            this.dataGrid_voluntarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(121)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_voluntarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_voluntarios.RowHeadersVisible = false;
            this.dataGrid_voluntarios.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid_voluntarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_voluntarios.RowTemplate.Height = 24;
            this.dataGrid_voluntarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_voluntarios.Size = new System.Drawing.Size(407, 374);
            this.dataGrid_voluntarios.TabIndex = 54;
            // 
            // lbl_editUser
            // 
            this.lbl_editUser.AutoSize = true;
            this.lbl_editUser.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editUser.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_editUser.Location = new System.Drawing.Point(277, 93);
            this.lbl_editUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_editUser.Name = "lbl_editUser";
            this.lbl_editUser.Size = new System.Drawing.Size(501, 32);
            this.lbl_editUser.TabIndex = 55;
            this.lbl_editUser.Text = "AÑADIR PERSONAS A UN PROGRAMA";
            // 
            // dataGrid_voluntariosProg
            // 
            this.dataGrid_voluntariosProg.AllowUserToAddRows = false;
            this.dataGrid_voluntariosProg.AllowUserToDeleteRows = false;
            this.dataGrid_voluntariosProg.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_voluntariosProg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_voluntariosProg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_voluntariosProg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_voluntariosProg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_voluntariosProg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_voluntariosProg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_voluntariosProg.ColumnHeadersHeight = 45;
            this.dataGrid_voluntariosProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_voluntariosProg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_persona,
            this.Nombre,
            this.Apellido});
            this.dataGrid_voluntariosProg.EnableHeadersVisualStyles = false;
            this.dataGrid_voluntariosProg.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_voluntariosProg.Location = new System.Drawing.Point(566, 202);
            this.dataGrid_voluntariosProg.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid_voluntariosProg.MultiSelect = false;
            this.dataGrid_voluntariosProg.Name = "dataGrid_voluntariosProg";
            this.dataGrid_voluntariosProg.ReadOnly = true;
            this.dataGrid_voluntariosProg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(121)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_voluntariosProg.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid_voluntariosProg.RowHeadersVisible = false;
            this.dataGrid_voluntariosProg.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid_voluntariosProg.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid_voluntariosProg.RowTemplate.Height = 24;
            this.dataGrid_voluntariosProg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_voluntariosProg.Size = new System.Drawing.Size(388, 374);
            this.dataGrid_voluntariosProg.TabIndex = 56;
            // 
            // Id_persona
            // 
            this.Id_persona.HeaderText = "Id_persona";
            this.Id_persona.Name = "Id_persona";
            this.Id_persona.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // bt_agregar
            // 
            this.bt_agregar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_agregar.FlatAppearance.BorderSize = 0;
            this.bt_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar.ForeColor = System.Drawing.Color.LightGray;
            this.bt_agregar.Location = new System.Drawing.Point(455, 336);
            this.bt_agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(91, 33);
            this.bt_agregar.TabIndex = 57;
            this.bt_agregar.Text = "AGREGAR";
            this.bt_agregar.UseVisualStyleBackColor = false;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // bt_quitar
            // 
            this.bt_quitar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_quitar.FlatAppearance.BorderSize = 0;
            this.bt_quitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_quitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quitar.ForeColor = System.Drawing.Color.LightGray;
            this.bt_quitar.Location = new System.Drawing.Point(455, 396);
            this.bt_quitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_quitar.Name = "bt_quitar";
            this.bt_quitar.Size = new System.Drawing.Size(91, 33);
            this.bt_quitar.TabIndex = 58;
            this.bt_quitar.Text = "QUITAR";
            this.bt_quitar.UseVisualStyleBackColor = false;
            this.bt_quitar.Click += new System.EventHandler(this.bt_quitar_Click);
            // 
            // comboBox_programas
            // 
            this.comboBox_programas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_programas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_programas.FormattingEnabled = true;
            this.comboBox_programas.Location = new System.Drawing.Point(592, 143);
            this.comboBox_programas.Name = "comboBox_programas";
            this.comboBox_programas.Size = new System.Drawing.Size(268, 29);
            this.comboBox_programas.TabIndex = 60;
            this.comboBox_programas.SelectedIndexChanged += new System.EventHandler(this.comboBox_programas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(108, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "SELECCIONA EL PROGRAMA A AÑADIR VOLUNTARIOS";
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
            this.bt_saveuser.Location = new System.Drawing.Point(455, 543);
            this.bt_saveuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_saveuser.Name = "bt_saveuser";
            this.bt_saveuser.Size = new System.Drawing.Size(91, 33);
            this.bt_saveuser.TabIndex = 61;
            this.bt_saveuser.Text = "ACEPTAR";
            this.bt_saveuser.UseVisualStyleBackColor = false;
            this.bt_saveuser.Click += new System.EventHandler(this.bt_saveuser_Click);
            // 
            // Form_AddPersonaPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 605);
            this.Controls.Add(this.bt_saveuser);
            this.Controls.Add(this.comboBox_programas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_quitar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dataGrid_voluntariosProg);
            this.Controls.Add(this.lbl_editUser);
            this.Controls.Add(this.dataGrid_voluntarios);
            this.Controls.Add(this.panel2);
            this.Name = "Form_AddPersonaPrograma";
            this.Text = "Añadir PersonaPrograma";
            this.Load += new System.EventHandler(this.Form_AddPersonaPrograma_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_voluntarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_voluntariosProg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGrid_voluntarios;
        private System.Windows.Forms.Label lbl_editUser;
        private System.Windows.Forms.DataGridView dataGrid_voluntariosProg;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_quitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.ComboBox comboBox_programas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_saveuser;
    }
}