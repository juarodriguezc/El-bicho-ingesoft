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
using Common.Cache;
using chatbottest1.UserControls;

namespace chatbottest1
{
    public partial class Form_InfoProgram_Date : Form
    {

        ModeloUsuario usuario = new ModeloUsuario();

        public Form_InfoProgram_Date()
        {
            InitializeComponent();
            MostarInfoProgramaSegunFecha();
        }

        private void MostarInfoProgramaSegunFecha()
        {
            dataGridView1.DataSource = usuario.MostarInfoProgramaSegunFecha(chatbottest1.UserControls.Calendario.dateInfo);
        }
    }
}
