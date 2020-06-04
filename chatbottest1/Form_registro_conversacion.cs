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
    public partial class Form_registro_conversacion : Form
    {
        ModeloUsuario usuario = new ModeloUsuario();
        public Form_registro_conversacion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void MostrarRegistroConversacion() {
            dataGridView1.DataSource = usuario.MostrarRegistroConversacion();
        }

        private void Form_registro_conversacion_Load(object sender, EventArgs e)
        {
            MostrarRegistroConversacion();
        }
    }
}
