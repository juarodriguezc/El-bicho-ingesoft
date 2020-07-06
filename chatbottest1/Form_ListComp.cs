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

namespace chatbottest1
{
    public partial class Form_ListComp : Form
    {
        ModeloUsuario usuario = new ModeloUsuario();

        public Form_ListComp()
        {
            InitializeComponent();
            mostrarInformacionCompanias();
        }

        private void mostrarInformacionCompanias()
        {
            dataGridView1.DataSource = usuario.showInfoCompanies();
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ListComp_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
