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
            dataGridView1.ClearSelection();
        }

        private void Form_registro_conversacion_Load(object sender, EventArgs e)
        {
            MostrarRegistroConversacion();
        }

        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
