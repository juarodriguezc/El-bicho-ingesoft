namespace chatbottest1
{
    partial class Form_show_stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_show_stock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title_stock = new System.Windows.Forms.Label();
            this.bt_volver_chatbot_stock = new System.Windows.Forms.Button();
            this.dataGrid_stock = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 75);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_title_stock
            // 
            this.lbl_title_stock.AutoSize = true;
            this.lbl_title_stock.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_stock.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_title_stock.Location = new System.Drawing.Point(137, 136);
            this.lbl_title_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title_stock.Name = "lbl_title_stock";
            this.lbl_title_stock.Size = new System.Drawing.Size(434, 41);
            this.lbl_title_stock.TabIndex = 48;
            this.lbl_title_stock.Text = "PRODUCTOS EN BODEGA";
            this.lbl_title_stock.Click += new System.EventHandler(this.lbl_title_stock_Click);
            // 
            // bt_volver_chatbot_stock
            // 
            this.bt_volver_chatbot_stock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_volver_chatbot_stock.FlatAppearance.BorderSize = 0;
            this.bt_volver_chatbot_stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_volver_chatbot_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_volver_chatbot_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_volver_chatbot_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_volver_chatbot_stock.ForeColor = System.Drawing.Color.LightGray;
            this.bt_volver_chatbot_stock.Location = new System.Drawing.Point(30, 102);
            this.bt_volver_chatbot_stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_volver_chatbot_stock.Name = "bt_volver_chatbot_stock";
            this.bt_volver_chatbot_stock.Size = new System.Drawing.Size(79, 33);
            this.bt_volver_chatbot_stock.TabIndex = 49;
            this.bt_volver_chatbot_stock.Text = "VOLVER";
            this.bt_volver_chatbot_stock.UseVisualStyleBackColor = false;
            this.bt_volver_chatbot_stock.Click += new System.EventHandler(this.bt_volver_chatbot_stock_Click);
            // 
            // dataGrid_stock
            // 
            this.dataGrid_stock.AllowUserToAddRows = false;
            this.dataGrid_stock.AllowUserToDeleteRows = false;
            this.dataGrid_stock.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_stock.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_stock.ColumnHeadersHeight = 45;
            this.dataGrid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_stock.EnableHeadersVisualStyles = false;
            this.dataGrid_stock.Location = new System.Drawing.Point(30, 188);
            this.dataGrid_stock.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid_stock.MultiSelect = false;
            this.dataGrid_stock.Name = "dataGrid_stock";
            this.dataGrid_stock.ReadOnly = true;
            this.dataGrid_stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(121)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid_stock.RowHeadersVisible = false;
            this.dataGrid_stock.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid_stock.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid_stock.RowTemplate.Height = 24;
            this.dataGrid_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_stock.Size = new System.Drawing.Size(666, 408);
            this.dataGrid_stock.TabIndex = 50;
            this.dataGrid_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_stock_CellContentClick);
            // 
            // Form_show_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 611);
            this.Controls.Add(this.dataGrid_stock);
            this.Controls.Add(this.lbl_title_stock);
            this.Controls.Add(this.bt_volver_chatbot_stock);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_show_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos en bodega";
            this.Load += new System.EventHandler(this.Form_show_stock_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title_stock;
        private System.Windows.Forms.Button bt_volver_chatbot_stock;
        private System.Windows.Forms.DataGridView dataGrid_stock;
    }
}