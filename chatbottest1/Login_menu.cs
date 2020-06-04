using Common.Cache;
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
    public partial class Login_menu : Form
    {
        //Variables a utilizar
        public String datoErro = "Verficar datos de:";

        public Login_menu()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_menu_Load(object sender, EventArgs e)
        {
            panel_login.Visible = true;
            panel_forgot.Visible = false;
            txt_contrasenia.UseSystemPasswordChar = false;

        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            ModeloUsuario user = new ModeloUsuario();
            var validLogin = user.LoginUser(txt_correo.Text, txt_contrasenia.Text);
            if (validLogin == true){
                
                Chatbot_menu bot_menu = new Chatbot_menu();
                bot_menu.Show();

                /*Principal_Menu principal_Menu = new Principal_Menu();
                principal_Menu.Show();*/
                this.Hide();
                bot_menu.FormClosed += Logout;
            }
            else {
                    txt_contrasenia.Clear();
                    txt_correo.Clear();
            }

        }


        private void txt_contrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_ingresar.PerformClick();
            }
        }

        private void txt_correo_Enter(object sender, EventArgs e)
        {
            if (txt_correo.Text == "CORREO") {
                txt_correo.Text = "";
                txt_correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (txt_correo.Text == "") {
                txt_correo.Text = "CORREO";
                txt_correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_contrasenia_Enter(object sender, EventArgs e)
        {
            if (txt_contrasenia.Text == "CONTRASEÑA")
            {
                txt_contrasenia.Text = "";
                txt_contrasenia.ForeColor = Color.DimGray;
                Console.WriteLine("activar");
                txt_contrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txt_contrasenia_Leave(object sender, EventArgs e)
        {
            if (txt_contrasenia.Text == "")
            {
                txt_contrasenia.Text = "CONTRASEÑA";
                txt_contrasenia.ForeColor = Color.DimGray;
                Console.WriteLine("desactivar");
                txt_contrasenia.UseSystemPasswordChar = false;
            }
        }

        

        private void linklbl_olvidar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_login.Visible = false;
            panel_forgot.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }


        public bool verificarEmailR()
        {
            //Verficiacion formato email
            //Contadores de arrobas y de puntos en la direccion del correo
            int verAt = 0, verPoint = 0, aux = 0;

            char[] charString = emailTxbRecContr.Text.ToCharArray();

            for (int i = 0; i < charString.Length; i++)
            {

                if (charString[i] == '@' && aux == 0)
                {
                    verAt++;
                    aux++;
                }
                else if (charString[i] == '.' && aux > 0)
                {
                    verPoint++;
                }
                else if (charString[i] == '@' && aux != 0)
                {
                    datoErro = datoErro + "\n- E-mail";
                    return false;
                }

            }

            if (verAt == 1 && verPoint > 0 && verPoint <= 2)
            {
                return true;
            }
            else
            {
                datoErro = datoErro + "\n- E-mail";
                return false;
            }
        }
        

        public void sendEmail(string email, string message, string subj)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            msg.To.Add(email);
            msg.Subject = subj;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            msg.Body = message;

            msg.From = new System.Net.Mail.MailAddress("chatbootymca@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("chatbootymca@gmail.com", "ingesoft123");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(msg);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar");
            }
        }





        private void recup_datos_Click(object sender, EventArgs e)
        {
            if (emailTxbRecContr.Text.Length != 0)
            {
                //Verficar que los datos ingresados sean correctos
                bool verfE = verificarEmailR();

                Console.WriteLine("Datos correctos "+verfE);

                //Consultar en la base de datos
                ModeloUsuario recupera = new ModeloUsuario();
                var validLogin = recupera.RecuperaContra(emailTxbRecContr.Text);
                if (validLogin == true) verfE = true;
                else verfE = false;

                Console.WriteLine("Existe en base de datos "+verfE);
                if (verfE)
                {
                    /*
                    //Contraseña nueva aleatoria
                    Random random = new Random();


                    int numAl = random.Next(40000, 100000);
                    char letAl = (char)(random.Next(65, 91));

                    String nuevaClav = numAl + "" + letAl;
                    */




                    //enviar correo con la nueva contraseña
                    String nombre = UserRecuperaCache.nombre_completo;
                    String Menssage = "Buen día\n"
                            + nombre + "\n\n"
                            + "\tTe habla " + "YMCA-BOTSERVICE" + ", ¿haz olvidado tu contraseña?\n"
                            + "\tEl siguiente codigo es la contraseña que tienes registrada \n"
                            + "\t\n\t ------> " + UserRecuperaCache.contrasenia + " <------ \n\n"
                            + "\t\nTe aconsejamos cambiarla lo más pronto posible\n"
                            + "\tEn caso de que no seas el solicitante de \n\tla nueva contraseña, comunicate inmediatamente\n"
                            + "\tcon YMCA-BOTSERVICE.\n\n"
                            + "Gracias\n"
                            + "YMCA COLOMBIA";

                    String Subject = "Cambio contraseña YMCA";

                    String email = emailTxbRecContr.Text;

                    sendEmail(email, Menssage, Subject);

                    //DialogResult datosE = MessageBox.Show("Verifica tu correo, por favor", "Cambio contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Limpiar TextBox

                    lbl_mailsent.Visible = true;
                    

                }
                else
                {
                    //Datos que estan erroneos en el formulario
                    datoErro = "Verficar datos ingresados";
                    DialogResult datosE = MessageBox.Show(datoErro, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                //Campos sin llenar
                datoErro = "Ingresa el correo";
                DialogResult datos = MessageBox.Show("Completa los campos", "Ingresa correo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);      
            }
            emailTxbRecContr.Text = "";
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            panel_forgot.Visible = false;
            panel_login.Visible = true;
            lbl_mailsent.Visible = false;
            emailTxbRecContr.Text = "";
        }

        private void emailTxbRecContr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                recup_datos.PerformClick();
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txt_correo.Clear();
            txt_contrasenia.Clear();
            this.Show();
            txt_correo.Focus();
        }

        private void txt_contrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
