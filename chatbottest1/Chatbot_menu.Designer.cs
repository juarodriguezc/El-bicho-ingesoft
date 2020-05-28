namespace chatbottest1
{
    partial class Chatbot_menu
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
            this.bt_send = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textsend = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(573, 399);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 23);
            this.bt_send.TabIndex = 0;
            this.bt_send.Text = "Send";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(636, 348);
            this.textBox.TabIndex = 1;
            // 
            // textsend
            // 
            this.textsend.Location = new System.Drawing.Point(12, 399);
            this.textsend.Multiline = true;
            this.textsend.Name = "textsend";
            this.textsend.Size = new System.Drawing.Size(541, 22);
            this.textsend.TabIndex = 2;
            this.textsend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textsend_KeyDown);
            // 
            // Chatbot_menu
            // 
            this.ClientSize = new System.Drawing.Size(683, 452);
            this.Controls.Add(this.textsend);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.bt_send);
            this.Name = "Chatbot_menu";
            this.Load += new System.EventHandler(this.Chatbot_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textsend;
    }
}

