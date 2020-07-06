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
        //ModeloUsuario usuario = new ModeloUsuario();
        ModeloPrograma programa = new ModeloPrograma();

        DateTime selectedDate;
        public Form_InfoPrograma_date(DateTime fecha)
        {
            InitializeComponent();
            MostarInformacionDeProgramaSegunFecha(fecha);
        }

        private void MostarInformacionDeProgramaSegunFecha(DateTime fecha)
        {
            selectedDate = fecha;
            dataGridView1.DataSource = programa.MostarInfoProgramaSegunFecha(selectedDate);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_InfoPrograma_date_Load(object sender, EventArgs e)
        {
            lbl_seleccted_date.Text = selectedDate.ToString("dd 'de' MMMM 'del' yyyy");
            pick_fecha_nacimiento.Value = selectedDate;
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            selectedDate = pick_fecha_nacimiento.Value;
            lbl_seleccted_date.Text = selectedDate.ToString("dd 'de' MMMM 'del' yyyy");
            dataGridView1.DataSource = programa.MostarInfoProgramaSegunFecha(selectedDate);
        }
    }
}
