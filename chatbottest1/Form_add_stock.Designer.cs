namespace chatbottest1
{
    partial class Form_add_stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add_stock));
            this.lbl_addStock = new System.Windows.Forms.Label();
            this.lbl_errorNombreProducto = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.cmb_localizacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.Button();
            this.bt_adduser = new System.Windows.Forms.Button();
            this.lbl_errorCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_addStock
            // 
            this.lbl_addStock.AutoSize = true;
            this.lbl_addStock.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.lbl_addStock.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_addStock.Location = new System.Drawing.Point(49, 31);
            this.lbl_addStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addStock.Name = "lbl_addStock";
            this.lbl_addStock.Size = new System.Drawing.Size(379, 44);
            this.lbl_addStock.TabIndex = 9;
            this.lbl_addStock.Text = "AÑADIR PRODUCTO";
            // 
            // lbl_errorNombreProducto
            // 
            this.lbl_errorNombreProducto.AutoSize = true;
            this.lbl_errorNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_errorNombreProducto.Location = new System.Drawing.Point(121, 135);
            this.lbl_errorNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_errorNombreProducto.Name = "lbl_errorNombreProducto";
            this.lbl_errorNombreProducto.Size = new System.Drawing.Size(195, 17);
            this.lbl_errorNombreProducto.TabIndex = 52;
            this.lbl_errorNombreProducto.Text = "Ingrese el nombre del producto";
            this.lbl_errorNombreProducto.Visible = false;
            // 
            // txt_producto
            // 
            this.txt_producto.BackColor = System.Drawing.Color.White;
            this.txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.ForeColor = System.Drawing.Color.DimGray;
            this.txt_producto.Location = new System.Drawing.Point(35, 100);
            this.txt_producto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(383, 20);
            this.txt_producto.TabIndex = 51;
            this.txt_producto.Text = "NOMBRE DEL PRODUCTO";
            this.txt_producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_producto.Enter += new System.EventHandler(this.txt_producto_Enter);
            this.txt_producto.Leave += new System.EventHandler(this.txt_producto_Leave);
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 30;
            this.lineShape4.X2 = 410;
            this.lineShape4.Y1 = 127;
            this.lineShape4.Y2 = 128;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape8,
            this.lineShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(466, 348);
            this.shapeContainer1.TabIndex = 53;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape8
            // 
            this.lineShape8.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 224;
            this.lineShape8.X2 = 424;
            this.lineShape8.Y1 = 194;
            this.lineShape8.Y2 = 194;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(31, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "CANTIDAD";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.White;
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.DimGray;
            this.txt_cantidad.Location = new System.Drawing.Point(224, 169);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(204, 20);
            this.txt_cantidad.TabIndex = 54;
            // 
            // cmb_localizacion
            // 
            this.cmb_localizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_localizacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_localizacion.FormattingEnabled = true;
            this.cmb_localizacion.Location = new System.Drawing.Point(224, 229);
            this.cmb_localizacion.Name = "cmb_localizacion";
            this.cmb_localizacion.Size = new System.Drawing.Size(204, 29);
            this.cmb_localizacion.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(31, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 66;
            this.label3.Text = "LOCALIZACION";
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
            this.backHome.Location = new System.Drawing.Point(21, 291);
            this.backHome.Margin = new System.Windows.Forms.Padding(2);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(169, 27);
            this.backHome.TabIndex = 69;
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
            this.bt_adduser.ForeColor = System.Drawing.Color.LightGray;
            this.bt_adduser.Location = new System.Drawing.Point(243, 291);
            this.bt_adduser.Margin = new System.Windows.Forms.Padding(2);
            this.bt_adduser.Name = "bt_adduser";
            this.bt_adduser.Size = new System.Drawing.Size(185, 27);
            this.bt_adduser.TabIndex = 68;
            this.bt_adduser.Text = "AÑADIR";
            this.bt_adduser.UseVisualStyleBackColor = false;
            this.bt_adduser.Click += new System.EventHandler(this.bt_adduser_Click);
            // 
            // lbl_errorCantidad
            // 
            this.lbl_errorCantidad.AutoSize = true;
            this.lbl_errorCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.lbl_errorCantidad.Location = new System.Drawing.Point(32, 194);
            this.lbl_errorCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_errorCantidad.Name = "lbl_errorCantidad";
            this.lbl_errorCantidad.Size = new System.Drawing.Size(123, 17);
            this.lbl_errorCantidad.TabIndex = 70;
            this.lbl_errorCantidad.Text = "Ingrese la cantidad";
            this.lbl_errorCantidad.Visible = false;
            // 
            // Form_add_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 348);
            this.Controls.Add(this.lbl_errorCantidad);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.bt_adduser);
            this.Controls.Add(this.cmb_localizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_errorNombreProducto);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.lbl_addStock);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_add_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir producto";
            this.Load += new System.EventHandler(this.Form_add_stock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_addStock;
        private System.Windows.Forms.Label lbl_errorNombreProducto;
        private System.Windows.Forms.TextBox txt_producto;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantidad;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private System.Windows.Forms.ComboBox cmb_localizacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Button bt_adduser;
        private System.Windows.Forms.Label lbl_errorCantidad;
    }
}