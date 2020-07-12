namespace chatbottest1
{
    partial class Form_InfoSpecificProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InfoSpecificProgram));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataOfProgram = new System.Windows.Forms.Label();
            this.datoErroneoComboBox = new System.Windows.Forms.Label();
            this.backHome = new System.Windows.Forms.Button();
            this.bt_Search = new System.Windows.Forms.Button();
            this.datoErroneoDataProg = new System.Windows.Forms.Label();
            this.dataProg = new System.Windows.Forms.TextBox();
            this.labelComboText = new System.Windows.Forms.Label();
            this.labelComboBox = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Id del programa",
            "Id de la compañia",
            "Nombre del programa",
            "Fecha del programa",
            "Tipo del programa"});
            this.comboBox1.Location = new System.Drawing.Point(230, 94);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 61);
            this.panel2.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataOfProgram
            // 
            this.dataOfProgram.AutoSize = true;
            this.dataOfProgram.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataOfProgram.ForeColor = System.Drawing.Color.DimGray;
            this.dataOfProgram.Location = new System.Drawing.Point(46, 95);
            this.dataOfProgram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataOfProgram.Name = "dataOfProgram";
            this.dataOfProgram.Size = new System.Drawing.Size(115, 21);
            this.dataOfProgram.TabIndex = 54;
            this.dataOfProgram.Text = "BUSCAR POR ";
            // 
            // datoErroneoComboBox
            // 
            this.datoErroneoComboBox.AutoSize = true;
            this.datoErroneoComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoErroneoComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.datoErroneoComboBox.Location = new System.Drawing.Point(226, 116);
            this.datoErroneoComboBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datoErroneoComboBox.Name = "datoErroneoComboBox";
            this.datoErroneoComboBox.Size = new System.Drawing.Size(88, 17);
            this.datoErroneoComboBox.TabIndex = 55;
            this.datoErroneoComboBox.Text = "Dato erróneo";
            this.datoErroneoComboBox.Visible = false;
            // 
            // backHome
            // 
            this.backHome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backHome.FlatAppearance.BorderSize = 0;
            this.backHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.backHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.backHome.ForeColor = System.Drawing.Color.White;
            this.backHome.Location = new System.Drawing.Point(230, 546);
            this.backHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(84, 29);
            this.backHome.TabIndex = 57;
            this.backHome.Text = "VOLVER";
            this.backHome.UseVisualStyleBackColor = false;
            this.backHome.Click += new System.EventHandler(this.backHome_Click);
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.bt_Search.FlatAppearance.BorderSize = 0;
            this.bt_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_Search.ForeColor = System.Drawing.Color.White;
            this.bt_Search.Location = new System.Drawing.Point(348, 160);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(174, 27);
            this.bt_Search.TabIndex = 56;
            this.bt_Search.Text = "BUSCAR";
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // datoErroneoDataProg
            // 
            this.datoErroneoDataProg.AutoSize = true;
            this.datoErroneoDataProg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoErroneoDataProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.datoErroneoDataProg.Location = new System.Drawing.Point(46, 185);
            this.datoErroneoDataProg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datoErroneoDataProg.Name = "datoErroneoDataProg";
            this.datoErroneoDataProg.Size = new System.Drawing.Size(88, 17);
            this.datoErroneoDataProg.TabIndex = 59;
            this.datoErroneoDataProg.Text = "Dato erróneo";
            this.datoErroneoDataProg.Visible = false;
            // 
            // dataProg
            // 
            this.dataProg.BackColor = System.Drawing.Color.White;
            this.dataProg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataProg.ForeColor = System.Drawing.Color.DimGray;
            this.dataProg.Location = new System.Drawing.Point(50, 163);
            this.dataProg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataProg.Name = "dataProg";
            this.dataProg.Size = new System.Drawing.Size(222, 20);
            this.dataProg.TabIndex = 58;
            this.dataProg.Visible = false;
            this.dataProg.Enter += new System.EventHandler(this.dataProg_Enter);
            this.dataProg.Leave += new System.EventHandler(this.dataProg_Leave);
            // 
            // labelComboText
            // 
            this.labelComboText.AutoSize = true;
            this.labelComboText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComboText.ForeColor = System.Drawing.Color.DimGray;
            this.labelComboText.Location = new System.Drawing.Point(46, 143);
            this.labelComboText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComboText.Name = "labelComboText";
            this.labelComboText.Size = new System.Drawing.Size(0, 17);
            this.labelComboText.TabIndex = 60;
            // 
            // labelComboBox
            // 
            this.labelComboBox.AutoSize = true;
            this.labelComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.labelComboBox.Location = new System.Drawing.Point(46, 143);
            this.labelComboBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComboBox.Name = "labelComboBox";
            this.labelComboBox.Size = new System.Drawing.Size(12, 17);
            this.labelComboBox.TabIndex = 61;
            this.labelComboBox.Text = "-";
            this.labelComboBox.Visible = false;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(16, 213);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView1.Size = new System.Drawing.Size(532, 316);
            this.dataGridView1.TabIndex = 62;
            // 
            // Form_InfoSpecificProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 605);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelComboBox);
            this.Controls.Add(this.labelComboText);
            this.Controls.Add(this.datoErroneoDataProg);
            this.Controls.Add(this.dataProg);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.datoErroneoComboBox);
            this.Controls.Add(this.dataOfProgram);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(581, 644);
            this.MinimumSize = new System.Drawing.Size(581, 644);
            this.Name = "Form_InfoSpecificProgram";
            this.Text = "Bucar Programa Especifico";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dataOfProgram;
        private System.Windows.Forms.Label datoErroneoComboBox;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Label datoErroneoDataProg;
        private System.Windows.Forms.TextBox dataProg;
        private System.Windows.Forms.Label labelComboText;
        private System.Windows.Forms.Label labelComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}