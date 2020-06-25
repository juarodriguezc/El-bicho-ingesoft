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
    public partial class Form_Info_Personas : Form
    {
        ModeloUsuario usuario = new ModeloUsuario();

        public Form_Info_Personas()
        {
            InitializeComponent();
            MostrarInformacionDePersonas();
        }

        private void MostrarInformacionDePersonas()
        {
            dataGridView1.DataSource = usuario.MostrarInfoPersonas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
