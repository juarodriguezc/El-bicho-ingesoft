using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatbottest1
{
    public partial class Form_AddPersonaPrograma : Form
    {
        ModeloVoluntario voluntarios = new ModeloVoluntario();
        ModeloPrograma programa = new ModeloPrograma();
        DataTable dt;
        public Form_AddPersonaPrograma()
        {
            InitializeComponent();
        }

        private void llenarProgramas()
        {
            List<string> programas = programa.programasList();
            foreach (string a in programas)
            {
                comboBox_programas.Items.Add(a);
            }
        }


        private void llenarVoluntarios(string programa)
        {
            dt = voluntarios.VoluntariosDisponibles(programa);
            dataGrid_voluntarios.DataSource = dt;
        }

        private void Form_AddPersonaPrograma_Load(object sender, EventArgs e)
        {
            llenarProgramas();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (dataGrid_voluntarios.SelectedRows.Count == 1)
            {
                DataGridViewRow dr = dataGrid_voluntarios.Rows[dataGrid_voluntarios.CurrentCell.RowIndex];
                DataGridViewRow data = (DataGridViewRow) dr.Clone();
                data.Cells[0].Value = dr.Cells[0].Value;
                data.Cells[1].Value = dr.Cells[1].Value;
                data.Cells[2].Value = dr.Cells[2].Value;

                dataGrid_voluntariosProg.Rows.Add(data);
                dataGrid_voluntarios.Rows.RemoveAt(dataGrid_voluntarios.CurrentRow.Index);
                dataGrid_voluntariosProg.Sort(dataGrid_voluntariosProg.Columns["Id_persona"], ListSortDirection.Ascending);
            }
        }

        private void bt_quitar_Click(object sender, EventArgs e)
        {
            if (dataGrid_voluntariosProg.SelectedRows.Count == 1)
            {
                DataGridViewRow dr = dataGrid_voluntariosProg.Rows[dataGrid_voluntariosProg.CurrentCell.RowIndex];
                DataRow row = dt.NewRow();
                row["Id persona"] = dr.Cells[0].Value;
                row["Nombre"]= dr.Cells[1].Value;
                row["Apellido"] = dr.Cells[2].Value;
                dt.Rows.Add(row);
                dataGrid_voluntariosProg.Rows.RemoveAt(dataGrid_voluntariosProg.CurrentRow.Index);
                dataGrid_voluntarios.Sort(dataGrid_voluntarios.Columns["Id persona"], ListSortDirection.Ascending);
            }
        }

        private void comboBox_programas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_voluntariosProg.Rows.Clear();
            if (dt != null)
            {
                dt.Clear();
            }
            llenarVoluntarios(comboBox_programas.SelectedItem.ToString());
        }

        private void bt_saveuser_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dataGrid_voluntariosProg.Rows)
            {
                voluntarios.add_VolunterProgram(row.Cells["Id_persona"].Value.ToString(), comboBox_programas.SelectedItem.ToString());
                i++;
            }
            dataGrid_voluntariosProg.Rows.Clear();
            if (dt != null)
            {
                dt.Clear();
            }
            llenarVoluntarios(comboBox_programas.SelectedItem.ToString());

            if (i > 0)
            {
                MessageBox.Show("Los voluntarios han sido registrados al programa", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
