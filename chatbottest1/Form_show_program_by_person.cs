using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Common.Cache;

namespace chatbottest1
{
    public partial class Form_show_program_by_person : Form
    {
        ModeloVoluntario voluntario = new ModeloVoluntario();

        private string messageData = "Recuerde que:\n"
                 + "1. Seleccionar una opcion valida entre las desplegadas.\n";
        public Form_show_program_by_person()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            if (comboBoxConsulta.SelectedItem==null) {
                datoErroneoComboBox.Visible = true;
                MessageBox.Show(messageData, "Tener en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string opcion = comboBoxConsulta.SelectedItem.ToString();
                string valor = dataProg.Text;
                MostrarVoluntariosPorPrograma(opcion, valor);
            }
            
        }

        private void MostrarVoluntariosPorPrograma(string opcion, string valor)
        {
            dataGridView1.DataSource = voluntario.MostrarVoluntariosPorPrograma(opcion, valor);
        } 

        private void datoErroneoComboBox_Click(object sender, EventArgs e)
        {

        }

        private void dataOfProgram_Click(object sender, EventArgs e)
        {

        }

        private void datoErroneoDataProg_Click(object sender, EventArgs e)
        {

        }

        private void dataProg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_show_program_by_person_Load(object sender, EventArgs e)
        {

        }

        private void bt_volver_chatbot_stock_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
