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
        ModeloUsuario addUserReq = new ModeloUsuario();
        private int indice;
        private string comboBoxText;

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
        private bool verificarIdPeticion()
        {
            char[] idP = idPeticion.Text.ToCharArray();

            foreach(char i in idP)
            {
                if (!char.IsDigit(i))
                {
                    datoErroneoIdPeticion.Visible = true;
                    return false;
                }
            }
            return true;
        }

        private bool verficarIdDirectivo()
        {
            char[] idD = idUsuarioTo.Text.ToCharArray();

            foreach(char i in idD)
            {
                if (!char.IsDigit(i))
                {
                    datoErroneoIdDirectivo.Visible = true;
                    return false;
                }
            }
            return true;

        }

        private bool verificarTipoSolicitud()
        {
            if(tiposDeSolicitud.Text == "")
            {
                datoErrorTipoSolicitud.Visible = true;
                return false;
            }

            return true;
        }
         
        private bool verificarAsunto()
        {
            if(solicitudText.Text.Length == 0)
            {
                datoErroneoAsuntoSolicitud.Visible = true;
                return false;
            }
            return true;
        }

        private bool verificarDescripcion()
        {
            if(descripcionSolicitudText.Text.Length == 0)
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

        private void idUsuarioTo_TextChanged(object sender, EventArgs e)
        {
            if (idUsuarioTo.Text == "ID PETICION")
            {
                idUsuarioTo.Text = "";
            }
        }

        private void idPeticion_TextChanged(object sender, EventArgs e)
        {
            if(idPeticion.Text == "ID PETICION")
            {
                idPeticion.Text = "";
            }
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_addRequest_Click(object sender, EventArgs e)
        {
            bool a = verficarIdDirectivo(), b = verificarAsunto(), c = verificarIdPeticion(), d = verificarTipoSolicitud(), f = verificarDescripcion();

            if(a && b && c && d && f)
            {
                //Base de datos
                switch (addUserReq.Add_UserRequest(Int32.Parse(idPeticion.Text), idUsuarioFrom, Int32.Parse(idUsuarioTo.Text), tiposDeSolicitud.Text, descripcionSolicitudText.Text))
                {
                    case 0:
                        Console.WriteLine("Ningún problema!");
                        //enviar correo a dirigente
                        string asunto = "Solicitud usuario " + idUsuarioFrom;
                        string mensaje = "Buenas tardes\n\n" +
                            "El usuario con id: \t\t" + idUsuarioFrom +
                            "\nrealizo un solicitud de tipo: \t\t" + tiposDeSolicitud.Text +
                            "\nel id de la peticion es: \t\t" + Int32.Parse(idPeticion.Text) +
                            "\n\nFavor atender la solicitud lo antes posible.";
                        sendEmail(addUserReq.correoDirectivo(Int32.Parse(idUsuarioTo.Text)), asunto, mensaje);
                        this.Close();
                        break;
                    case 1:
                        MessageBox.Show("El id de la peticion ya existe");
                        break;
                    case 2:
                        MessageBox.Show("El id del directivo no existe");
                        break;
                    default:
                        break;
                }
                //enviar correo
            }
            else
            {
                MessageBox.Show("Completa correctamente los datos de tu solicitud!");
            }
        }

        private void tiposDeSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
