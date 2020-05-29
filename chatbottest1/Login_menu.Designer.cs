namespace chatbottest1
{
    partial class Login_menu
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
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.laabel_correo = new System.Windows.Forms.Label();
            this.label_contra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_correo.Location = new System.Drawing.Point(109, 97);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(199, 23);
            this.txt_correo.TabIndex = 0;
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_contrasenia.Location = new System.Drawing.Point(109, 169);
            this.txt_contrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.PasswordChar = '•';
            this.txt_contrasenia.Size = new System.Drawing.Size(199, 23);
            this.txt_contrasenia.TabIndex = 1;
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_ingresar.Location = new System.Drawing.Point(161, 209);
            this.bt_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(106, 27);
            this.bt_ingresar.TabIndex = 2;
            this.bt_ingresar.Text = "Ingresar";
            this.bt_ingresar.UseVisualStyleBackColor = true;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // laabel_correo
            // 
            this.laabel_correo.AutoSize = true;
            this.laabel_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.laabel_correo.Location = new System.Drawing.Point(185, 78);
            this.laabel_correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laabel_correo.Name = "laabel_correo";
            this.laabel_correo.Size = new System.Drawing.Size(51, 17);
            this.laabel_correo.TabIndex = 3;
            this.laabel_correo.Text = "Correo";
            this.laabel_correo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_contra
            // 
            this.label_contra.AutoSize = true;
            this.label_contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_contra.Location = new System.Drawing.Point(170, 150);
            this.label_contra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_contra.Name = "label_contra";
            this.label_contra.Size = new System.Drawing.Size(81, 17);
            this.label_contra.TabIndex = 4;
            this.label_contra.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(91, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chatbot YMCA";
            // 
            // Login_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(431, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_contra);
            this.Controls.Add(this.laabel_correo);
            this.Controls.Add(this.bt_ingresar);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.txt_correo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Login_menu";
            this.Text = "ChatBot";
            this.Load += new System.EventHandler(this.Login_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.Label laabel_correo;
        private System.Windows.Forms.Label label_contra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}