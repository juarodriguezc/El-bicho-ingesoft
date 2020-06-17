using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace chatbottest1
{
    public partial class Perfil_usuario : UserControl
    {
        public Perfil_usuario()
        {
            InitializeComponent();
        }

        private void Perfil_usuario_Load(object sender, EventArgs e)
        {
            txt_nombre.Text = UserLoginCache.Nombre.ToString();
            txt_apellido.Text = UserLoginCache.Apellido.ToString();
            txt_cargo.Text = UserLoginCache.Rol_empresa.ToString();
            txt_correo.Text = UserLoginCache.Correo.ToString();
            txt_genero.Text = UserLoginCache.Genero.ToString();
            txt_nacimiento.Text = UserLoginCache.Fecha_nacimiento.ToShortDateString().ToString();
            txt_id.Text = UserLoginCache.Id_Persona.ToString();
            txt_telefono.Text = UserLoginCache.Telefono.ToString();
            txt_password.UseSystemPasswordChar = true;
            txt_verificacion.UseSystemPasswordChar = true;
        }

        private void bt_change_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recuerde que: \n La contraseña debe ser mayor a 8 caracteres, \n debe contener por lo menos una mayúscula y \n un número", "Tener en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txt_password.Text = string.Empty;
            txt_password.Enabled = true;
            txt_verificacion.Enabled = true;
            lbl_verificacion.Visible = true;
            txt_verificacion.Visible = true;
            bt_change.Visible = false;
            bt_guardar.Visible = true;
        }

        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_menu_principal.Instance.getButton_chatbot().PerformClick();
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (verficarPassWordL(txt_password.Text) && verificarIgualdadContra(txt_password.Text,txt_verificacion.Text))
            {
                Console.WriteLine("Código user: "+UserLoginCache.Id_usuario);
                lbl_error_data.Visible = false;
                Business.ModeloUsuario user = new Business.ModeloUsuario();
                Form_menu_principal.UserInstance.CambiarPassword(UserLoginCache.Id_Persona, txt_password.Text);
                txt_password.Text = "Esta no es xd";
                txt_verificacion.Text = string.Empty;
                txt_verificacion.Visible = false;
                bt_guardar.Visible = false;
                bt_change.Visible = true;
                lbl_verificacion.Visible = false;
                lbl_cambio_correcto.Visible = true;


            }
            else if(!verficarPassWordL(txt_password.Text))
            {
                lbl_error_data.Visible = true;
                MessageBox.Show("Recuerde que: \n La contraseña debe ser mayor a 8 caracteres," +
                    " \n debe contener por lo menos una mayúscula y \n un número", "Tener en cuenta"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                lbl_error_data.Visible = true;
                MessageBox.Show("Las contraseñas no coinciden", "Tener en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }





        public bool verficarPassWordL(String password)
        {
            //Verificar password, código Felipe Riaño
            if (password.Length >= 8 && password.Length <= 25)
            {
                //Contadores de mayusculas y numeros
                int cantNum = 0, cantUper = 0;

                for (int i = 0; i < password.Length; i++)
                {
                    //Verficiacion si la contraseña tiene algun caracter que no sea digito o letra
                    if (Char.IsLetter(password[i]) || Char.IsDigit(password[i]))
                    {

                        if (Char.IsUpper(password[i]))
                        {
                            cantUper++;
                        }
                        else if (Char.IsDigit(password[i]))
                        {
                            cantNum++;
                        }

                    }
                    else
                    {
                        return false;
                    }

                }

                //Verificacion contraseña con numeros y con mayusculas
                if (cantNum > 0 && cantUper > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        public bool verificarIgualdadContra(String pass, String ver)
        {
            return (pass.Equals(ver));
        }
    }
}
