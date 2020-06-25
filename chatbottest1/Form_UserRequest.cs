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
using Microsoft.Bot.Connector.DirectLine;

namespace chatbottest1
{
    public partial class Form_UserRequest : Form
    {
        private int idUsuarioFrom = UserLoginCache.Id_usuario;
        private string UsuarioFrom = UserLoginCache.Nombre+" "+ UserLoginCache.Apellido;
        ModeloPeticiones peticiones = new ModeloPeticiones();


        //Funcion Enviar Correo electronico
        private void sendEmail(string correoDestinatario, string asunto, string mensaje)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            //Destinaterio
            msg.To.Add(correoDestinatario);

            //Asunto
            msg.Subject = asunto;

            //Formato para servidores
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Mesnaje 
            msg.Body = mensaje;
            msg.BodyEncoding = System.Text.Encoding.UTF8;

            //Quien envia
            msg.From = new System.Net.Mail.MailAddress("chatbootymca@gmail.com");

            //cliente correo
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

            //Credenciales
            client.Credentials = new System.Net.NetworkCredential("chatbootymca@gmail.com", "ingesoft123");

            //Puertos
            client.Port = 587;
            client.EnableSsl = true;

            client.Host = "smtp.gmail.com";

            //Errores 
            try
            {
                client.Send(msg);
            }
            catch
            {
                MessageBox.Show("Error al enviar");
            }
        }

        //Verificar datos
        private bool verificarDirectivo()
        {
            if (!string.IsNullOrEmpty(comboBox_directivo.Text))
            {
                return true;
            }
            else
            {
                lbl_error_directivo.Visible = false;
                return false;
            }

        }

        private bool verificarTipoSolicitud()
        {
            if (!string.IsNullOrEmpty(comboBox_tipo_solicitud.Text))
            {
                return true;
            }
            else
            {
                lbl_error_tipo.Visible = false;
                return false;
            }
        }
         
        private bool verificarAsunto()
        {
            if(txt_asunto_solicitud.Text.Length == 0)
            {
                datoErroneoAsuntoSolicitud.Visible = true;
                return false;
            }
            return true;
        }

        private bool verificarDescripcion()
        {
            if(txt_descripcion.Text.Length == 0)
            {
                datoErroneoDescripSoli.Visible = true;
                return false;
            }
            return true;
        }
        //

        public Form_UserRequest()
        {
            MessageBox.Show("Estamos para ayudarte, completa la solicitud y estaremos atentos responderte.");
            InitializeComponent();
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_addRequest_Click(object sender, EventArgs e)
        {
            if(verificarDirectivo() && verificarTipoSolicitud() && verificarAsunto() && verificarDescripcion())
            {
                peticiones.add_user_request(idUsuarioFrom, comboBox_directivo.SelectedItem.ToString(), comboBox_tipo_solicitud.SelectedItem.ToString(), txt_asunto_solicitud.Text, txt_descripcion.Text);
                string mailTo = peticiones.mailDirect(comboBox_directivo.SelectedItem.ToString());
                string asunto = txt_asunto_solicitud.Text ;
                string mensaje = "Buenas tardes\n\n" +
                    "El usuario : " + UsuarioFrom +
                    "\nrealizo la siguiente solicitud: " +
                    comboBox_tipo_solicitud.SelectedItem.ToString()+"\n\n "+
                    txt_descripcion.Text+
                    "\n\nFavor atender la solicitud lo antes posible.";

                sendEmail(mailTo, asunto, mensaje);

                MessageBox.Show("La petición ha sido realizada\n", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            


        }
        private void llenarDirectivos()
        {
            List<string> directivos = peticiones.nombresDirectivos();
            foreach (string a in directivos)
            {
                comboBox_directivo.Items.Add(a);
            }

        }

        private void Form_UserRequest_Load(object sender, EventArgs e)
        {
            llenarDirectivos();
        }
    }
}
