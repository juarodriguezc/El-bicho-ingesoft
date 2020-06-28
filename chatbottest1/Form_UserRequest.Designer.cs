namespace chatbottest1
{
    partial class Form_UserRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UserRequest));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reqUser = new System.Windows.Forms.Label();
            this.asuntoSolicitud = new System.Windows.Forms.Label();
            this.datoErroneoAsuntoSolicitud = new System.Windows.Forms.Label();
            this.descrpSolicitud = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.datoErroneoDescripSoli = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.Button();
            this.bt_addRequest = new System.Windows.Forms.Button();
            this.comboBox_directivo = new System.Windows.Forms.ComboBox();
            this.comboBox_tipo_solicitud = new System.Windows.Forms.ComboBox();
            this.txt_asunto_solicitud = new System.Windows.Forms.TextBox();
            this.lbl_error_directivo = new System.Windows.Forms.Label();
            this.lbl_error_tipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 75);
            this.panel2.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // reqUser
            // 
            this.reqUser.AutoSize = true;
            this.reqUser.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqUser.ForeColor = System.Drawing.Color.DimGray;
            this.reqUser.Location = new System.Drawing.Point(301, 103);
            this.reqUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reqUser.Name = "reqUser";
            this.reqUser.Size = new System.Drawing.Size(287, 63);
            this.reqUser.TabIndex = 62;
            this.reqUser.Text = "SOLICITUD";
            // 
            // asuntoSolicitud
            // 
            this.asuntoSolicitud.AutoSize = true;
            this.asuntoSolicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asuntoSolicitud.ForeColor = System.Drawing.Color.DimGray;
            this.asuntoSolicitud.Location = new System.Drawing.Point(39, 342);
            this.asuntoSolicitud.Name = "asuntoSolicitud";
            this.asuntoSolicitud.Size = new System.Drawing.Size(192, 23);
            this.asuntoSolicitud.TabIndex = 63;
            this.asuntoSolicitud.Text = "ASUNTO SOLICITUD";
            // 
            // datoErroneoAsuntoSolicitud
            // 
            this.datoErroneoAsuntoSolicitud.AutoSize = true;
            this.datoErroneoAsuntoSolicitud.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoErroneoAsuntoSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.datoErroneoAsuntoSolicitud.Location = new System.Drawing.Point(329, 377);
            this.datoErroneoAsuntoSolicitud.Name = "datoErroneoAsuntoSolicitud";
            this.datoErroneoAsuntoSolicitud.Size = new System.Drawing.Size(134, 20);
            this.datoErroneoAsuntoSolicitud.TabIndex = 65;
            this.datoErroneoAsuntoSolicitud.Text = "Ingrese el asunto";
            this.datoErroneoAsuntoSolicitud.Visible = false;
            // 
            // descrpSolicitud
            // 
            this.descrpSolicitud.AutoSize = true;
            this.descrpSolicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrpSolicitud.ForeColor = System.Drawing.Color.DimGray;
            this.descrpSolicitud.Location = new System.Drawing.Point(39, 401);
            this.descrpSolicitud.Name = "descrpSolicitud";
            this.descrpSolicitud.Size = new System.Drawing.Size(248, 23);
            this.descrpSolicitud.TabIndex = 66;
            this.descrpSolicitud.Text = "DESCRIPCION SOLICITUD";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(43, 441);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(809, 258);
            this.txt_descripcion.TabIndex = 67;
            // 
            // datoErroneoDescripSoli
            // 
            this.datoErroneoDescripSoli.AutoSize = true;
            this.datoErroneoDescripSoli.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoErroneoDescripSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.datoErroneoDescripSoli.Location = new System.Drawing.Point(40, 702);
            this.datoErroneoDescripSoli.Name = "datoErroneoDescripSoli";
            this.datoErroneoDescripSoli.Size = new System.Drawing.Size(275, 20);
            this.datoErroneoDescripSoli.TabIndex = 68;
            this.datoErroneoDescripSoli.Text = "Ingrese la descripcion de la solicitud";
            this.datoErroneoDescripSoli.Visible = false;
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
            this.backHome.Location = new System.Drawing.Point(44, 114);
            this.backHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(113, 33);
            this.backHome.TabIndex = 69;
            this.backHome.Text = "VOLVER";
            this.backHome.UseVisualStyleBackColor = false;
            this.backHome.Click += new System.EventHandler(this.backHome_Click);
            // 
            // bt_addRequest
            // 
            this.bt_addRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_addRequest.FlatAppearance.BorderSize = 0;
            this.bt_addRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_addRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_addRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_addRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_addRequest.ForeColor = System.Drawing.Color.LightGray;
            this.bt_addRequest.Location = new System.Drawing.Point(585, 725);
            this.bt_addRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_addRequest.Name = "bt_addRequest";
            this.bt_addRequest.Size = new System.Drawing.Size(268, 33);
            this.bt_addRequest.TabIndex = 70;
            this.bt_addRequest.Text = "AÑADIR";
            this.bt_addRequest.UseVisualStyleBackColor = false;
            this.bt_addRequest.Click += new System.EventHandler(this.bt_addRequest_Click);
            // 
            // comboBox_directivo
            // 
            this.comboBox_directivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_directivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_directivo.FormattingEnabled = true;
            this.comboBox_directivo.Location = new System.Drawing.Point(331, 198);
            this.comboBox_directivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_directivo.Name = "comboBox_directivo";
            this.comboBox_directivo.Size = new System.Drawing.Size(521, 31);
            this.comboBox_directivo.TabIndex = 72;
            this.comboBox_directivo.SelectedIndexChanged += new System.EventHandler(this.comboBox_directivo_SelectedIndexChanged);
            // 
            // comboBox_tipo_solicitud
            // 
            this.comboBox_tipo_solicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo_solicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo_solicitud.FormattingEnabled = true;
            this.comboBox_tipo_solicitud.Items.AddRange(new object[] {
            "Queja",
            "Aumento",
            "Permiso",
            "Incapacidad"});
            this.comboBox_tipo_solicitud.Location = new System.Drawing.Point(331, 271);
            this.comboBox_tipo_solicitud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_tipo_solicitud.Name = "comboBox_tipo_solicitud";
            this.comboBox_tipo_solicitud.Size = new System.Drawing.Size(521, 31);
            this.comboBox_tipo_solicitud.TabIndex = 73;
            this.comboBox_tipo_solicitud.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipo_solicitud_SelectedIndexChanged);
            // 
            // txt_asunto_solicitud
            // 
            this.txt_asunto_solicitud.BackColor = System.Drawing.Color.White;
            this.txt_asunto_solicitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_asunto_solicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_asunto_solicitud.ForeColor = System.Drawing.Color.DimGray;
            this.txt_asunto_solicitud.Location = new System.Drawing.Point(333, 342);
            this.txt_asunto_solicitud.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_asunto_solicitud.Name = "txt_asunto_solicitud";
            this.txt_asunto_solicitud.Size = new System.Drawing.Size(275, 25);
            this.txt_asunto_solicitud.TabIndex = 74;
            // 
            // lbl_error_directivo
            // 
            this.lbl_error_directivo.AutoSize = true;
            this.lbl_error_directivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_directivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_error_directivo.Location = new System.Drawing.Point(329, 238);
            this.lbl_error_directivo.Name = "lbl_error_directivo";
            this.lbl_error_directivo.Size = new System.Drawing.Size(183, 20);
            this.lbl_error_directivo.TabIndex = 76;
            this.lbl_error_directivo.Text = "Seleccione un directivo";
            this.lbl_error_directivo.Visible = false;
            // 
            // lbl_error_tipo
            // 
            this.lbl_error_tipo.AutoSize = true;
            this.lbl_error_tipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_error_tipo.Location = new System.Drawing.Point(329, 310);
            this.lbl_error_tipo.Name = "lbl_error_tipo";
            this.lbl_error_tipo.Size = new System.Drawing.Size(227, 20);
            this.lbl_error_tipo.TabIndex = 77;
            this.lbl_error_tipo.Text = "Seleccione el tipo de solicitud";
            this.lbl_error_tipo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(39, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 78;
            this.label1.Text = "TIPO DE SOLICITUD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(45, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "DIRECTIVO";
            // 
            // Form_UserRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 788);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_error_tipo);
            this.Controls.Add(this.lbl_error_directivo);
            this.Controls.Add(this.txt_asunto_solicitud);
            this.Controls.Add(this.comboBox_tipo_solicitud);
            this.Controls.Add(this.comboBox_directivo);
            this.Controls.Add(this.bt_addRequest);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.datoErroneoDescripSoli);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.descrpSolicitud);
            this.Controls.Add(this.datoErroneoAsuntoSolicitud);
            this.Controls.Add(this.asuntoSolicitud);
            this.Controls.Add(this.reqUser);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_UserRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de usuario";
            this.Load += new System.EventHandler(this.Form_UserRequest_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label reqUser;
        private System.Windows.Forms.Label asuntoSolicitud;
        private System.Windows.Forms.Label datoErroneoAsuntoSolicitud;
        private System.Windows.Forms.Label descrpSolicitud;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label datoErroneoDescripSoli;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Button bt_addRequest;
        private System.Windows.Forms.ComboBox comboBox_directivo;
        private System.Windows.Forms.ComboBox comboBox_tipo_solicitud;
        private System.Windows.Forms.TextBox txt_asunto_solicitud;
        private System.Windows.Forms.Label lbl_error_directivo;
        private System.Windows.Forms.Label lbl_error_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}