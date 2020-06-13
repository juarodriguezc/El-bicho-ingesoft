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
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.button_chatbot = new System.Windows.Forms.Button();
            this.lbl_func = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.elipse_iniciales = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lbl_iniciales = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_logout = new System.Windows.Forms.Button();
            this.panel_lateral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel_lateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_lateral.Controls.Add(this.panel2);
            this.panel_lateral.Controls.Add(this.panel1);
            this.panel_lateral.Location = new System.Drawing.Point(-2, -2);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(295, 675);
            this.panel_lateral.TabIndex = 3;
            this.panel_lateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_chatbot
            // 
            this.button_chatbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.button_chatbot.FlatAppearance.BorderSize = 0;
            this.button_chatbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chatbot.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chatbot.ForeColor = System.Drawing.Color.White;
            this.button_chatbot.Location = new System.Drawing.Point(-3, 0);
            this.button_chatbot.Name = "button_chatbot";
            this.button_chatbot.Size = new System.Drawing.Size(299, 42);
            this.button_chatbot.TabIndex = 7;
            this.button_chatbot.Text = "Chatbot";
            this.button_chatbot.UseVisualStyleBackColor = false;
            // 
            // lbl_func
            // 
            this.lbl_func.AutoSize = true;
            this.lbl_func.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_func.ForeColor = System.Drawing.Color.White;
            this.lbl_func.Location = new System.Drawing.Point(191, 247);
            this.lbl_func.Name = "lbl_func";
            this.lbl_func.Size = new System.Drawing.Size(110, 19);
            this.lbl_func.TabIndex = 5;
            this.lbl_func.Text = "Funcionalidad";
            this.lbl_func.Visible = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(4, 11);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCargo.Size = new System.Drawing.Size(63, 21);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(14, 247);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nombre";
            // 
            // panel_principal
            // 
            this.panel_principal.Location = new System.Drawing.Point(290, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(971, 674);
            this.panel_principal.TabIndex = 5;
            // 
            // elipse_iniciales
            // 
            this.elipse_iniciales.BackColor = System.Drawing.Color.White;
            this.elipse_iniciales.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.elipse_iniciales.BorderColor = System.Drawing.Color.White;
            this.elipse_iniciales.Location = new System.Drawing.Point(43, 26);
            this.elipse_iniciales.Name = "elipse_iniciales";
            this.elipse_iniciales.Size = new System.Drawing.Size(200, 200);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.lbl_func);
            this.panel1.Controls.Add(this.lbl_iniciales);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 295);
            this.panel1.TabIndex = 9;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.elipse_iniciales});
            this.shapeContainer2.Size = new System.Drawing.Size(295, 295);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // lbl_iniciales
            // 
            this.lbl_iniciales.BackColor = System.Drawing.Color.White;
            this.lbl_iniciales.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_iniciales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_iniciales.Location = new System.Drawing.Point(66, 81);
            this.lbl_iniciales.Name = "lbl_iniciales";
            this.lbl_iniciales.Size = new System.Drawing.Size(160, 84);
            this.lbl_iniciales.TabIndex = 4;
            this.lbl_iniciales.Text = "MM";
            this.lbl_iniciales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_chatbot);
            this.panel2.Controls.Add(this.bt_logout);
            this.panel2.Location = new System.Drawing.Point(-1, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 385);
            this.panel2.TabIndex = 10;
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
            this.bt_logout.Image = global::chatbottest1.Properties.Resources.logout;
            this.bt_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_logout.Location = new System.Drawing.Point(0, 325);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(296, 60);
            this.bt_logout.TabIndex = 6;
            this.bt_logout.Text = "Log out";
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chatbot_menu_FormClosed);
            this.Load += new System.EventHandler(this.Chatbot_menu_Load);
            this.Leave += new System.EventHandler(this.Chatbot_menu_Leave);
            this.panel_lateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lbl_func;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button button_chatbot;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        public Microsoft.VisualBasic.PowerPacks.OvalShape elipse_iniciales;
        private System.Windows.Forms.Label lbl_iniciales;
        private System.Windows.Forms.Panel panel2;
    }
}

