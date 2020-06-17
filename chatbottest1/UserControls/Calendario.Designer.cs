namespace chatbottest1.UserControls
{
    partial class Calendario
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_contenido = new System.Windows.Forms.Panel();
            this.bt_volver_chatbot = new System.Windows.Forms.Button();
            this.calendarioPersonalizado1 = new CalendarioPersonalizado();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 75);
            this.panel1.TabIndex = 47;
            // 
            // panel_contenido
            // 
            this.panel_contenido.Controls.Add(this.bt_volver_chatbot);
            this.panel_contenido.Controls.Add(this.calendarioPersonalizado1);
            this.panel_contenido.Location = new System.Drawing.Point(0, 80);
            this.panel_contenido.Name = "panel_contenido";
            this.panel_contenido.Size = new System.Drawing.Size(983, 591);
            this.panel_contenido.TabIndex = 48;
            // 
            // bt_volver_chatbot
            // 
            this.bt_volver_chatbot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_volver_chatbot.FlatAppearance.BorderSize = 0;
            this.bt_volver_chatbot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_volver_chatbot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_volver_chatbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_volver_chatbot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_volver_chatbot.ForeColor = System.Drawing.Color.LightGray;
            this.bt_volver_chatbot.Location = new System.Drawing.Point(63, 28);
            this.bt_volver_chatbot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_volver_chatbot.Name = "bt_volver_chatbot";
            this.bt_volver_chatbot.Size = new System.Drawing.Size(79, 33);
            this.bt_volver_chatbot.TabIndex = 46;
            this.bt_volver_chatbot.Text = "VOLVER";
            this.bt_volver_chatbot.UseVisualStyleBackColor = false;
            this.bt_volver_chatbot.Click += new System.EventHandler(this.bt_volver_chatbot_Click);
            // 
            // calendarioPersonalizado1
            // 
            this.calendarioPersonalizado1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarioPersonalizado1.Location = new System.Drawing.Point(127, 124);
            this.calendarioPersonalizado1.Name = "calendarioPersonalizado1";
            this.calendarioPersonalizado1.TabIndex = 1;
            this.calendarioPersonalizado1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.calendarioPersonalizado1.TitleForeColor = System.Drawing.Color.White;
            this.calendarioPersonalizado1.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
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
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_contenido);
            this.Controls.Add(this.panel1);
            this.Name = "Calendario";
            this.Size = new System.Drawing.Size(983, 674);
            this.panel1.ResumeLayout(false);
            this.panel_contenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_contenido;
        private CalendarioPersonalizado calendarioPersonalizado1;
        private System.Windows.Forms.Button bt_volver_chatbot;
    }
}
