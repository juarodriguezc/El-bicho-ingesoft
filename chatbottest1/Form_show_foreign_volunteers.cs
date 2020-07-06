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
    public partial class Form_show_foreign_volunteers : Form
    {
        ModeloVoluntario voluntario = new ModeloVoluntario();

        public Form_show_foreign_volunteers()
        {
            InitializeComponent();
        }

        private void Form_show_foreign_volunteers_Load(object sender, EventArgs e)
        {
            MostrarVoluntareosForaneos();
        }

        private void MostrarVoluntareosForaneos()
        {
            dataGridView1.DataSource = voluntario.MostrarVoluntariosDifferentToCountryWithActivePrograms("Colombia");
            dataGridView1.ClearSelection();
        }

        private void bt_saveuser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
