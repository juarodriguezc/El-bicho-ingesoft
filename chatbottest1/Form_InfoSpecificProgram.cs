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
    public partial class Form_InfoSpecificProgram : Form
    {
        private string comboSelect;
        ModeloUsuario showSpePro = new ModeloUsuario();

        //Verificacion de campos
        private bool verificarComboBox()
        {
            if(comboBox1.Text == "-")
            {
                datoErroneoComboBox.Visible = true;
                return false;
            }

            return true;
        }

        private bool verificarTxt()
        {
            if(dataProg.Text == "_____________________")
            {
                datoErroneoDataProg.Visible = true;
                return false;
            }
            return true;
        }
        //--

        public Form_InfoSpecificProgram()
        {
            InitializeComponent();
        }

        private void MostrarInformacionProgramaEspecifico(int idP, int idC, string nomP, DateTime fechaIn, string typeP)
        {
            dataGridView1.DataSource = showSpePro.MostrarInfoProgramaEspc( idP, idC, nomP, fechaIn, typeP);
        }

        private void dataProg_Enter(object sender, EventArgs e)
        {
            if (dataProg.Text == "_____________________")
            {
                dataProg.Text = "";
                dataProg.ForeColor = Color.DimGray;
            }

        }

        private void dataProg_Leave(object sender, EventArgs e)
        {
            if (dataProg.Text == "")
            {
                dataProg.Text = "_____________________";
                dataProg.ForeColor = Color.DimGray;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;

            comboSelect = comboBox1.Items[index].ToString();

            dataProg.Visible = true;
            dataProg.Text = "_____________________";
            labelComboBox.Text = comboSelect;
            labelComboBox.Visible = true;
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            bool a = verificarComboBox(), b = verificarTxt();

            if ( a && b)
            {
                switch (comboSelect)
                {
                    case ("Id del programa"):
                        MostrarInformacionProgramaEspecifico(Int32.Parse(dataProg.Text), 0, null, DateTime.MinValue, null);
                        break;
                    case ("Id de la compañia"):
                        MostrarInformacionProgramaEspecifico(0, Int32.Parse(dataProg.Text), null, DateTime.MinValue, null);
                        break;
                    case ("Nombre del programa"):
                        MostrarInformacionProgramaEspecifico(0, 0, dataProg.Text, DateTime.MinValue, null);
                        break;
                    case ("Fecha del programa"):
                        MostrarInformacionProgramaEspecifico(0, 0, null, DateTime.MinValue, null);
                        break;
                    case ("Tipo del programa"):
                        MostrarInformacionProgramaEspecifico(0, 0, null, DateTime.MinValue, dataProg.Text);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Verificar los campos por favor!");
            }
            
            
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
