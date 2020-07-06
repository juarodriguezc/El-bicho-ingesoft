namespace chatbottest1
{
    partial class Form_modificar_evento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_modificar_evento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_campo_obligatorio = new System.Windows.Forms.Label();
            this.flowPanel_users = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_save_event = new System.Windows.Forms.Button();
            this.bt_adduser = new System.Windows.Forms.Button();
            this.participantes = new System.Windows.Forms.ComboBox();
            this.lbl_participantes = new System.Windows.Forms.Label();
            this.pick_fecha_evento = new System.Windows.Forms.DateTimePicker();
            this.txt_asunto = new System.Windows.Forms.TextBox();
            this.lbl_asunto = new System.Windows.Forms.Label();
            this.fecha_evento = new System.Windows.Forms.Label();
            this.bt_volver_chatbot = new System.Windows.Forms.Button();
            this.lbl_add_user_obligatorio = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 75);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(121)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(704, 417);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_title.Location = new System.Drawing.Point(793, 95);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(306, 36);
            this.lbl_title.TabIndex = 55;
            this.lbl_title.Text = "MODIFICAR EVENTOS";
            // 
            // lbl_campo_obligatorio
            // 
            this.lbl_campo_obligatorio.AutoSize = true;
            this.lbl_campo_obligatorio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campo_obligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_campo_obligatorio.Location = new System.Drawing.Point(736, 285);
            this.lbl_campo_obligatorio.Name = "lbl_campo_obligatorio";
            this.lbl_campo_obligatorio.Size = new System.Drawing.Size(121, 17);
            this.lbl_campo_obligatorio.TabIndex = 65;
            this.lbl_campo_obligatorio.Text = "Campo obligatorio";
            this.lbl_campo_obligatorio.Visible = false;
            // 
            // flowPanel_users
            // 
            this.flowPanel_users.AutoScroll = true;
            this.flowPanel_users.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowPanel_users.ForeColor = System.Drawing.Color.White;
            this.flowPanel_users.Location = new System.Drawing.Point(739, 360);
            this.flowPanel_users.Margin = new System.Windows.Forms.Padding(2);
            this.flowPanel_users.Name = "flowPanel_users";
            this.flowPanel_users.Size = new System.Drawing.Size(355, 153);
            this.flowPanel_users.TabIndex = 64;
            // 
            // bt_save_event
            // 
            this.bt_save_event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_save_event.Enabled = false;
            this.bt_save_event.FlatAppearance.BorderSize = 0;
            this.bt_save_event.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_save_event.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_save_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_save_event.ForeColor = System.Drawing.Color.LightGray;
            this.bt_save_event.Location = new System.Drawing.Point(862, 540);
            this.bt_save_event.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_save_event.Name = "bt_save_event";
            this.bt_save_event.Size = new System.Drawing.Size(232, 33);
            this.bt_save_event.TabIndex = 63;
            this.bt_save_event.Text = "GUARDAR";
            this.bt_save_event.UseVisualStyleBackColor = false;
            this.bt_save_event.Click += new System.EventHandler(this.bt_save_event_Click);
            // 
            // bt_adduser
            // 
            this.bt_adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_adduser.Enabled = false;
            this.bt_adduser.FlatAppearance.BorderSize = 0;
            this.bt_adduser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_adduser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_adduser.ForeColor = System.Drawing.Color.White;
            this.bt_adduser.Image = ((System.Drawing.Image)(resources.GetObject("bt_adduser.Image")));
            this.bt_adduser.Location = new System.Drawing.Point(1065, 326);
            this.bt_adduser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_adduser.Name = "bt_adduser";
            this.bt_adduser.Size = new System.Drawing.Size(29, 29);
            this.bt_adduser.TabIndex = 62;
            this.bt_adduser.UseVisualStyleBackColor = false;
            this.bt_adduser.Click += new System.EventHandler(this.bt_adduser_Click);
            // 
            // participantes
            // 
            this.participantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.participantes.Enabled = false;
            this.participantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantes.FormattingEnabled = true;
            this.participantes.Location = new System.Drawing.Point(739, 326);
            this.participantes.Name = "participantes";
            this.participantes.Size = new System.Drawing.Size(306, 29);
            this.participantes.TabIndex = 61;
            // 
            // lbl_participantes
            // 
            this.lbl_participantes.AutoSize = true;
            this.lbl_participantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_participantes.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_participantes.Location = new System.Drawing.Point(735, 302);
            this.lbl_participantes.Name = "lbl_participantes";
            this.lbl_participantes.Size = new System.Drawing.Size(231, 21);
            this.lbl_participantes.TabIndex = 60;
            this.lbl_participantes.Text = "MODIFICAR PARTICIPANTES";
            // 
            // pick_fecha_evento
            // 
            this.pick_fecha_evento.CustomFormat = "dd-MM-yyyy";
            this.pick_fecha_evento.Enabled = false;
            this.pick_fecha_evento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_fecha_evento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_fecha_evento.Location = new System.Drawing.Point(907, 156);
            this.pick_fecha_evento.MinDate = new System.DateTime(2020, 6, 25, 0, 0, 0, 0);
            this.pick_fecha_evento.Name = "pick_fecha_evento";
            this.pick_fecha_evento.Size = new System.Drawing.Size(187, 27);
            this.pick_fecha_evento.TabIndex = 59;
            this.pick_fecha_evento.Value = new System.DateTime(2020, 6, 25, 0, 0, 0, 0);
            this.pick_fecha_evento.ValueChanged += new System.EventHandler(this.pick_fecha_evento_ValueChanged);
            // 
            // txt_asunto
            // 
            this.txt_asunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txt_asunto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_asunto.Enabled = false;
            this.txt_asunto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_asunto.ForeColor = System.Drawing.Color.DimGray;
            this.txt_asunto.Location = new System.Drawing.Point(739, 214);
            this.txt_asunto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_asunto.Multiline = true;
            this.txt_asunto.Name = "txt_asunto";
            this.txt_asunto.Size = new System.Drawing.Size(355, 69);
            this.txt_asunto.TabIndex = 58;
            // 
            // lbl_asunto
            // 
            this.lbl_asunto.AutoSize = true;
            this.lbl_asunto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asunto.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_asunto.Location = new System.Drawing.Point(735, 191);
            this.lbl_asunto.Name = "lbl_asunto";
            this.lbl_asunto.Size = new System.Drawing.Size(175, 21);
            this.lbl_asunto.TabIndex = 57;
            this.lbl_asunto.Text = "ASUNTO DEL EVENTO";
            // 
            // fecha_evento
            // 
            this.fecha_evento.AutoSize = true;
            this.fecha_evento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_evento.ForeColor = System.Drawing.Color.DimGray;
            this.fecha_evento.Location = new System.Drawing.Point(735, 161);
            this.fecha_evento.Name = "fecha_evento";
            this.fecha_evento.Size = new System.Drawing.Size(156, 21);
            this.fecha_evento.TabIndex = 56;
            this.fecha_evento.Text = "FECHA DE EVENTO";
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
            this.bt_volver_chatbot.Location = new System.Drawing.Point(27, 103);
            this.bt_volver_chatbot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_volver_chatbot.Name = "bt_volver_chatbot";
            this.bt_volver_chatbot.Size = new System.Drawing.Size(79, 33);
            this.bt_volver_chatbot.TabIndex = 66;
            this.bt_volver_chatbot.Text = "VOLVER";
            this.bt_volver_chatbot.UseVisualStyleBackColor = false;
            this.bt_volver_chatbot.Click += new System.EventHandler(this.bt_volver_chatbot_Click);
            // 
            // lbl_add_user_obligatorio
            // 
            this.lbl_add_user_obligatorio.AutoSize = true;
            this.lbl_add_user_obligatorio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_user_obligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_add_user_obligatorio.Location = new System.Drawing.Point(979, 306);
            this.lbl_add_user_obligatorio.Name = "lbl_add_user_obligatorio";
            this.lbl_add_user_obligatorio.Size = new System.Drawing.Size(121, 17);
            this.lbl_add_user_obligatorio.TabIndex = 67;
            this.lbl_add_user_obligatorio.Text = "Campo obligatorio";
            this.lbl_add_user_obligatorio.Visible = false;
            // 
            // Form_modificar_evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 603);
            this.Controls.Add(this.lbl_add_user_obligatorio);
            this.Controls.Add(this.bt_volver_chatbot);
            this.Controls.Add(this.lbl_campo_obligatorio);
            this.Controls.Add(this.flowPanel_users);
            this.Controls.Add(this.bt_save_event);
            this.Controls.Add(this.bt_adduser);
            this.Controls.Add(this.participantes);
            this.Controls.Add(this.lbl_participantes);
            this.Controls.Add(this.pick_fecha_evento);
            this.Controls.Add(this.txt_asunto);
            this.Controls.Add(this.lbl_asunto);
            this.Controls.Add(this.fecha_evento);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_modificar_evento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar eventos empresariales";
            this.Load += new System.EventHandler(this.Form_modificar_evento_Load);
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
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_campo_obligatorio;
        private System.Windows.Forms.FlowLayoutPanel flowPanel_users;
        private System.Windows.Forms.Button bt_save_event;
        private System.Windows.Forms.Button bt_adduser;
        private System.Windows.Forms.ComboBox participantes;
        private System.Windows.Forms.Label lbl_participantes;
        private System.Windows.Forms.DateTimePicker pick_fecha_evento;
        private System.Windows.Forms.TextBox txt_asunto;
        private System.Windows.Forms.Label lbl_asunto;
        private System.Windows.Forms.Label fecha_evento;
        private System.Windows.Forms.Button bt_volver_chatbot;
        private System.Windows.Forms.Label lbl_add_user_obligatorio;
    }
}