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
    public partial class Form_add_program : Form
    {
        ModeloPrograma programa = new ModeloPrograma();
        public Form_add_program()
        {
            InitializeComponent();
        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {
            lbl_errorNombrePrograma.Visible = false;
            lbl_FechaFinErronea.Visible = false;
            lbl_fechaInicioErronea.Visible = false;
            lbl_errorCompania.Visible = false;
            lbl_error_tipo_programa.Visible = false;

            if (verificarNombre(txt_programa.Text) && verificarFechaInicio(Convert.ToDateTime(pick_fecha_inicioPrograma.Text)) && verificarFechaFin(Convert.ToDateTime(pick_fecha_inicioPrograma.Text), Convert.ToDateTime(pick_fecha_finPrograma.Text)) && verificarCompania() && verificarTipoPrograma())
            {
                if(!programa.add_program(cmb_company.SelectedItem.ToString(),txt_programa.Text, Convert.ToDateTime(pick_fecha_inicioPrograma.Text), Convert.ToDateTime(pick_fecha_finPrograma.Text), cmb_tipoPrograma.SelectedItem.ToString())){
                    MessageBox.Show("El programa ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("El programa ha sido registrado\n", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void llenarCompanias()
        {
            List<string> programas = programa.companyList();
            foreach (string a in programas)
            {
                cmb_company.Items.Add(a);
            }

        }

        private void Form_add_program_Load(object sender, EventArgs e)
        {
            llenarCompanias();
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool verificarNombre(string nombre)
        {
            if (nombre.Length != 0)
            {
                return true;
            }
            else
            {
                lbl_errorNombrePrograma.Visible = true;
                return false;
            }
        }

        private bool verificarFechaInicio(DateTime fechaInicio)
        {
            DateTime now = DateTime.Now;
            if(fechaInicio >= now)
            {
                return true;
            }
            else
            {
                lbl_fechaInicioErronea.Visible = true;
                return false;
            }
        }

        private bool verificarFechaFin(DateTime fechaInicio, DateTime fechaFin)
        {
            if(fechaFin > fechaInicio)
            {
                return true;
            }
            else
            {
                lbl_FechaFinErronea.Visible = true;
                return false;
            }
            
        }

        private bool verificarCompania() 
        {
            if (!string.IsNullOrEmpty(cmb_company.Text))
            {
                return true;
            }
            else
            {
                lbl_errorCompania.Visible = true;
                return false;
            }
        }

        private bool verificarTipoPrograma()
        {
            if (!string.IsNullOrEmpty(cmb_tipoPrograma.Text))
            {
                return true;
            }
            else
            {
                lbl_error_tipo_programa.Visible = true;
                return false;
            }
        }

        private void txt_programa_Enter(object sender, EventArgs e)
        {
            if(txt_programa.Text == "NOMBRE DEL PROGRAMA")
            {
                txt_programa.Text = "";
                txt_programa.ForeColor = Color.DimGray;
            }
        }

        private void txt_programa_Leave(object sender, EventArgs e)
        {
            if (txt_programa.Text == "")
            {
                txt_programa.Text = "NOMBRE DEL PROGRAMA";
                txt_programa.ForeColor = Color.DimGray;
            }
        }
    }
}
