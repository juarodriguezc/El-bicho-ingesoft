namespace chatbottest1
{
    partial class Chatbot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chatbot));
            this.panel_chat = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_iniciando = new System.Windows.Forms.Label();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_sendMessage = new System.Windows.Forms.Button();
            this.panel_chat_bar = new System.Windows.Forms.Panel();
            this.lbl_conectando = new System.Windows.Forms.Label();
            this.panel_chat.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_chat_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_chat
            // 
            this.panel_chat.Controls.Add(this.lbl_conectando);
            this.panel_chat.Controls.Add(this.label2);
            this.panel_chat.Controls.Add(this.label1);
            this.panel_chat.Controls.Add(this.lbl_iniciando);
            this.panel_chat.Controls.Add(this.lbl_hour);
            this.panel_chat.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_chat.Location = new System.Drawing.Point(28, 98);
            this.panel_chat.Name = "panel_chat";
            this.panel_chat.Size = new System.Drawing.Size(920, 471);
            this.panel_chat.TabIndex = 0;
            this.panel_chat.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Panel_chat_ControlAdded);
            this.panel_chat.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_chat_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 184);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(129, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Todo listo ;)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 258);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(423, 130);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para usar el chatbot escribe en la barra de\r\n comandos lo que desees realizar.\r\n\r" +
    "\nPara más información haz clic en el botón \r\nde ayuda o escribe ayuda en el chat" +
    "bot.";
            // 
            // lbl_iniciando
            // 
            this.lbl_iniciando.AutoSize = true;
            this.lbl_iniciando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lbl_iniciando.ForeColor = System.Drawing.Color.Black;
            this.lbl_iniciando.Location = new System.Drawing.Point(48, 31);
            this.lbl_iniciando.Name = "lbl_iniciando";
            this.lbl_iniciando.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_iniciando.Size = new System.Drawing.Size(347, 42);
            this.lbl_iniciando.TabIndex = 1;
            this.lbl_iniciando.Text = "Iniciando el Chatbot Empresarial ...";
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hour.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_hour.Location = new System.Drawing.Point(408, 418);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(75, 20);
            this.lbl_hour.TabIndex = 0;
            this.lbl_hour.Text = "00:00 AM";
            this.lbl_hour.Click += new System.EventHandler(this.lbl_hour_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(27, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(750, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label7.Location = new System.Drawing.Point(883, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "label1";
            this.label7.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 92);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bt_sendMessage
            // 
            this.bt_sendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bt_sendMessage.FlatAppearance.BorderSize = 0;
            this.bt_sendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sendMessage.Location = new System.Drawing.Point(805, 3);
            this.bt_sendMessage.Margin = new System.Windows.Forms.Padding(0);
            this.bt_sendMessage.Name = "bt_sendMessage";
            this.bt_sendMessage.Size = new System.Drawing.Size(61, 40);
            this.bt_sendMessage.TabIndex = 2;
            this.bt_sendMessage.UseVisualStyleBackColor = false;
            this.bt_sendMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_chat_bar
            // 
            this.panel_chat_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel_chat_bar.Controls.Add(this.bt_sendMessage);
            this.panel_chat_bar.Controls.Add(this.textBox1);
            this.panel_chat_bar.Location = new System.Drawing.Point(80, 608);
            this.panel_chat_bar.Name = "panel_chat_bar";
            this.panel_chat_bar.Size = new System.Drawing.Size(868, 46);
            this.panel_chat_bar.TabIndex = 5;
            // 
            // lbl_conectando
            // 
            this.lbl_conectando.AutoSize = true;
            this.lbl_conectando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lbl_conectando.ForeColor = System.Drawing.Color.Black;
            this.lbl_conectando.Location = new System.Drawing.Point(48, 107);
            this.lbl_conectando.Name = "lbl_conectando";
            this.lbl_conectando.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_conectando.Size = new System.Drawing.Size(356, 42);
            this.lbl_conectando.TabIndex = 4;
            this.lbl_conectando.Text = "Conectando con Microsoft Azure ...";
            // 
            // Chatbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_chat_bar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel_chat);
            this.Name = "Chatbot";
            this.Size = new System.Drawing.Size(971, 674);
            this.Load += new System.EventHandler(this.Chatbot_Load);
            this.panel_chat.ResumeLayout(false);
            this.panel_chat.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_chat_bar.ResumeLayout(false);
            this.panel_chat_bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_chat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_sendMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_hour;
        private System.Windows.Forms.Label lbl_iniciando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_chat_bar;
        private System.Windows.Forms.Label lbl_conectando;
    }
}
