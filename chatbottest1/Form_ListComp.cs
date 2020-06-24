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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
