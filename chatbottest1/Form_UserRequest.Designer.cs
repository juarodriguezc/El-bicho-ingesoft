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
            this.datoErroneoIdPeticion = new System.Windows.Forms.Label();
            this.idPeticion = new System.Windows.Forms.TextBox();
            this.datoErroneoIdDirectivo = new System.Windows.Forms.Label();
            this.idUsuarioTo = new System.Windows.Forms.TextBox();
            this.datoErrorTipoSolicitud = new System.Windows.Forms.Label();
            this.reqUser = new System.Windows.Forms.Label();
            this.asuntoSolicitud = new System.Windows.Forms.Label();
            this.solicitudText = new System.Windows.Forms.TextBox();
            this.datoErroneoAsuntoSolicitud = new System.Windows.Forms.Label();
            this.descrpSolicitud = new System.Windows.Forms.Label();
            this.descripcionSolicitudText = new System.Windows.Forms.TextBox();
            this.datoErroneoDescripSoli = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.Button();
            this.bt_addRequest = new System.Windows.Forms.Button();
            this.tiposDeSolicitud = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 75);
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
            // datoErroneoIdPeticion
            // 
            this.datoErroneoIdPeticion.AutoSize = true;
            this.datoErroneoIdPeticion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoErroneoIdPeticion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.datoErroneoIdPeticion.Location = new System.Drawing.Point(77, 178);
            this.datoErroneoIdPeticion.Name = "datoErroneoIdPeticion";
            this.datoErroneoIdPeticion.Size = new System.Drawing.Size(108, 20);
            this.datoErroneoIdPeticion.TabIndex = 56;
            this.datoErroneoIdPeticion.Text = "Dato erróneo";
            this.datoErroneoIdPeticion.Visible = false;
            // 
            // idPeticion
            // 
            this.idPeticion.BackColor = System.Drawing.Color.White;
            this.idPeticion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idPeticion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPeticion.ForeColor = System.Drawing.Color.DimGray;
            this.idPeticion.Location = new System.Drawing.Point(81, 151);
            this.idPeticion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idPeticion.Name = "idPeticion";
            this.idPeticion.Size = new System.Drawing.Size(206, 25);
            this.idPeticion.TabIndex = 55;
            this.idPeticion.Text = "ID PETICION";
            this.idPeticion.TextChanged += new System.EventHandler(this.idPeticion_TextChanged);
            // 
            // datoErroneoIdDirectivo
            // 
            this.datoErroneoIdDirectivo.AutoSize = true;
            this.datoErroneoIdDirectivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoErroneoIdDirectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.datoErroneoIdDirectivo.Location = new System.Drawing.Point(343, 178);
            this.datoErroneoIdDirectivo.Name = "datoErroneoIdDirectivo";
            this.datoErroneoIdDirectivo.Size = new System.Drawing.Size(108, 20);
            this.datoErroneoIdDirectivo.TabIndex = 58;
            this.datoErroneoIdDirectivo.Text = "Dato erróneo";
            this.datoErroneoIdDirectivo.Visible = false;
            // 
            // idUsuarioTo
            // 
            this.idUsuarioTo.BackColor = System.Drawing.Color.White;
            this.idUsuarioTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idUsuarioTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsuarioTo.ForeColor = System.Drawing.Color.DimGray;
            this.idUsuarioTo.Location = new System.Drawing.Point(347, 151);
            this.idUsuarioTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idUsuarioTo.Name = "idUsuarioTo";
            this.idUsuarioTo.Size = new System.Drawing.Size(206, 25);
            this.idUsuarioTo.TabIndex = 57;
            this.idUsuarioTo.Text = "ID DIRECTIVO";
            this.idUsuarioTo.TextChanged += new System.EventHandler(this.idUsuarioTo_TextChanged);
            // 
            // datoErrorTipoSolicitud
            // 
            this.datoErrorTipoSolicitud.AutoSize = true;
            this.datoErrorTipoSolicitud.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoErrorTipoSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.datoErrorTipoSolicitud.Location = new System.Drawing.Point(632, 185);
            this.datoErrorTipoSolicitud.Name = "datoErrorTipoSolicitud";
            this.datoErrorTipoSolicitud.Size = new System.Drawing.Size(108, 20);
            this.datoErrorTipoSolicitud.TabIndex = 61;
            this.datoErrorTipoSolicitud.Text = "Dato erróneo";
            this.datoErrorTipoSolicitud.Visible = false;
            // 
            // reqUser
            // 
            this.reqUser.AutoSize = true;
            this.reqUser.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqUser.ForeColor = System.Drawing.Color.DimGray;
            this.reqUser.Location = new System.Drawing.Point(301, 75);
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
            this.asuntoSolicitud.Location = new System.Drawing.Point(39, 262);
            this.asuntoSolicitud.Name = "asuntoSolicitud";
            this.asuntoSolicitud.Size = new System.Drawing.Size(192, 23);
            this.asuntoSolicitud.TabIndex = 63;
            this.asuntoSolicitud.Text = "ASUNTO SOLICITUD";
            // 
            // solicitudText
            // 
            this.solicitudText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitudText.Location = new System.Drawing.Point(249, 261);
            this.solicitudText.MaxLength = 80;
            this.solicitudText.Name = "solicitudText";
            this.solicitudText.Size = new System.Drawing.Size(619, 30);
            this.solicitudText.TabIndex = 64;
            // 
            // datoErroneoAsuntoSolicitud
            // 
            this.datoErroneoAsuntoSolicitud.AutoSize = true;
            this.datoErroneoAsuntoSolicitud.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoErroneoAsuntoSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.datoErroneoAsuntoSolicitud.Location = new System.Drawing.Point(245, 294);
            this.datoErroneoAsuntoSolicitud.Name = "datoErroneoAsuntoSolicitud";
            this.datoErroneoAsuntoSolicitud.Size = new System.Drawing.Size(108, 20);
            this.datoErroneoAsuntoSolicitud.TabIndex = 65;
            this.datoErroneoAsuntoSolicitud.Text = "Dato erróneo";
            this.datoErroneoAsuntoSolicitud.Visible = false;
            // 
            // descrpSolicitud
            // 
            this.descrpSolicitud.AutoSize = true;
            this.descrpSolicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrpSolicitud.ForeColor = System.Drawing.Color.DimGray;
            this.descrpSolicitud.Location = new System.Drawing.Point(39, 324);
            this.descrpSolicitud.Name = "descrpSolicitud";
            this.descrpSolicitud.Size = new System.Drawing.Size(248, 23);
            this.descrpSolicitud.TabIndex = 66;
            this.descrpSolicitud.Text = "DESCRIPCION SOLICITUD";
            // 
            // descripcionSolicitudText
            // 
            this.descripcionSolicitudText.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionSolicitudText.Location = new System.Drawing.Point(43, 362);
            this.descripcionSolicitudText.Multiline = true;
            this.descripcionSolicitudText.Name = "descripcionSolicitudText";
            this.descripcionSolicitudText.Size = new System.Drawing.Size(825, 336);
            this.descripcionSolicitudText.TabIndex = 67;
            // 
            // datoErroneoDescripSoli
            // 
            this.datoErroneoDescripSoli.AutoSize = true;
            this.datoErroneoDescripSoli.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoErroneoDescripSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.datoErroneoDescripSoli.Location = new System.Drawing.Point(39, 701);
            this.datoErroneoDescripSoli.Name = "datoErroneoDescripSoli";
            this.datoErroneoDescripSoli.Size = new System.Drawing.Size(108, 20);
            this.datoErroneoDescripSoli.TabIndex = 68;
            this.datoErroneoDescripSoli.Text = "Dato erróneo";
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
            this.backHome.Location = new System.Drawing.Point(43, 758);
            this.backHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(101, 33);
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
            this.bt_addRequest.Location = new System.Drawing.Point(636, 758);
            this.bt_addRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_addRequest.Name = "bt_addRequest";
            this.bt_addRequest.Size = new System.Drawing.Size(232, 33);
            this.bt_addRequest.TabIndex = 70;
            this.bt_addRequest.Text = "AÑADIR";
            this.bt_addRequest.UseVisualStyleBackColor = false;
            this.bt_addRequest.Click += new System.EventHandler(this.bt_addRequest_Click);
            // 
            // tiposDeSolicitud
            // 
            this.tiposDeSolicitud.BackColor = System.Drawing.Color.White;
            this.tiposDeSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tiposDeSolicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiposDeSolicitud.ForeColor = System.Drawing.Color.DimGray;
            this.tiposDeSolicitud.Location = new System.Drawing.Point(636, 151);
            this.tiposDeSolicitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tiposDeSolicitud.Name = "tiposDeSolicitud";
            this.tiposDeSolicitud.Size = new System.Drawing.Size(206, 25);
            this.tiposDeSolicitud.TabIndex = 71;
            this.tiposDeSolicitud.Text = "TIPO DE SOLICITUD";
            // 
            // Form_UserRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 929);
            this.Controls.Add(this.tiposDeSolicitud);
            this.Controls.Add(this.bt_addRequest);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.datoErroneoDescripSoli);
            this.Controls.Add(this.descripcionSolicitudText);
            this.Controls.Add(this.descrpSolicitud);
            this.Controls.Add(this.datoErroneoAsuntoSolicitud);
            this.Controls.Add(this.solicitudText);
            this.Controls.Add(this.asuntoSolicitud);
            this.Controls.Add(this.reqUser);
            this.Controls.Add(this.datoErrorTipoSolicitud);
            this.Controls.Add(this.datoErroneoIdDirectivo);
            this.Controls.Add(this.idUsuarioTo);
            this.Controls.Add(this.datoErroneoIdPeticion);
            this.Controls.Add(this.idPeticion);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(969, 976);
            this.MinimumSize = new System.Drawing.Size(969, 976);
            this.Name = "Form_UserRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de usuario";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label datoErroneoIdPeticion;
        private System.Windows.Forms.TextBox idPeticion;
        private System.Windows.Forms.Label datoErroneoIdDirectivo;
        private System.Windows.Forms.TextBox idUsuarioTo;
        private System.Windows.Forms.Label datoErrorTipoSolicitud;
        private System.Windows.Forms.Label reqUser;
        private System.Windows.Forms.Label asuntoSolicitud;
        private System.Windows.Forms.TextBox solicitudText;
        private System.Windows.Forms.Label datoErroneoAsuntoSolicitud;
        private System.Windows.Forms.Label descrpSolicitud;
        private System.Windows.Forms.TextBox descripcionSolicitudText;
        private System.Windows.Forms.Label datoErroneoDescripSoli;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Button bt_addRequest;
        private System.Windows.Forms.TextBox tiposDeSolicitud;
    }
}