namespace chatbottest1
{
    partial class Form_EditProgramInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditProgramInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_saveuser = new System.Windows.Forms.Button();
            this.fechaIniPrograma = new System.Windows.Forms.Label();
            this.pick_fechaIni = new System.Windows.Forms.DateTimePicker();
            this.lbl_editProgram = new System.Windows.Forms.Label();
            this.fechaFinPrograma = new System.Windows.Forms.Label();
            this.pick_fechaFin = new System.Windows.Forms.DateTimePicker();
            this.labelNombreCompa = new System.Windows.Forms.Label();
            this.labelTipoPrograma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.comboBoxNombresCompan = new System.Windows.Forms.ComboBox();
            this.txt_ProgramName = new System.Windows.Forms.TextBox();
            this.comboBoxTipoPrograma = new System.Windows.Forms.ComboBox();
            this.dato_erroneo_nombre = new System.Windows.Forms.Label();
            this.dato_erroneo_compania = new System.Windows.Forms.Label();
            this.dato_erroneo_tipo_programa = new System.Windows.Forms.Label();
            this.dato_erroneo_fechaIni = new System.Windows.Forms.Label();
            this.dato_erroneo_fechaFin = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 61);
            this.panel2.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(9, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(121)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(570, 284);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_editar.FlatAppearance.BorderSize = 0;
            this.bt_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(644, 396);
            this.bt_editar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(68, 27);
            this.bt_editar.TabIndex = 63;
            this.bt_editar.Text = "EDITAR";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Visible = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_saveuser
            // 
            this.bt_saveuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_saveuser.FlatAppearance.BorderSize = 0;
            this.bt_saveuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_saveuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_saveuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_saveuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_saveuser.ForeColor = System.Drawing.Color.White;
            this.bt_saveuser.Location = new System.Drawing.Point(813, 396);
            this.bt_saveuser.Margin = new System.Windows.Forms.Padding(2);
            this.bt_saveuser.Name = "bt_saveuser";
            this.bt_saveuser.Size = new System.Drawing.Size(188, 27);
            this.bt_saveuser.TabIndex = 62;
            this.bt_saveuser.Text = "GUARDAR";
            this.bt_saveuser.UseVisualStyleBackColor = false;
            this.bt_saveuser.Visible = false;
            this.bt_saveuser.Click += new System.EventHandler(this.bt_saveuser_Click);
            // 
            // fechaIniPrograma
            // 
            this.fechaIniPrograma.AutoSize = true;
            this.fechaIniPrograma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaIniPrograma.ForeColor = System.Drawing.Color.DimGray;
            this.fechaIniPrograma.Location = new System.Drawing.Point(604, 289);
            this.fechaIniPrograma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fechaIniPrograma.Name = "fechaIniPrograma";
            this.fechaIniPrograma.Size = new System.Drawing.Size(122, 21);
            this.fechaIniPrograma.TabIndex = 59;
            this.fechaIniPrograma.Text = "FECHA INICIO";
            // 
            // pick_fechaIni
            // 
            this.pick_fechaIni.CustomFormat = "dd-MM-yyyy";
            this.pick_fechaIni.Enabled = false;
            this.pick_fechaIni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_fechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_fechaIni.Location = new System.Drawing.Point(813, 284);
            this.pick_fechaIni.Margin = new System.Windows.Forms.Padding(2);
            this.pick_fechaIni.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.pick_fechaIni.Name = "pick_fechaIni";
            this.pick_fechaIni.Size = new System.Drawing.Size(221, 27);
            this.pick_fechaIni.TabIndex = 58;
            this.pick_fechaIni.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_editProgram
            // 
            this.lbl_editProgram.AutoSize = true;
            this.lbl_editProgram.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editProgram.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_editProgram.Location = new System.Drawing.Point(590, 82);
            this.lbl_editProgram.Name = "lbl_editProgram";
            this.lbl_editProgram.Size = new System.Drawing.Size(268, 32);
            this.lbl_editProgram.TabIndex = 57;
            this.lbl_editProgram.Text = "EDITAR PROGRAMA";
            // 
            // fechaFinPrograma
            // 
            this.fechaFinPrograma.AutoSize = true;
            this.fechaFinPrograma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFinPrograma.ForeColor = System.Drawing.Color.DimGray;
            this.fechaFinPrograma.Location = new System.Drawing.Point(604, 338);
            this.fechaFinPrograma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fechaFinPrograma.Name = "fechaFinPrograma";
            this.fechaFinPrograma.Size = new System.Drawing.Size(93, 21);
            this.fechaFinPrograma.TabIndex = 71;
            this.fechaFinPrograma.Text = "FECHA FIN";
            // 
            // pick_fechaFin
            // 
            this.pick_fechaFin.CustomFormat = "dd-MM-yyyy";
            this.pick_fechaFin.Enabled = false;
            this.pick_fechaFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_fechaFin.Location = new System.Drawing.Point(813, 332);
            this.pick_fechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.pick_fechaFin.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.pick_fechaFin.Name = "pick_fechaFin";
            this.pick_fechaFin.Size = new System.Drawing.Size(221, 27);
            this.pick_fechaFin.TabIndex = 70;
            this.pick_fechaFin.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // labelNombreCompa
            // 
            this.labelNombreCompa.AutoSize = true;
            this.labelNombreCompa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCompa.ForeColor = System.Drawing.Color.DimGray;
            this.labelNombreCompa.Location = new System.Drawing.Point(598, 186);
            this.labelNombreCompa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreCompa.Name = "labelNombreCompa";
            this.labelNombreCompa.Size = new System.Drawing.Size(108, 21);
            this.labelNombreCompa.TabIndex = 72;
            this.labelNombreCompa.Text = " COMPAÑIA";
            // 
            // labelTipoPrograma
            // 
            this.labelTipoPrograma.AutoSize = true;
            this.labelTipoPrograma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoPrograma.ForeColor = System.Drawing.Color.DimGray;
            this.labelTipoPrograma.Location = new System.Drawing.Point(604, 235);
            this.labelTipoPrograma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoPrograma.Name = "labelTipoPrograma";
            this.labelTipoPrograma.Size = new System.Drawing.Size(148, 21);
            this.labelTipoPrograma.TabIndex = 74;
            this.labelTipoPrograma.Text = "TIPO PROGRAMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(604, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 76;
            this.label1.Text = "NOMBRE PROGRAMA";
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 806;
            this.lineShape3.X2 = 1030;
            this.lineShape3.Y1 = 162;
            this.lineShape3.Y2 = 162;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(1052, 458);
            this.shapeContainer1.TabIndex = 77;
            this.shapeContainer1.TabStop = false;
            // 
            // comboBoxNombresCompan
            // 
            this.comboBoxNombresCompan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNombresCompan.Enabled = false;
            this.comboBoxNombresCompan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNombresCompan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxNombresCompan.FormattingEnabled = true;
            this.comboBoxNombresCompan.Location = new System.Drawing.Point(807, 183);
            this.comboBoxNombresCompan.Name = "comboBoxNombresCompan";
            this.comboBoxNombresCompan.Size = new System.Drawing.Size(225, 29);
            this.comboBoxNombresCompan.TabIndex = 78;
            // 
            // txt_ProgramName
            // 
            this.txt_ProgramName.BackColor = System.Drawing.Color.White;
            this.txt_ProgramName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ProgramName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProgramName.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ProgramName.Location = new System.Drawing.Point(811, 138);
            this.txt_ProgramName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ProgramName.Name = "txt_ProgramName";
            this.txt_ProgramName.ReadOnly = true;
            this.txt_ProgramName.Size = new System.Drawing.Size(225, 20);
            this.txt_ProgramName.TabIndex = 79;
            // 
            // comboBoxTipoPrograma
            // 
            this.comboBoxTipoPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoPrograma.Enabled = false;
            this.comboBoxTipoPrograma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoPrograma.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxTipoPrograma.FormattingEnabled = true;
            this.comboBoxTipoPrograma.Items.AddRange(new object[] {
            "Voluntariado",
            "Colombian programs",
            "Campers abroad"});
            this.comboBoxTipoPrograma.Location = new System.Drawing.Point(809, 232);
            this.comboBoxTipoPrograma.Name = "comboBoxTipoPrograma";
            this.comboBoxTipoPrograma.Size = new System.Drawing.Size(225, 29);
            this.comboBoxTipoPrograma.TabIndex = 80;
            // 
            // dato_erroneo_nombre
            // 
            this.dato_erroneo_nombre.AutoSize = true;
            this.dato_erroneo_nombre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_nombre.Location = new System.Drawing.Point(584, 137);
            this.dato_erroneo_nombre.Name = "dato_erroneo_nombre";
            this.dato_erroneo_nombre.Size = new System.Drawing.Size(19, 22);
            this.dato_erroneo_nombre.TabIndex = 81;
            this.dato_erroneo_nombre.Text = "*";
            this.dato_erroneo_nombre.Visible = false;
            // 
            // dato_erroneo_compania
            // 
            this.dato_erroneo_compania.AutoSize = true;
            this.dato_erroneo_compania.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_compania.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_compania.Location = new System.Drawing.Point(584, 186);
            this.dato_erroneo_compania.Name = "dato_erroneo_compania";
            this.dato_erroneo_compania.Size = new System.Drawing.Size(19, 22);
            this.dato_erroneo_compania.TabIndex = 82;
            this.dato_erroneo_compania.Text = "*";
            this.dato_erroneo_compania.Visible = false;
            // 
            // dato_erroneo_tipo_programa
            // 
            this.dato_erroneo_tipo_programa.AutoSize = true;
            this.dato_erroneo_tipo_programa.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_tipo_programa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_tipo_programa.Location = new System.Drawing.Point(584, 235);
            this.dato_erroneo_tipo_programa.Name = "dato_erroneo_tipo_programa";
            this.dato_erroneo_tipo_programa.Size = new System.Drawing.Size(19, 22);
            this.dato_erroneo_tipo_programa.TabIndex = 83;
            this.dato_erroneo_tipo_programa.Text = "*";
            this.dato_erroneo_tipo_programa.Visible = false;
            // 
            // dato_erroneo_fechaIni
            // 
            this.dato_erroneo_fechaIni.AutoSize = true;
            this.dato_erroneo_fechaIni.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_fechaIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_fechaIni.Location = new System.Drawing.Point(584, 289);
            this.dato_erroneo_fechaIni.Name = "dato_erroneo_fechaIni";
            this.dato_erroneo_fechaIni.Size = new System.Drawing.Size(19, 22);
            this.dato_erroneo_fechaIni.TabIndex = 84;
            this.dato_erroneo_fechaIni.Text = "*";
            this.dato_erroneo_fechaIni.Visible = false;
            // 
            // dato_erroneo_fechaFin
            // 
            this.dato_erroneo_fechaFin.AutoSize = true;
            this.dato_erroneo_fechaFin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_fechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_fechaFin.Location = new System.Drawing.Point(584, 338);
            this.dato_erroneo_fechaFin.Name = "dato_erroneo_fechaFin";
            this.dato_erroneo_fechaFin.Size = new System.Drawing.Size(19, 22);
            this.dato_erroneo_fechaFin.TabIndex = 85;
            this.dato_erroneo_fechaFin.Text = "*";
            this.dato_erroneo_fechaFin.Visible = false;
            // 
            // Form_EditProgramInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 458);
            this.Controls.Add(this.dato_erroneo_fechaFin);
            this.Controls.Add(this.dato_erroneo_fechaIni);
            this.Controls.Add(this.dato_erroneo_tipo_programa);
            this.Controls.Add(this.dato_erroneo_compania);
            this.Controls.Add(this.dato_erroneo_nombre);
            this.Controls.Add(this.comboBoxTipoPrograma);
            this.Controls.Add(this.txt_ProgramName);
            this.Controls.Add(this.comboBoxNombresCompan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTipoPrograma);
            this.Controls.Add(this.labelNombreCompa);
            this.Controls.Add(this.fechaFinPrograma);
            this.Controls.Add(this.pick_fechaFin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_saveuser);
            this.Controls.Add(this.fechaIniPrograma);
            this.Controls.Add(this.pick_fechaIni);
            this.Controls.Add(this.lbl_editProgram);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_EditProgramInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Informacion Programa";
            this.Load += new System.EventHandler(this.Form_EditProgramInfo_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_saveuser;
        private System.Windows.Forms.Label fechaIniPrograma;
        private System.Windows.Forms.DateTimePicker pick_fechaIni;
        private System.Windows.Forms.Label lbl_editProgram;
        private System.Windows.Forms.Label fechaFinPrograma;
        private System.Windows.Forms.DateTimePicker pick_fechaFin;
        private System.Windows.Forms.Label labelNombreCompa;
        private System.Windows.Forms.Label labelTipoPrograma;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.ComboBox comboBoxNombresCompan;
        private System.Windows.Forms.TextBox txt_ProgramName;
        private System.Windows.Forms.ComboBox comboBoxTipoPrograma;
        private System.Windows.Forms.Label dato_erroneo_nombre;
        private System.Windows.Forms.Label dato_erroneo_compania;
        private System.Windows.Forms.Label dato_erroneo_tipo_programa;
        private System.Windows.Forms.Label dato_erroneo_fechaIni;
        private System.Windows.Forms.Label dato_erroneo_fechaFin;
    }
}