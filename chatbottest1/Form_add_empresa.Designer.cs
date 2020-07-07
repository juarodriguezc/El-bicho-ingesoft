namespace chatbottest1
{
    partial class Form_add_empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add_empresa));
            this.backHome = new System.Windows.Forms.Button();
            this.bt_adduser = new System.Windows.Forms.Button();
            this.lbl_addUser = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.error_nombre = new System.Windows.Forms.Label();
            this.error_direccion = new System.Windows.Forms.Label();
            this.error_nit = new System.Windows.Forms.Label();
            this.error_telefono = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.backHome.Location = new System.Drawing.Point(65, 442);
            this.backHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(101, 33);
            this.backHome.TabIndex = 35;
            this.backHome.Text = "VOLVER";
            this.backHome.UseVisualStyleBackColor = false;
            this.backHome.Click += new System.EventHandler(this.backHome_Click);
            // 
            // bt_adduser
            // 
            this.bt_adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_adduser.FlatAppearance.BorderSize = 0;
            this.bt_adduser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_adduser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_adduser.ForeColor = System.Drawing.Color.White;
            this.bt_adduser.Location = new System.Drawing.Point(222, 442);
            this.bt_adduser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_adduser.Name = "bt_adduser";
            this.bt_adduser.Size = new System.Drawing.Size(232, 33);
            this.bt_adduser.TabIndex = 36;
            this.bt_adduser.Text = "AÑADIR";
            this.bt_adduser.UseVisualStyleBackColor = false;
            this.bt_adduser.Click += new System.EventHandler(this.bt_adduser_Click);
            // 
            // lbl_addUser
            // 
            this.lbl_addUser.AutoSize = true;
            this.lbl_addUser.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addUser.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_addUser.Location = new System.Drawing.Point(55, 31);
            this.lbl_addUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addUser.Name = "lbl_addUser";
            this.lbl_addUser.Size = new System.Drawing.Size(383, 49);
            this.lbl_addUser.TabIndex = 37;
            this.lbl_addUser.Text = "AÑADIR EMPRESA";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nombre.Location = new System.Drawing.Point(64, 149);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.MaxLength = 20;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(362, 20);
            this.txt_nombre.TabIndex = 43;
            this.txt_nombre.Text = "NOMBRE EMPRESA";
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_Enter);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 65;
            this.lineShape7.X2 = 425;
            this.lineShape7.Y1 = 180;
            this.lineShape7.Y2 = 180;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1,
            this.lineShape7});
            this.shapeContainer1.Size = new System.Drawing.Size(494, 501);
            this.shapeContainer1.TabIndex = 44;
            this.shapeContainer1.TabStop = false;
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.White;
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.DimGray;
            this.txt_direccion.Location = new System.Drawing.Point(65, 209);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_direccion.MaxLength = 20;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(362, 20);
            this.txt_direccion.TabIndex = 45;
            this.txt_direccion.Text = "DIRECCIÓN";
            this.txt_direccion.Enter += new System.EventHandler(this.txt_direccion_Enter);
            this.txt_direccion.Leave += new System.EventHandler(this.txt_direccion_Leave);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 63;
            this.lineShape1.X2 = 423;
            this.lineShape1.Y1 = 240;
            this.lineShape1.Y2 = 238;
            // 
            // txt_nit
            // 
            this.txt_nit.BackColor = System.Drawing.Color.White;
            this.txt_nit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nit.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nit.Location = new System.Drawing.Point(65, 272);
            this.txt_nit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nit.MaxLength = 20;
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(362, 20);
            this.txt_nit.TabIndex = 46;
            this.txt_nit.Text = "NIT";
            this.txt_nit.Enter += new System.EventHandler(this.txt_nit_Enter);
            this.txt_nit.Leave += new System.EventHandler(this.txt_nit_Leave);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 64;
            this.lineShape2.X2 = 424;
            this.lineShape2.Y1 = 300;
            this.lineShape2.Y2 = 300;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.White;
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.DimGray;
            this.txt_telefono.Location = new System.Drawing.Point(61, 329);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telefono.MaxLength = 20;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(362, 20);
            this.txt_telefono.TabIndex = 47;
            this.txt_telefono.Text = "TELÉFONO DE CONTACTO";
            this.txt_telefono.Enter += new System.EventHandler(this.txt_telefono_Enter);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 61;
            this.lineShape3.X2 = 421;
            this.lineShape3.Y1 = 360;
            this.lineShape3.Y2 = 360;
            // 
            // error_nombre
            // 
            this.error_nombre.AutoSize = true;
            this.error_nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.error_nombre.Location = new System.Drawing.Point(61, 185);
            this.error_nombre.Name = "error_nombre";
            this.error_nombre.Size = new System.Drawing.Size(88, 17);
            this.error_nombre.TabIndex = 62;
            this.error_nombre.Text = "Dato erróneo";
            this.error_nombre.Visible = false;
            // 
            // error_direccion
            // 
            this.error_direccion.AutoSize = true;
            this.error_direccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.error_direccion.Location = new System.Drawing.Point(62, 245);
            this.error_direccion.Name = "error_direccion";
            this.error_direccion.Size = new System.Drawing.Size(88, 17);
            this.error_direccion.TabIndex = 63;
            this.error_direccion.Text = "Dato erróneo";
            this.error_direccion.Visible = false;
            // 
            // error_nit
            // 
            this.error_nit.AutoSize = true;
            this.error_nit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_nit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.error_nit.Location = new System.Drawing.Point(62, 305);
            this.error_nit.Name = "error_nit";
            this.error_nit.Size = new System.Drawing.Size(88, 17);
            this.error_nit.TabIndex = 64;
            this.error_nit.Text = "Dato erróneo";
            this.error_nit.Visible = false;
            // 
            // error_telefono
            // 
            this.error_telefono.AutoSize = true;
            this.error_telefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.error_telefono.Location = new System.Drawing.Point(61, 365);
            this.error_telefono.Name = "error_telefono";
            this.error_telefono.Size = new System.Drawing.Size(88, 17);
            this.error_telefono.TabIndex = 65;
            this.error_telefono.Text = "Dato erróneo";
            this.error_telefono.Visible = false;
            // 
            // Form_add_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 501);
            this.Controls.Add(this.error_telefono);
            this.Controls.Add(this.error_nit);
            this.Controls.Add(this.error_direccion);
            this.Controls.Add(this.error_nombre);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_addUser);
            this.Controls.Add(this.bt_adduser);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_add_empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Button bt_adduser;
        private System.Windows.Forms.Label lbl_addUser;
        private System.Windows.Forms.TextBox txt_nombre;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txt_direccion;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label error_nombre;
        private System.Windows.Forms.Label error_direccion;
        private System.Windows.Forms.Label error_nit;
        private System.Windows.Forms.Label error_telefono;
    }
}