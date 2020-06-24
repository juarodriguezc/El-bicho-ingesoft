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
    public partial class Form_AddPrograms_Boss : Form
    {

        string error = "Revisar los siguientes campos";
        ModeloUsuario addProgram = new ModeloUsuario();


        //Funciuones de verificacion de datos

        public bool verificarIdCompany()
        {
            char[] IdC = idCompania.Text.ToCharArray();

            if(IdC.Length == 0)
            {
                datoErroneoCompania.Visible = true;
                return false;
            }

            foreach (char i in IdC)
            {
                if (!Char.IsDigit(i))
                {
                    datoErroneoCompania.Visible = true;
                    return false;
                }
            }

            return true;
        }

        public bool verificarIdProgram()
        {
            char[] IdP = txt_Id_Programa.Text.ToCharArray();

            if (IdP.Length == 0)
            {
                datoErroneoProgram.Visible = true;
                return false;
            }

            foreach (char i in IdP)
            {
                if (!Char.IsDigit(i))
                {
                    datoErroneoProgram.Visible = true;
                    return false;
                }
            }

            return true;
        }

        public bool verificarNombrePrograma()
        {
            char[] nom = nameProgram.Text.ToCharArray();

            if(nom.Length == 0)
            {
                datoErroneoNombrePrograma.Visible = true;
                return false;
            }

            return true;
        }

        public bool verificarFecha()
        {
            if ((pick_fecha_inicioPrograma.Value - DateTime.Today).Days <= 0)
            {
                datoErroneoFechaInicio.Visible = true;
                return false;
            }

            return true;
        }

        public bool verificarTipo()
        {
            char[] tipo = tipoPrograma.Text.ToCharArray();

            if(tipo.Length == 0)
            {
                datoErroneoTipoPrograma.Visible = true;
                return false;
            }

            return true;
        }
        //----------


        public Form_AddPrograms_Boss()
        {
            InitializeComponent();
            MessageBox.Show("Recuerda llenar todos los campos correctamente.");
        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {
            bool a = verificarIdProgram(), b = verificarIdCompany(), c = verificarFecha(), d = verificarTipo(), f = verificarNombrePrograma();

            if (!(a && b && c && d && f))
            {
                MessageBox.Show(error);
            }
            else
            {
                //int idP, int IdC, string nomP, DateTime dateIn, string typePro
                if(!addProgram.Add_program(Int32.Parse(txt_Id_Programa.Text), Int32.Parse(idCompania.Text), nameProgram.Text, pick_fecha_inicioPrograma.Value, tipoPrograma.Text))
                {
                    MessageBox.Show("No existe el id de la compañia o ya existe el id del programa");
                }
                this.Close();
            }



        }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
