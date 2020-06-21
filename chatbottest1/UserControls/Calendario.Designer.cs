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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_contenido = new System.Windows.Forms.Panel();
            this.BtnInfoProgramDate = new System.Windows.Forms.Button();
            this.bt_todos_eventos = new System.Windows.Forms.Button();
            this.bt_add_event = new System.Windows.Forms.Button();
            this.panel_next_event = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_asunto_proximo = new System.Windows.Forms.Label();
            this.lbl_hora_proxima = new System.Windows.Forms.Label();
            this.lbl_fecha_proximo = new System.Windows.Forms.Label();
            this.lbl_no_prox = new System.Windows.Forms.Label();
            this.lbl_proximo_evento = new System.Windows.Forms.Label();
            this.bt_modificar_eventos = new System.Windows.Forms.Button();
            this.lbl_calendario = new System.Windows.Forms.Label();
            this.panel_calendario = new System.Windows.Forms.Panel();
            this.panel_eventos_dia = new System.Windows.Forms.Panel();
            this.lbl_no_eventos = new System.Windows.Forms.Label();
            this.lbl_current_day = new System.Windows.Forms.Label();
            this.lbl_fecha_actual = new System.Windows.Forms.Label();
            this.lblampm = new System.Windows.Forms.Label();
            this.lbl_hora_actual = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.bt_volver_chatbot = new System.Windows.Forms.Button();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.calendar_events = new CalendarioPersonalizado();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_contenido.SuspendLayout();
            this.panel_next_event.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_calendario.SuspendLayout();
            this.panel_eventos_dia.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 92);
            this.panel1.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel_contenido
            // 
            this.panel_contenido.Controls.Add(this.BtnInfoProgramDate);
            this.panel_contenido.Controls.Add(this.bt_todos_eventos);
            this.panel_contenido.Controls.Add(this.bt_add_event);
            this.panel_contenido.Controls.Add(this.panel_next_event);
            this.panel_contenido.Controls.Add(this.bt_modificar_eventos);
            this.panel_contenido.Controls.Add(this.lbl_calendario);
            this.panel_contenido.Controls.Add(this.panel_calendario);
            this.panel_contenido.Controls.Add(this.bt_volver_chatbot);
            this.panel_contenido.Location = new System.Drawing.Point(0, 98);
            this.panel_contenido.Margin = new System.Windows.Forms.Padding(4);
            this.panel_contenido.Name = "panel_contenido";
            this.panel_contenido.Size = new System.Drawing.Size(1311, 727);
            this.panel_contenido.TabIndex = 48;
            // 
            // BtnInfoProgramDate
            // 
            this.BtnInfoProgramDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInfoProgramDate.FlatAppearance.BorderSize = 0;
            this.BtnInfoProgramDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnInfoProgramDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInfoProgramDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfoProgramDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfoProgramDate.ForeColor = System.Drawing.Color.White;
            this.BtnInfoProgramDate.Location = new System.Drawing.Point(821, 650);
            this.BtnInfoProgramDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnInfoProgramDate.Name = "BtnInfoProgramDate";
            this.BtnInfoProgramDate.Size = new System.Drawing.Size(412, 41);
            this.BtnInfoProgramDate.TabIndex = 66;
            this.BtnInfoProgramDate.Text = "CONSULTAR PROGRAMA POR FECHA";
            this.BtnInfoProgramDate.UseVisualStyleBackColor = false;
            this.BtnInfoProgramDate.Click += new System.EventHandler(this.BtnInfoProgramDate_Click);
            // 
            // bt_todos_eventos
            // 
            this.bt_todos_eventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_todos_eventos.FlatAppearance.BorderSize = 0;
            this.bt_todos_eventos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_todos_eventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_todos_eventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_todos_eventos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_todos_eventos.ForeColor = System.Drawing.Color.White;
            this.bt_todos_eventos.Location = new System.Drawing.Point(852, 586);
            this.bt_todos_eventos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_todos_eventos.Name = "bt_todos_eventos";
            this.bt_todos_eventos.Size = new System.Drawing.Size(344, 41);
            this.bt_todos_eventos.TabIndex = 65;
            this.bt_todos_eventos.Text = "VER EVENTOS PROGRAMADOS";
            this.bt_todos_eventos.UseVisualStyleBackColor = false;
            // 
            // bt_add_event
            // 
            this.bt_add_event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_add_event.FlatAppearance.BorderSize = 0;
            this.bt_add_event.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_add_event.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_add_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add_event.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_event.ForeColor = System.Drawing.Color.White;
            this.bt_add_event.Location = new System.Drawing.Point(849, 432);
            this.bt_add_event.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_add_event.Name = "bt_add_event";
            this.bt_add_event.Size = new System.Drawing.Size(344, 41);
            this.bt_add_event.TabIndex = 64;
            this.bt_add_event.Text = "AÑADIR EVENTO";
            this.bt_add_event.UseVisualStyleBackColor = false;
            // 
            // panel_next_event
            // 
            this.panel_next_event.Controls.Add(this.panel3);
            this.panel_next_event.Controls.Add(this.lbl_proximo_evento);
            this.panel_next_event.Location = new System.Drawing.Point(845, 71);
            this.panel_next_event.Margin = new System.Windows.Forms.Padding(4);
            this.panel_next_event.Name = "panel_next_event";
            this.panel_next_event.Size = new System.Drawing.Size(357, 340);
            this.panel_next_event.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel3.Controls.Add(this.lbl_asunto_proximo);
            this.panel3.Controls.Add(this.lbl_hora_proxima);
            this.panel3.Controls.Add(this.lbl_fecha_proximo);
            this.panel3.Controls.Add(this.lbl_no_prox);
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 229);
            this.panel3.TabIndex = 65;
            // 
            // lbl_asunto_proximo
            // 
            this.lbl_asunto_proximo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asunto_proximo.ForeColor = System.Drawing.Color.White;
            this.lbl_asunto_proximo.Location = new System.Drawing.Point(8, 94);
            this.lbl_asunto_proximo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_asunto_proximo.Name = "lbl_asunto_proximo";
            this.lbl_asunto_proximo.Size = new System.Drawing.Size(336, 118);
            this.lbl_asunto_proximo.TabIndex = 2;
            this.lbl_asunto_proximo.Text = "Evento reunión de prueba ";
            // 
            // lbl_hora_proxima
            // 
            this.lbl_hora_proxima.AutoSize = true;
            this.lbl_hora_proxima.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora_proxima.ForeColor = System.Drawing.Color.White;
            this.lbl_hora_proxima.Location = new System.Drawing.Point(4, 50);
            this.lbl_hora_proxima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hora_proxima.Name = "lbl_hora_proxima";
            this.lbl_hora_proxima.Size = new System.Drawing.Size(137, 21);
            this.lbl_hora_proxima.TabIndex = 1;
            this.lbl_hora_proxima.Text = "a las 12:00 a.m.";
            // 
            // lbl_fecha_proximo
            // 
            this.lbl_fecha_proximo.AutoSize = true;
            this.lbl_fecha_proximo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_proximo.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha_proximo.Location = new System.Drawing.Point(4, 30);
            this.lbl_fecha_proximo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha_proximo.Name = "lbl_fecha_proximo";
            this.lbl_fecha_proximo.Size = new System.Drawing.Size(300, 21);
            this.lbl_fecha_proximo.TabIndex = 0;
            this.lbl_fecha_proximo.Text = "miércoles, 17 de diciembre de 2020";
            // 
            // lbl_no_prox
            // 
            this.lbl_no_prox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_prox.ForeColor = System.Drawing.Color.White;
            this.lbl_no_prox.Location = new System.Drawing.Point(8, 25);
            this.lbl_no_prox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_no_prox.Name = "lbl_no_prox";
            this.lbl_no_prox.Size = new System.Drawing.Size(336, 187);
            this.lbl_no_prox.TabIndex = 3;
            this.lbl_no_prox.Text = "No tienes eventos próximos progamados";
            this.lbl_no_prox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_proximo_evento
            // 
            this.lbl_proximo_evento.AutoSize = true;
            this.lbl_proximo_evento.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proximo_evento.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_proximo_evento.Location = new System.Drawing.Point(17, 23);
            this.lbl_proximo_evento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_proximo_evento.Name = "lbl_proximo_evento";
            this.lbl_proximo_evento.Size = new System.Drawing.Size(271, 40);
            this.lbl_proximo_evento.TabIndex = 64;
            this.lbl_proximo_evento.Text = "Próximo evento";
            // 
            // bt_modificar_eventos
            // 
            this.bt_modificar_eventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_modificar_eventos.FlatAppearance.BorderSize = 0;
            this.bt_modificar_eventos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_modificar_eventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_modificar_eventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_modificar_eventos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar_eventos.ForeColor = System.Drawing.Color.White;
            this.bt_modificar_eventos.Location = new System.Drawing.Point(851, 500);
            this.bt_modificar_eventos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_modificar_eventos.Name = "bt_modificar_eventos";
            this.bt_modificar_eventos.Size = new System.Drawing.Size(344, 41);
            this.bt_modificar_eventos.TabIndex = 62;
            this.bt_modificar_eventos.Text = "MODIFICAR EVENTOS";
            this.bt_modificar_eventos.UseVisualStyleBackColor = false;
            this.bt_modificar_eventos.Click += new System.EventHandler(this.bt_add_event_Click);
            // 
            // lbl_calendario
            // 
            this.lbl_calendario.AutoSize = true;
            this.lbl_calendario.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calendario.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_calendario.Location = new System.Drawing.Point(497, 8);
            this.lbl_calendario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_calendario.Name = "lbl_calendario";
            this.lbl_calendario.Size = new System.Drawing.Size(308, 55);
            this.lbl_calendario.TabIndex = 48;
            this.lbl_calendario.Text = "CALENDARIO";
            this.lbl_calendario.Click += new System.EventHandler(this.lbl_calendario_Click);
            // 
            // panel_calendario
            // 
            this.panel_calendario.Controls.Add(this.panel_eventos_dia);
            this.panel_calendario.Controls.Add(this.lbl_current_day);
            this.panel_calendario.Controls.Add(this.lbl_fecha_actual);
            this.panel_calendario.Controls.Add(this.lblampm);
            this.panel_calendario.Controls.Add(this.lbl_hora_actual);
            this.panel_calendario.Controls.Add(this.calendar_events);
            this.panel_calendario.Controls.Add(this.shapeContainer1);
            this.panel_calendario.Location = new System.Drawing.Point(133, 72);
            this.panel_calendario.Margin = new System.Windows.Forms.Padding(4);
            this.panel_calendario.Name = "panel_calendario";
            this.panel_calendario.Size = new System.Drawing.Size(540, 645);
            this.panel_calendario.TabIndex = 47;
            // 
            // panel_eventos_dia
            // 
            this.panel_eventos_dia.AutoScroll = true;
            this.panel_eventos_dia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_eventos_dia.Controls.Add(this.lbl_no_eventos);
            this.panel_eventos_dia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_eventos_dia.ForeColor = System.Drawing.Color.White;
            this.panel_eventos_dia.Location = new System.Drawing.Point(27, 450);
            this.panel_eventos_dia.Margin = new System.Windows.Forms.Padding(4);
            this.panel_eventos_dia.Name = "panel_eventos_dia";
            this.panel_eventos_dia.Size = new System.Drawing.Size(476, 178);
            this.panel_eventos_dia.TabIndex = 7;
            this.panel_eventos_dia.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel_eventos_dia_ControlAdded);
            // 
            // lbl_no_eventos
            // 
            this.lbl_no_eventos.AutoSize = true;
            this.lbl_no_eventos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_eventos.Location = new System.Drawing.Point(71, 79);
            this.lbl_no_eventos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_no_eventos.Name = "lbl_no_eventos";
            this.lbl_no_eventos.Size = new System.Drawing.Size(304, 22);
            this.lbl_no_eventos.TabIndex = 0;
            this.lbl_no_eventos.Text = "No tienes eventos programados";
            // 
            // lbl_current_day
            // 
            this.lbl_current_day.AutoSize = true;
            this.lbl_current_day.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_day.Location = new System.Drawing.Point(27, 420);
            this.lbl_current_day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_current_day.Name = "lbl_current_day";
            this.lbl_current_day.Size = new System.Drawing.Size(58, 30);
            this.lbl_current_day.TabIndex = 6;
            this.lbl_current_day.Text = "Hoy";
            // 
            // lbl_fecha_actual
            // 
            this.lbl_fecha_actual.AutoSize = true;
            this.lbl_fecha_actual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_actual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_fecha_actual.Location = new System.Drawing.Point(27, 82);
            this.lbl_fecha_actual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha_actual.Name = "lbl_fecha_actual";
            this.lbl_fecha_actual.Size = new System.Drawing.Size(371, 30);
            this.lbl_fecha_actual.TabIndex = 3;
            this.lbl_fecha_actual.Text = "miércoles, 17 de junio de 2020";
            // 
            // lblampm
            // 
            this.lblampm.AutoSize = true;
            this.lblampm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblampm.Location = new System.Drawing.Point(285, 46);
            this.lblampm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblampm.Name = "lblampm";
            this.lblampm.Size = new System.Drawing.Size(73, 33);
            this.lblampm.TabIndex = 4;
            this.lblampm.Text = "p.m.";
            // 
            // lbl_hora_actual
            // 
            this.lbl_hora_actual.AutoSize = true;
            this.lbl_hora_actual.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora_actual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbl_hora_actual.Location = new System.Drawing.Point(13, 11);
            this.lbl_hora_actual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hora_actual.Name = "lbl_hora_actual";
            this.lbl_hora_actual.Size = new System.Drawing.Size(262, 74);
            this.lbl_hora_actual.TabIndex = 2;
            this.lbl_hora_actual.Text = "11:12:20";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(540, 645);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 21;
            this.lineShape1.X2 = 381;
            this.lineShape1.Y1 = 330;
            this.lineShape1.Y2 = 330;
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
            this.bt_volver_chatbot.Location = new System.Drawing.Point(84, 19);
            this.bt_volver_chatbot.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_volver_chatbot.Name = "bt_volver_chatbot";
            this.bt_volver_chatbot.Size = new System.Drawing.Size(105, 41);
            this.bt_volver_chatbot.TabIndex = 46;
            this.bt_volver_chatbot.Text = "VOLVER";
            this.bt_volver_chatbot.UseVisualStyleBackColor = false;
            this.bt_volver_chatbot.Click += new System.EventHandler(this.bt_volver_chatbot_Click);
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // calendar_events
            // 
            this.calendar_events.BackColor = System.Drawing.Color.White;
            this.calendar_events.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendar_events.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar_events.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.calendar_events.Location = new System.Drawing.Point(17, 98);
            this.calendar_events.Margin = new System.Windows.Forms.Padding(0);
            this.calendar_events.MaxSelectionCount = 1;
            this.calendar_events.Name = "calendar_events";
            this.calendar_events.RightToLeftLayout = true;
            this.calendar_events.ShowToday = false;
            this.calendar_events.ShowTodayCircle = false;
            this.calendar_events.TabIndex = 1;
            this.calendar_events.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.calendar_events.TitleForeColor = System.Drawing.Color.White;
            this.calendar_events.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.calendar_events.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarioPersonalizado1_DateSelected);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_contenido);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calendario";
            this.Size = new System.Drawing.Size(1311, 830);
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_contenido.ResumeLayout(false);
            this.panel_contenido.PerformLayout();
            this.panel_next_event.ResumeLayout(false);
            this.panel_next_event.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_calendario.ResumeLayout(false);
            this.panel_calendario.PerformLayout();
            this.panel_eventos_dia.ResumeLayout(false);
            this.panel_eventos_dia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_contenido;
        private System.Windows.Forms.Button bt_volver_chatbot;
        private System.Windows.Forms.Panel panel_calendario;
        private System.Windows.Forms.Label lbl_fecha_actual;
        private System.Windows.Forms.Label lbl_hora_actual;
        private System.Windows.Forms.Timer horafecha;
        public CalendarioPersonalizado calendar_events;
        private System.Windows.Forms.Label lblampm;
        private System.Windows.Forms.Label lbl_calendario;
        private System.Windows.Forms.Button bt_modificar_eventos;
        private System.Windows.Forms.Panel panel_eventos_dia;
        private System.Windows.Forms.Label lbl_no_eventos;
        private System.Windows.Forms.Label lbl_current_day;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button bt_add_event;
        private System.Windows.Forms.Panel panel_next_event;
        private System.Windows.Forms.Label lbl_proximo_evento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_todos_eventos;
        private System.Windows.Forms.Label lbl_asunto_proximo;
        private System.Windows.Forms.Label lbl_hora_proxima;
        private System.Windows.Forms.Label lbl_fecha_proximo;
        private System.Windows.Forms.Label lbl_no_prox;
        private System.Windows.Forms.Button BtnInfoProgramDate;
    }
}
