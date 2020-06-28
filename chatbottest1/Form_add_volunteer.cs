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
    public partial class Form_add_volunteer : Form
    {
        private string messageData = "Recuerde que:\n"
                 + "1. Diligenciar nombre y apellido solo con caracteres alfabeticos.\n"
                 + "2. Diligenciar el correo.\n";
        public Form_add_volunteer()
        {
            InitializeComponent();
        }

        private void lbl_addUser_Click(object sender, EventArgs e)
        {

        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {
            dato_erroneo_nombre.Visible = false;
            dato_erroneo_apellido.Visible = false;
            dato_erroneo_email.Visible = false;
            dato_erroneo_cedula.Visible = false;
            dato_erroneo_telefono.Visible = false;
            if (txt_nombre.Text.Length != 0 && txt_apellido.Text.Length != 0 && txt_correo.Text.Length != 0
                && txt_cedula.Text.Length != 0)
            {
                //Verifica que los campos no estén vacios -- Codigo traido de Felipe Riaño
                if (verficarNombre_Apell(txt_nombre.Text) && verficarNombre_Apell(txt_apellido.Text)
                    && verificarEmail(txt_correo.Text))
                {
                    ModeloVoluntario addVolunteer = new ModeloVoluntario();
                    if (!addVolunteer.Add_volunteer(Convert.ToInt32(txt_cedula.Text), txt_nombre.Text, txt_apellido.Text, Convert.ToDateTime(pick_fecha_nacimiento.Text), txt_telefono.Text, comboBox_genero.SelectedItem.ToString(), txt_correo.Text))
                    {
                        MessageBox.Show("El correo registrado ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("El usuario ha sido registrado\n" + "Se ha enviado un correo al usuario para el acceso.\n", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    String nombre = txt_nombre.Text + " " + txt_apellido.Text;

                    //Reiniciar valores para otro registro

                    txt_nombre.Text = "NOMBRE";
                    txt_apellido.Text = "APELLIDO";
                    txt_correo.Text = "CORREO";
                    pick_fecha_nacimiento.Value = DateTime.Parse("01-01-2000");


                }
                else
                {
                    if (!verficarNombre_Apell(txt_nombre.Text)) dato_erroneo_nombre.Visible = true;
                    if (!verficarNombre_Apell(txt_apellido.Text)) dato_erroneo_apellido.Visible = true;
                    if (!verificarEmail(txt_correo.Text)) dato_erroneo_email.Visible = true;
                    DialogResult datos = MessageBox.Show("Algunos datos ingresados son incorrectos", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show(messageData, "Tener en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                DialogResult datos = MessageBox.Show("Completa los campos", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool verficarNombre_Apell(string nom_apell)
        {
            //Verificar no numeros
            for (int i = 0; i < nom_apell.Length; i++)
            {
                if (Char.IsDigit(nom_apell[i]) || (!Char.IsLetter(nom_apell[i]) && (!Char.IsWhiteSpace(nom_apell[i]))))
                {
                    return false;
                }
            }
            return true;

        }

        public bool verificarEmail(string email)
        {
            //Adaptación código Felipe Riaño
            //Verficiacion formato email
            //Contadores de arrobas y de puntos en la direccion del correo
            int verAt = 0, verPoint = 0, aux = 0;

            for (int i = 0; i < email.Length; i++)
            {

                if (email[i] == '@' && aux == 0)
                {
                    verAt++;
                    aux++;
                }
                else if (email[i] == '.' && aux > 0)
                {
                    verPoint++;
                }
                else if (email[i] == '@' && aux != 0)
                {
                    return false;
                }

            }
            if (verAt == 1 && verPoint > 0 && verPoint <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
