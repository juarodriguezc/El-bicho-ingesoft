﻿namespace chatbottest1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add_volunteer));
            this.dato_erroneo_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.comboBox_genero = new System.Windows.Forms.ComboBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.dato_erroneo_cedula = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.dato_erroneo_email = new System.Windows.Forms.Label();
            this.dato_erroneo_apellido = new System.Windows.Forms.Label();
            this.dato_erroneo_nombre = new System.Windows.Forms.Label();
            this.fecha_nacimiento = new System.Windows.Forms.Label();
            this.pick_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lbl_addUser = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.Button();
            this.bt_adduser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.comboboxTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dato_erroneo_telefono
            // 
            this.dato_erroneo_telefono.AutoSize = true;
            this.dato_erroneo_telefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_telefono.Location = new System.Drawing.Point(248, 145);
            this.dato_erroneo_telefono.Name = "dato_erroneo_telefono";
            this.dato_erroneo_telefono.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_telefono.TabIndex = 61;
            this.dato_erroneo_telefono.Text = "Dato erróneo";
            this.dato_erroneo_telefono.Visible = false;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.White;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.DimGray;
            this.txt_telefono.Location = new System.Drawing.Point(247, 113);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(213, 20);
            this.txt_telefono.TabIndex = 60;
            this.txt_telefono.Text = "TELÉFONO";
            this.txt_telefono.Enter += new System.EventHandler(this.txt_telefono_Enter);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // comboBox_genero
            // 
            this.comboBox_genero.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Femenino"});
            this.comboBox_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_genero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_genero.FormattingEnabled = true;
            this.comboBox_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox_genero.Location = new System.Drawing.Point(233, 342);
            this.comboBox_genero.Name = "comboBox_genero";
            this.comboBox_genero.Size = new System.Drawing.Size(227, 29);
            this.comboBox_genero.TabIndex = 59;
            this.comboBox_genero.SelectedIndexChanged += new System.EventHandler(this.comboBox_genero_SelectedIndexChanged);
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_genero.Location = new System.Drawing.Point(22, 350);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(78, 21);
            this.lbl_genero.TabIndex = 58;
            this.lbl_genero.Text = "GENERO";
            this.lbl_genero.Click += new System.EventHandler(this.lbl_genero_Click);
            // 
            // dato_erroneo_cedula
            // 
            this.dato_erroneo_cedula.AutoSize = true;
            this.dato_erroneo_cedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_cedula.Location = new System.Drawing.Point(19, 147);
            this.dato_erroneo_cedula.Name = "dato_erroneo_cedula";
            this.dato_erroneo_cedula.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_cedula.TabIndex = 57;
            this.dato_erroneo_cedula.Text = "Dato erróneo";
            this.dato_erroneo_cedula.Visible = false;
            // 
            // txt_cedula
            // 
            this.txt_cedula.BackColor = System.Drawing.Color.White;
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cedula.Location = new System.Drawing.Point(22, 113);
            this.txt_cedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cedula.MaxLength = 30;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(206, 20);
            this.txt_cedula.TabIndex = 56;
            this.txt_cedula.Text = "CÉDULA";
            this.txt_cedula.Enter += new System.EventHandler(this.txt_cedula_Enter);
            this.txt_cedula.Leave += new System.EventHandler(this.txt_cedula_Leave);
            // 
            // dato_erroneo_email
            // 
            this.dato_erroneo_email.AutoSize = true;
            this.dato_erroneo_email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_email.Location = new System.Drawing.Point(23, 262);
            this.dato_erroneo_email.Name = "dato_erroneo_email";
            this.dato_erroneo_email.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_email.TabIndex = 55;
            this.dato_erroneo_email.Text = "Dato erróneo";
            this.dato_erroneo_email.Visible = false;
            // 
            // dato_erroneo_apellido
            // 
            this.dato_erroneo_apellido.AutoSize = true;
            this.dato_erroneo_apellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_apellido.Location = new System.Drawing.Point(250, 204);
            this.dato_erroneo_apellido.Name = "dato_erroneo_apellido";
            this.dato_erroneo_apellido.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_apellido.TabIndex = 54;
            this.dato_erroneo_apellido.Text = "Dato erróneo";
            this.dato_erroneo_apellido.Visible = false;
            // 
            // dato_erroneo_nombre
            // 
            this.dato_erroneo_nombre.AutoSize = true;
            this.dato_erroneo_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_erroneo_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.dato_erroneo_nombre.Location = new System.Drawing.Point(21, 204);
            this.dato_erroneo_nombre.Name = "dato_erroneo_nombre";
            this.dato_erroneo_nombre.Size = new System.Drawing.Size(88, 17);
            this.dato_erroneo_nombre.TabIndex = 53;
            this.dato_erroneo_nombre.Text = "Dato erróneo";
            this.dato_erroneo_nombre.Visible = false;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.AutoSize = true;
            this.fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nacimiento.ForeColor = System.Drawing.Color.DimGray;
            this.fecha_nacimiento.Location = new System.Drawing.Point(20, 292);
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.Size = new System.Drawing.Size(199, 21);
            this.fecha_nacimiento.TabIndex = 52;
            this.fecha_nacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // pick_fecha_nacimiento
            // 
            this.pick_fecha_nacimiento.CustomFormat = "dd-MM-yyyy";
            this.pick_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_fecha_nacimiento.Location = new System.Drawing.Point(233, 287);
            this.pick_fecha_nacimiento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.pick_fecha_nacimiento.Name = "pick_fecha_nacimiento";
            this.pick_fecha_nacimiento.Size = new System.Drawing.Size(226, 27);
            this.pick_fecha_nacimiento.TabIndex = 51;
            this.pick_fecha_nacimiento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.White;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_correo.Location = new System.Drawing.Point(24, 233);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(434, 20);
            this.txt_correo.TabIndex = 50;
            this.txt_correo.Text = "CORREO ELECTRÓNICO";
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.White;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.DimGray;
            this.txt_apellido.Location = new System.Drawing.Point(253, 171);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(222, 20);
            this.txt_apellido.TabIndex = 49;
            this.txt_apellido.Text = "APELLIDO";
            this.txt_apellido.Enter += new System.EventHandler(this.txt_apellido_Enter);
            this.txt_apellido.Leave += new System.EventHandler(this.txt_apellido_Leave);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nombre.Location = new System.Drawing.Point(22, 171);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(206, 20);
            this.txt_nombre.TabIndex = 48;
            this.txt_nombre.Text = "NOMBRE";
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_Enter);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 18;
            this.lineShape4.X2 = 215;
            this.lineShape4.Y1 = 135;
            this.lineShape4.Y2 = 135;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 19;
            this.lineShape1.X2 = 216;
            this.lineShape1.Y1 = 194;
            this.lineShape1.Y2 = 194;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 249;
            this.lineShape2.X2 = 455;
            this.lineShape2.Y1 = 194;
            this.lineShape2.Y2 = 194;
            // 
            // lineShape8
            // 
            this.lineShape8.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 20;
            this.lineShape8.X2 = 455;
            this.lineShape8.Y1 = 258;
            this.lineShape8.Y2 = 258;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 250;
            this.lineShape3.X2 = 455;
            this.lineShape3.Y1 = 136;
            this.lineShape3.Y2 = 136;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape8,
            this.lineShape2,
            this.lineShape1,
            this.lineShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(494, 573);
            this.shapeContainer1.TabIndex = 62;
            this.shapeContainer1.TabStop = false;
            // 
            // lbl_addUser
            // 
            this.lbl_addUser.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addUser.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_addUser.Location = new System.Drawing.Point(0, 33);
            this.lbl_addUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addUser.Name = "lbl_addUser";
            this.lbl_addUser.Size = new System.Drawing.Size(494, 49);
            this.lbl_addUser.TabIndex = 63;
            this.lbl_addUser.Text = "AÑADIR PERSONA";
            this.lbl_addUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_addUser.Click += new System.EventHandler(this.lbl_addUser_Click);
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
            this.backHome.Location = new System.Drawing.Point(46, 498);
            this.backHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(101, 33);
            this.backHome.TabIndex = 69;
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
            this.bt_adduser.Location = new System.Drawing.Point(228, 498);
            this.bt_adduser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_adduser.Name = "bt_adduser";
            this.bt_adduser.Size = new System.Drawing.Size(232, 33);
            this.bt_adduser.TabIndex = 68;
            this.bt_adduser.Text = "AÑADIR";
            this.bt_adduser.UseVisualStyleBackColor = false;
            this.bt_adduser.Click += new System.EventHandler(this.bt_adduser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(192, -55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 49);
            this.label1.TabIndex = 67;
            this.label1.Text = "AÑADIR USUARIO";
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPais.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Items.AddRange(new object[] {
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
            this.comboBoxPais.Location = new System.Drawing.Point(233, 388);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(227, 29);
            this.comboBoxPais.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(22, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "PAIS";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_tipo.Location = new System.Drawing.Point(22, 444);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(150, 21);
            this.lbl_tipo.TabIndex = 72;
            this.lbl_tipo.Text = "TIPO DE PERSONA";
            // 
            // comboboxTipo
            // 
            this.comboboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxTipo.FormattingEnabled = true;
            this.comboboxTipo.Items.AddRange(new object[] {
            "Voluntario",
            "Persona natural",
            "Campista"});
            this.comboboxTipo.Location = new System.Drawing.Point(233, 436);
            this.comboboxTipo.Name = "comboboxTipo";
            this.comboboxTipo.Size = new System.Drawing.Size(227, 29);
            this.comboboxTipo.TabIndex = 73;
            // 
            // Form_add_volunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 573);
            this.Controls.Add(this.comboboxTipo);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.comboBoxPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.bt_adduser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_addUser);
            this.Controls.Add(this.dato_erroneo_telefono);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.comboBox_genero);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.dato_erroneo_cedula);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.dato_erroneo_email);
            this.Controls.Add(this.dato_erroneo_apellido);
            this.Controls.Add(this.dato_erroneo_nombre);
            this.Controls.Add(this.fecha_nacimiento);
            this.Controls.Add(this.pick_fecha_nacimiento);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_add_volunteer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Añadir persona";
            this.Load += new System.EventHandler(this.Form_add_volunteer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dato_erroneo_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.ComboBox comboBox_genero;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label dato_erroneo_cedula;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label dato_erroneo_email;
        private System.Windows.Forms.Label dato_erroneo_apellido;
        private System.Windows.Forms.Label dato_erroneo_nombre;
        private System.Windows.Forms.Label fecha_nacimiento;
        private System.Windows.Forms.DateTimePicker pick_fecha_nacimiento;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lbl_addUser;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Button bt_adduser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox comboboxTipo;
    }
}