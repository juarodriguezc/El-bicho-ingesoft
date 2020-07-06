namespace chatbottest1
{
    partial class Form_menu_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu_principal));
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.panel_seleccion = new System.Windows.Forms.Panel();
            this.panel_fondo = new System.Windows.Forms.Panel();
            this.bt_logout = new System.Windows.Forms.Button();
            this.BtH = new System.Windows.Forms.Button();
            this.bt_calendario = new System.Windows.Forms.Button();
            this.bt_funcionalidad = new System.Windows.Forms.Button();
            this.panel_selected_window = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_profile = new System.Windows.Forms.Button();
            this.bt_chatbot = new System.Windows.Forms.Button();
            this.panel_info_basica = new System.Windows.Forms.Panel();
            this.lbl_func = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lbl_iniciales = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.elipse_iniciales = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.panel_lateral.SuspendLayout();
            this.panel_seleccion.SuspendLayout();
            this.panel_fondo.SuspendLayout();
            this.panel_info_basica.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel_lateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_lateral.Controls.Add(this.panel_seleccion);
            this.panel_lateral.Controls.Add(this.panel_info_basica);
            this.panel_lateral.Location = new System.Drawing.Point(-2, -2);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(295, 675);
            this.panel_lateral.TabIndex = 3;
            this.panel_lateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_seleccion
            // 
            this.panel_seleccion.Controls.Add(this.panel_fondo);
            this.panel_seleccion.Controls.Add(this.BtH);
            this.panel_seleccion.Controls.Add(this.bt_calendario);
            this.panel_seleccion.Controls.Add(this.bt_funcionalidad);
            this.panel_seleccion.Controls.Add(this.panel_selected_window);
            this.panel_seleccion.Controls.Add(this.button2);
            this.panel_seleccion.Controls.Add(this.bt_profile);
            this.panel_seleccion.Controls.Add(this.bt_chatbot);
            this.panel_seleccion.Location = new System.Drawing.Point(-1, 289);
            this.panel_seleccion.Name = "panel_seleccion";
            this.panel_seleccion.Size = new System.Drawing.Size(295, 385);
            this.panel_seleccion.TabIndex = 10;
            // 
            // panel_fondo
            // 
            this.panel_fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_fondo.Controls.Add(this.bt_logout);
            this.panel_fondo.Location = new System.Drawing.Point(0, 324);
            this.panel_fondo.Name = "panel_fondo";
            this.panel_fondo.Size = new System.Drawing.Size(295, 62);
            this.panel_fondo.TabIndex = 1;
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_logout.FlatAppearance.BorderSize = 0;
            this.bt_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logout.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.ForeColor = System.Drawing.Color.White;
            this.bt_logout.Image = ((System.Drawing.Image)(resources.GetObject("bt_logout.Image")));
            this.bt_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_logout.Location = new System.Drawing.Point(14, 2);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(278, 60);
            this.bt_logout.TabIndex = 6;
            this.bt_logout.Text = "             Cerrar sesión";
            this.bt_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // BtH
            // 
            this.BtH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.BtH.FlatAppearance.BorderSize = 0;
            this.BtH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtH.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtH.ForeColor = System.Drawing.Color.White;
            this.BtH.Image = ((System.Drawing.Image)(resources.GetObject("BtH.Image")));
            this.BtH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtH.Location = new System.Drawing.Point(14, 270);
            this.BtH.Name = "BtH";
            this.BtH.Size = new System.Drawing.Size(282, 54);
            this.BtH.TabIndex = 10;
            this.BtH.Text = "             Ayuda";
            this.BtH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtH.UseVisualStyleBackColor = false;
            this.BtH.Click += new System.EventHandler(this.BtH_Click);
            // 
            // bt_calendario
            // 
            this.bt_calendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_calendario.FlatAppearance.BorderSize = 0;
            this.bt_calendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_calendario.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calendario.ForeColor = System.Drawing.Color.White;
            this.bt_calendario.Image = ((System.Drawing.Image)(resources.GetObject("bt_calendario.Image")));
            this.bt_calendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_calendario.Location = new System.Drawing.Point(14, 108);
            this.bt_calendario.Name = "bt_calendario";
            this.bt_calendario.Size = new System.Drawing.Size(284, 54);
            this.bt_calendario.TabIndex = 11;
            this.bt_calendario.Text = "             Calendario";
            this.bt_calendario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_calendario.UseVisualStyleBackColor = false;
            this.bt_calendario.Click += new System.EventHandler(this.bt_calendario_Click);
            // 
            // bt_funcionalidad
            // 
            this.bt_funcionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_funcionalidad.FlatAppearance.BorderSize = 0;
            this.bt_funcionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_funcionalidad.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_funcionalidad.ForeColor = System.Drawing.Color.White;
            this.bt_funcionalidad.Image = ((System.Drawing.Image)(resources.GetObject("bt_funcionalidad.Image")));
            this.bt_funcionalidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_funcionalidad.Location = new System.Drawing.Point(14, 54);
            this.bt_funcionalidad.Name = "bt_funcionalidad";
            this.bt_funcionalidad.Size = new System.Drawing.Size(284, 54);
            this.bt_funcionalidad.TabIndex = 10;
            this.bt_funcionalidad.Text = "             Funcionalidades";
            this.bt_funcionalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_funcionalidad.UseVisualStyleBackColor = false;
            this.bt_funcionalidad.Click += new System.EventHandler(this.bt_funcionalidad_Click);
            // 
            // panel_selected_window
            // 
            this.panel_selected_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_selected_window.Location = new System.Drawing.Point(0, 0);
            this.panel_selected_window.Name = "panel_selected_window";
            this.panel_selected_window.Size = new System.Drawing.Size(14, 54);
            this.panel_selected_window.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(14, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "             Ajustes";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bt_profile
            // 
            this.bt_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_profile.FlatAppearance.BorderSize = 0;
            this.bt_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_profile.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_profile.ForeColor = System.Drawing.Color.White;
            this.bt_profile.Image = ((System.Drawing.Image)(resources.GetObject("bt_profile.Image")));
            this.bt_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_profile.Location = new System.Drawing.Point(14, 162);
            this.bt_profile.Name = "bt_profile";
            this.bt_profile.Size = new System.Drawing.Size(284, 54);
            this.bt_profile.TabIndex = 8;
            this.bt_profile.Text = "             Perfil";
            this.bt_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_profile.UseVisualStyleBackColor = false;
            this.bt_profile.Click += new System.EventHandler(this.bt_profile_Click);
            // 
            // bt_chatbot
            // 
            this.bt_chatbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_chatbot.FlatAppearance.BorderSize = 0;
            this.bt_chatbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_chatbot.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chatbot.ForeColor = System.Drawing.Color.White;
            this.bt_chatbot.Image = ((System.Drawing.Image)(resources.GetObject("bt_chatbot.Image")));
            this.bt_chatbot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chatbot.Location = new System.Drawing.Point(14, 0);
            this.bt_chatbot.Name = "bt_chatbot";
            this.bt_chatbot.Size = new System.Drawing.Size(281, 54);
            this.bt_chatbot.TabIndex = 7;
            this.bt_chatbot.Text = "             Chatbot";
            this.bt_chatbot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chatbot.UseVisualStyleBackColor = false;
            this.bt_chatbot.Click += new System.EventHandler(this.button_chatbot_Click);
            // 
            // panel_info_basica
            // 
            this.panel_info_basica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_info_basica.Controls.Add(this.lbl_func);
            this.panel_info_basica.Controls.Add(this.lblCargo);
            this.panel_info_basica.Controls.Add(this.lbl_iniciales);
            this.panel_info_basica.Controls.Add(this.lblName);
            this.panel_info_basica.Controls.Add(this.shapeContainer2);
            this.panel_info_basica.Location = new System.Drawing.Point(-1, -1);
            this.panel_info_basica.Name = "panel_info_basica";
            this.panel_info_basica.Size = new System.Drawing.Size(295, 290);
            this.panel_info_basica.TabIndex = 9;
            // 
            // lbl_func
            // 
            this.lbl_func.AutoSize = true;
            this.lbl_func.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_func.ForeColor = System.Drawing.Color.White;
            this.lbl_func.Location = new System.Drawing.Point(86, 271);
            this.lbl_func.Name = "lbl_func";
            this.lbl_func.Size = new System.Drawing.Size(86, 16);
            this.lbl_func.TabIndex = 5;
            this.lbl_func.Text = "Funcionalidad";
            this.lbl_func.Visible = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(14, 251);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCargo.Size = new System.Drawing.Size(52, 19);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo";
            // 
            // lbl_iniciales
            // 
            this.lbl_iniciales.BackColor = System.Drawing.Color.White;
            this.lbl_iniciales.Font = new System.Drawing.Font("Century Gothic", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iniciales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_iniciales.Location = new System.Drawing.Point(65, 73);
            this.lbl_iniciales.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbl_iniciales.Name = "lbl_iniciales";
            this.lbl_iniciales.Size = new System.Drawing.Size(160, 84);
            this.lbl_iniciales.TabIndex = 4;
            this.lbl_iniciales.Text = "MM";
            this.lbl_iniciales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_iniciales.Click += new System.EventHandler(this.lbl_iniciales_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(14, 228);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nombre";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.elipse_iniciales});
            this.shapeContainer2.Size = new System.Drawing.Size(295, 290);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // elipse_iniciales
            // 
            this.elipse_iniciales.BackColor = System.Drawing.Color.White;
            this.elipse_iniciales.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.elipse_iniciales.BorderColor = System.Drawing.Color.White;
            this.elipse_iniciales.Location = new System.Drawing.Point(44, 16);
            this.elipse_iniciales.Name = "elipse_iniciales";
            this.elipse_iniciales.Size = new System.Drawing.Size(200, 200);
            // 
            // panel_principal
            // 
            this.panel_principal.Location = new System.Drawing.Point(290, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(971, 674);
            this.panel_principal.TabIndex = 5;
            this.panel_principal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_principal_Paint);
            // 
            // Form_menu_principal
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.panel_lateral);
            this.MaximizeBox = false;
            this.Name = "Form_menu_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatbot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_menu_principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chatbot_menu_FormClosed);
            this.Load += new System.EventHandler(this.Chatbot_menu_Load);
            this.Leave += new System.EventHandler(this.Chatbot_menu_Leave);
            this.panel_lateral.ResumeLayout(false);
            this.panel_seleccion.ResumeLayout(false);
            this.panel_fondo.ResumeLayout(false);
            this.panel_info_basica.ResumeLayout(false);
            this.panel_info_basica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lbl_func;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_chatbot;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Panel panel_info_basica;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        public Microsoft.VisualBasic.PowerPacks.OvalShape elipse_iniciales;
        private System.Windows.Forms.Label lbl_iniciales;
        private System.Windows.Forms.Panel panel_seleccion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_selected_window;
        private System.Windows.Forms.Button bt_funcionalidad;
        private System.Windows.Forms.Button bt_calendario;
        private System.Windows.Forms.Button bt_profile;
        private System.Windows.Forms.Button BtH;
        private System.Windows.Forms.Panel panel_fondo;
    }
}

