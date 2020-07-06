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
    public partial class Form_programas_activos : Form
    {
        ModeloPrograma programas = new ModeloPrograma();
        public Form_programas_activos()
        {
            InitializeComponent();
        }

        private void bt_volver_chatbot_stock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarProgramasActivos()
        {
            dataGrid_programas.DataSource = programas.programaActivos();
            dataGrid_programas.ClearSelection();
        }

        private void Form_programas_activos_Load(object sender, EventArgs e)
        {
            MostrarProgramasActivos();
        }
    }
}
