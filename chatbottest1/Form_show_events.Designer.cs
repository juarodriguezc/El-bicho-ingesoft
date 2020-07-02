namespace chatbottest1
{
    partial class Form_show_events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_show_events));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.bt_volver_chatbot = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fecha_evento_inicio = new System.Windows.Forms.Label();
            this.fecha_evento_fin = new System.Windows.Forms.Label();
            this.lbl_eventos_dos_fechas = new System.Windows.Forms.Label();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.pick_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.pick__fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.bt_todos = new System.Windows.Forms.Button();
            this.bt_prox_events = new System.Windows.Forms.Button();
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
            this.panel2.TabIndex = 54;
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
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_title.Location = new System.Drawing.Point(791, 103);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(236, 41);
            this.lbl_title.TabIndex = 56;
            this.lbl_title.Text = "MIS EVENTOS";
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
            this.bt_volver_chatbot.TabIndex = 67;
            this.bt_volver_chatbot.Text = "VOLVER";
            this.bt_volver_chatbot.UseVisualStyleBackColor = false;
            this.bt_volver_chatbot.Click += new System.EventHandler(this.bt_volver_chatbot_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(27, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(121)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(704, 399);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fecha_evento_inicio
            // 
            this.fecha_evento_inicio.AutoSize = true;
            this.fecha_evento_inicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_evento_inicio.ForeColor = System.Drawing.Color.DimGray;
            this.fecha_evento_inicio.Location = new System.Drawing.Point(879, 341);
            this.fecha_evento_inicio.Name = "fecha_evento_inicio";
            this.fecha_evento_inicio.Size = new System.Drawing.Size(147, 21);
            this.fecha_evento_inicio.TabIndex = 69;
            this.fecha_evento_inicio.Text = "FECHA DE INICIO";
            // 
            // fecha_evento_fin
            // 
            this.fecha_evento_fin.AutoSize = true;
            this.fecha_evento_fin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_evento_fin.ForeColor = System.Drawing.Color.DimGray;
            this.fecha_evento_fin.Location = new System.Drawing.Point(819, 423);
            this.fecha_evento_fin.Name = "fecha_evento_fin";
            this.fecha_evento_fin.Size = new System.Drawing.Size(208, 21);
            this.fecha_evento_fin.TabIndex = 70;
            this.fecha_evento_fin.Text = "FECHA DE FINALIZACIÓN";
            // 
            // lbl_eventos_dos_fechas
            // 
            this.lbl_eventos_dos_fechas.AutoSize = true;
            this.lbl_eventos_dos_fechas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventos_dos_fechas.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_eventos_dos_fechas.Location = new System.Drawing.Point(762, 302);
            this.lbl_eventos_dos_fechas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_eventos_dos_fechas.Name = "lbl_eventos_dos_fechas";
            this.lbl_eventos_dos_fechas.Size = new System.Drawing.Size(264, 19);
            this.lbl_eventos_dos_fechas.TabIndex = 71;
            this.lbl_eventos_dos_fechas.Text = "Seleccione el intervalo de fechas";
            // 
            // bt_consultar
            // 
            this.bt_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_consultar.FlatAppearance.BorderSize = 0;
            this.bt_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_consultar.ForeColor = System.Drawing.Color.LightGray;
            this.bt_consultar.Location = new System.Drawing.Point(794, 526);
            this.bt_consultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_consultar.Name = "bt_consultar";
            this.bt_consultar.Size = new System.Drawing.Size(232, 33);
            this.bt_consultar.TabIndex = 72;
            this.bt_consultar.Text = "CONSULTAR";
            this.bt_consultar.UseVisualStyleBackColor = false;
            this.bt_consultar.Click += new System.EventHandler(this.bt_consultar_Click);
            // 
            // pick_fecha_inicio
            // 
            this.pick_fecha_inicio.CustomFormat = "dd-MM-yyyy";
            this.pick_fecha_inicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_fecha_inicio.Location = new System.Drawing.Point(839, 383);
            this.pick_fecha_inicio.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.pick_fecha_inicio.Name = "pick_fecha_inicio";
            this.pick_fecha_inicio.Size = new System.Drawing.Size(187, 27);
            this.pick_fecha_inicio.TabIndex = 73;
            this.pick_fecha_inicio.Value = new System.DateTime(2020, 6, 25, 0, 0, 0, 0);
            // 
            // pick__fecha_fin
            // 
            this.pick__fecha_fin.CustomFormat = "dd-MM-yyyy";
            this.pick__fecha_fin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick__fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick__fecha_fin.Location = new System.Drawing.Point(839, 456);
            this.pick__fecha_fin.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.pick__fecha_fin.Name = "pick__fecha_fin";
            this.pick__fecha_fin.Size = new System.Drawing.Size(187, 27);
            this.pick__fecha_fin.TabIndex = 74;
            this.pick__fecha_fin.Value = new System.DateTime(2020, 6, 25, 0, 0, 0, 0);
            // 
            // bt_todos
            // 
            this.bt_todos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_todos.FlatAppearance.BorderSize = 0;
            this.bt_todos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_todos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_todos.ForeColor = System.Drawing.Color.LightGray;
            this.bt_todos.Location = new System.Drawing.Point(794, 182);
            this.bt_todos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_todos.Name = "bt_todos";
            this.bt_todos.Size = new System.Drawing.Size(232, 33);
            this.bt_todos.TabIndex = 75;
            this.bt_todos.Text = "TODOS MIS EVENTOS";
            this.bt_todos.UseVisualStyleBackColor = false;
            this.bt_todos.Click += new System.EventHandler(this.bt_todos_Click);
            // 
            // bt_prox_events
            // 
            this.bt_prox_events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_prox_events.FlatAppearance.BorderSize = 0;
            this.bt_prox_events.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_prox_events.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_prox_events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prox_events.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_prox_events.ForeColor = System.Drawing.Color.LightGray;
            this.bt_prox_events.Location = new System.Drawing.Point(794, 242);
            this.bt_prox_events.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_prox_events.Name = "bt_prox_events";
            this.bt_prox_events.Size = new System.Drawing.Size(232, 33);
            this.bt_prox_events.TabIndex = 76;
            this.bt_prox_events.Text = "PRÓXIMOS EVENTOS";
            this.bt_prox_events.UseVisualStyleBackColor = false;
            this.bt_prox_events.Click += new System.EventHandler(this.bt_prox_events_Click);
            // 
            // Form_show_events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.bt_prox_events);
            this.Controls.Add(this.bt_todos);
            this.Controls.Add(this.pick__fecha_fin);
            this.Controls.Add(this.pick_fecha_inicio);
            this.Controls.Add(this.bt_consultar);
            this.Controls.Add(this.lbl_eventos_dos_fechas);
            this.Controls.Add(this.fecha_evento_fin);
            this.Controls.Add(this.fecha_evento_inicio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_volver_chatbot);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_show_events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_show_events";
            this.Load += new System.EventHandler(this.Form_show_events_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button bt_volver_chatbot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label fecha_evento_inicio;
        private System.Windows.Forms.Label fecha_evento_fin;
        private System.Windows.Forms.Label lbl_eventos_dos_fechas;
        private System.Windows.Forms.Button bt_consultar;
        private System.Windows.Forms.DateTimePicker pick_fecha_inicio;
        private System.Windows.Forms.DateTimePicker pick__fecha_fin;
        private System.Windows.Forms.Button bt_todos;
        private System.Windows.Forms.Button bt_prox_events;
    }
}