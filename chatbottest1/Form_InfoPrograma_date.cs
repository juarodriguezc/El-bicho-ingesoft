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
using chatbottest1.UserControls;

namespace chatbottest1
{
    public partial class Form_InfoPrograma_date : Form
    {
        ModeloUsuario usuario = new ModeloUsuario();

        public Form_InfoPrograma_date()
        {
            InitializeComponent();
            MostarInformacionDeProgramaSegunFecha();
        }

        private void MostarInformacionDeProgramaSegunFecha()
        {
            dataGridView1.DataSource = usuario.MostarInfoProgramaSegunFecha(chatbottest1.UserControls.Calendario.dateInfoProgram);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
