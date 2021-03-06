﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace chatbottest1
{
    public partial class Form_EditProgramInfo : Form
    {
        ModeloUsuario usuario = new ModeloUsuario();
        ModeloPrograma program = new ModeloPrograma();
        int idProgram = 0, idCompania = 0;
        string tipoProg =  "";
        string nombreCompa = "";

        public Form_EditProgramInfo()
        {
            InitializeComponent();
            mostrarProgramas();
            addCompaniesToComboBox();
        }

        //Verificar datos

        public bool verificarIdCompania()
        {
            return existeCompania(idCompania);
        }

        public bool verificarNombrePrograma()
        {
            return txt_ProgramName.Text.Length != 0 ? true : false;
        }

        public bool verificarTipoPrograma()
        {
            int index = comboBoxTipoPrograma.SelectedIndex;
            Console.WriteLine(comboBoxTipoPrograma.SelectedItem.ToString());
            return !comboBoxTipoPrograma.SelectedItem.Equals("") ? true : false;
        }

        public bool verificarFechaInicio()
        {
            return ((pick_fechaIni.Value > DateTime.MinValue) && (pick_fechaIni.Value < DateTime.MaxValue)) ? true : false;
        }

        public bool verificarFechaFin()
        {
            return ((pick_fechaFin.Value > pick_fechaIni.Value) && (pick_fechaFin.Value <= DateTime.MaxValue) && (pick_fechaIni.Value > DateTime.MinValue)) ? true : false;
        }

        //---

        private void addCompaniesToComboBox()
        {
            foreach (string i in program.companyList())
            {
                comboBoxNombresCompan.Items.Add(i);
            }
        }

        private void mostrarProgramas()
        {
            dataGridView1.DataSource = program.programaNomCompania();
            dataGridView1.ClearSelection();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            
        }

        private bool existeCompania(int idC)
        {
            return program.existeCompania(idC);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                bt_saveuser.Visible = true;

                txt_ProgramName.ReadOnly = false;
                comboBoxNombresCompan.Enabled = true;
                comboBoxTipoPrograma.Enabled = true;

                txt_ProgramName.Enabled = true;
                pick_fechaIni.Enabled = true;
                pick_fechaFin.Enabled = true;

                idProgram = int.Parse(dataGridView1.CurrentRow.Cells["Id_programa"].Value.ToString());
                idCompania = int.Parse(dataGridView1.CurrentRow.Cells["Id_compania"].Value.ToString());
                nombreCompa = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txt_ProgramName.Text = dataGridView1.CurrentRow.Cells["Nombre_programa"].Value.ToString();
                tipoProg = dataGridView1.CurrentRow.Cells["Tipo_programa"].Value.ToString();
                pick_fechaIni.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Fecha_inicio"].Value.ToString());
                pick_fechaFin.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Fecha_fin"].Value.ToString());

                comboBoxNombresCompan.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                comboBoxTipoPrograma.Text = dataGridView1.CurrentRow.Cells["Tipo_programa"].Value.ToString();

            }
        }


        private void bt_saveuser_Click(object sender, EventArgs e)
        {

            if (verificarFechaInicio() && verificarFechaFin() && verificarIdCompania() && verificarNombrePrograma() && verificarTipoPrograma())
            {
                idCompania = program.buscarIdCompany(comboBoxNombresCompan.SelectedItem.ToString());
                tipoProg = comboBoxTipoPrograma.SelectedItem.ToString();
                program.editProgram(idProgram, idCompania, txt_ProgramName.Text, tipoProg, pick_fechaIni.Value, pick_fechaFin.Value);
                txt_ProgramName.Text = "NOMBRE PROGRAMA";
                mostrarProgramas();
                dataGridView1.ClearSelection();
                MessageBox.Show("Programa Editado!");
            }
            else
            {
                if (!verificarNombrePrograma()) dato_erroneo_nombre.Visible = true;
                if (!verificarFechaInicio()) dato_erroneo_fechaIni.Visible = true;
                if (!verificarFechaFin()) dato_erroneo_fechaFin.Visible = true;

            }
        }

        private void txt_ProgramName_Enter(object sender, EventArgs e)
        {
            if (txt_ProgramName.Text == "NOMBRE PROGRAMA")
            {
                txt_ProgramName.Text = "";
                txt_ProgramName.ForeColor = Color.DimGray;
            }
        }

        private void txt_ProgramName_Leave(object sender, EventArgs e)
        {
            if (txt_ProgramName.Text == "")
            {
                txt_ProgramName.Text = "NOMBRE PROGRAMA";
                txt_ProgramName.ForeColor = Color.DimGray;
            }
        }

        private void Form_EditProgramInfo_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dato_erroneo_nombre.Visible = false;
            dato_erroneo_fechaIni.Visible = false;
            dato_erroneo_fechaFin.Visible = false;
        }

        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            txt_ProgramName.ReadOnly = false;
            comboBoxNombresCompan.Enabled = true;
            comboBoxTipoPrograma.Enabled = true;

            txt_ProgramName.Enabled = true;
            pick_fechaIni.Enabled = true;
            pick_fechaFin.Enabled = true;

        }
    }
}
