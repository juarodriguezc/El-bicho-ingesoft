﻿namespace chatbottest1
{
    partial class Form_show_program_by_person
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_show_program_by_person));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datoErroneoDataProg = new System.Windows.Forms.Label();
            this.dataProg = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.datoErroneoComboBox = new System.Windows.Forms.Label();
            this.dataOfProgram = new System.Windows.Forms.Label();
            this.comboBoxConsulta = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_volver_chatbot = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(24, 290);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView1.Size = new System.Drawing.Size(786, 298);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // datoErroneoDataProg
            // 
            this.datoErroneoDataProg.AutoSize = true;
            this.datoErroneoDataProg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoErroneoDataProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.datoErroneoDataProg.Location = new System.Drawing.Point(92, 253);
            this.datoErroneoDataProg.Name = "datoErroneoDataProg";
            this.datoErroneoDataProg.Size = new System.Drawing.Size(88, 17);
            this.datoErroneoDataProg.TabIndex = 65;
            this.datoErroneoDataProg.Text = "Dato erróneo";
            this.datoErroneoDataProg.Visible = false;
            this.datoErroneoDataProg.Click += new System.EventHandler(this.datoErroneoDataProg_Click);
            // 
            // dataProg
            // 
            this.dataProg.BackColor = System.Drawing.Color.White;
            this.dataProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataProg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataProg.ForeColor = System.Drawing.Color.DimGray;
            this.dataProg.Location = new System.Drawing.Point(95, 223);
            this.dataProg.Name = "dataProg";
            this.dataProg.Size = new System.Drawing.Size(332, 27);
            this.dataProg.TabIndex = 64;
            this.dataProg.TextChanged += new System.EventHandler(this.dataProg_TextChanged);
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
            this.bt_Search.Location = new System.Drawing.Point(467, 220);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(261, 30);
            this.bt_Search.TabIndex = 63;
            this.bt_Search.Text = "BUSCAR";
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // datoErroneoComboBox
            // 
            this.datoErroneoComboBox.AutoSize = true;
            this.datoErroneoComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoErroneoComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.datoErroneoComboBox.Location = new System.Drawing.Point(640, 200);
            this.datoErroneoComboBox.Name = "datoErroneoComboBox";
            this.datoErroneoComboBox.Size = new System.Drawing.Size(88, 17);
            this.datoErroneoComboBox.TabIndex = 62;
            this.datoErroneoComboBox.Text = "Dato erróneo";
            this.datoErroneoComboBox.Visible = false;
            this.datoErroneoComboBox.Click += new System.EventHandler(this.datoErroneoComboBox_Click);
            // 
            // dataOfProgram
            // 
            this.dataOfProgram.AutoSize = true;
            this.dataOfProgram.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataOfProgram.ForeColor = System.Drawing.Color.DimGray;
            this.dataOfProgram.Location = new System.Drawing.Point(346, 171);
            this.dataOfProgram.Name = "dataOfProgram";
            this.dataOfProgram.Size = new System.Drawing.Size(115, 21);
            this.dataOfProgram.TabIndex = 61;
            this.dataOfProgram.Text = "BUSCAR POR ";
            this.dataOfProgram.Click += new System.EventHandler(this.dataOfProgram_Click);
            // 
            // comboBoxConsulta
            // 
            this.comboBoxConsulta.AutoCompleteCustomSource.AddRange(new string[] {
            "Id persona"});
            this.comboBoxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConsulta.FormattingEnabled = true;
            this.comboBoxConsulta.Items.AddRange(new object[] {
            "Id persona",
            "Nombre persona",
            "Apellido persona"});
            this.comboBoxConsulta.Location = new System.Drawing.Point(467, 169);
            this.comboBoxConsulta.Name = "comboBoxConsulta";
            this.comboBoxConsulta.Size = new System.Drawing.Size(261, 28);
            this.comboBoxConsulta.TabIndex = 60;
            this.comboBoxConsulta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(131)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 75);
            this.panel2.TabIndex = 67;
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
            // bt_volver_chatbot
            // 
            this.bt_volver_chatbot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_volver_chatbot.FlatAppearance.BorderSize = 0;
            this.bt_volver_chatbot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_volver_chatbot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_volver_chatbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_volver_chatbot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bt_volver_chatbot.ForeColor = System.Drawing.Color.LightGray;
            this.bt_volver_chatbot.Location = new System.Drawing.Point(12, 101);
            this.bt_volver_chatbot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_volver_chatbot.Name = "bt_volver_chatbot";
            this.bt_volver_chatbot.Size = new System.Drawing.Size(79, 33);
            this.bt_volver_chatbot.TabIndex = 68;
            this.bt_volver_chatbot.Text = "VOLVER";
            this.bt_volver_chatbot.UseVisualStyleBackColor = false;
            this.bt_volver_chatbot.Click += new System.EventHandler(this.bt_volver_chatbot_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_title.Location = new System.Drawing.Point(169, 101);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(493, 41);
            this.lbl_title.TabIndex = 69;
            this.lbl_title.Text = " PROGRAMAS POR PERSONA";
            // 
            // Form_show_program_by_person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.bt_volver_chatbot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datoErroneoDataProg);
            this.Controls.Add(this.dataProg);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.datoErroneoComboBox);
            this.Controls.Add(this.dataOfProgram);
            this.Controls.Add(this.comboBoxConsulta);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_show_program_by_person";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar programas por persona";
            this.Load += new System.EventHandler(this.Form_show_program_by_person_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label datoErroneoDataProg;
        private System.Windows.Forms.TextBox dataProg;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Label datoErroneoComboBox;
        private System.Windows.Forms.Label dataOfProgram;
        private System.Windows.Forms.ComboBox comboBoxConsulta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_volver_chatbot;
        private System.Windows.Forms.Label lbl_title;
    }
}