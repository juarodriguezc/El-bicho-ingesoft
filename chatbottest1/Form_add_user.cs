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
    public partial class Form_add_user : Form
    {
        //Variables utilizadas
        private string messageData = "Recuerde que:\n"
                + "1. Diligenciar nombre y apellido solo con caracteres alfabeticos.\n"
                + "2. Diligenciar el e-mail.\n"
                + "3. Seleccionar el cargo del nuevo usuario.\n"
                + "4. La contraseña debe tener entre 8 y 25 caracteres,\n almenos una letra mayuscula y al menos un número\n";
        //Metodos
        public Form_add_user()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {
            dato_erroneo_nombre.Visible = false;
            dato_erroneo_apellido.Visible = false;
            dato_erroneo_email.Visible = false;
            dato_erroneo_contrasenia.Visible = false;
            dato_erroneo_verificar.Visible = false;
            if (txt_nombre.Text.Length != 0 && txt_apellido.Text.Length != 0 && txt_correo.Text.Length != 0
                && txt_v_contra.Text.Length != 0 && comboBox_cargo.SelectedItem != null) {
                //Verifica que los campos no estén vacios -- Codigo traido de Felipe Riaño
                if (verficarNombre_Apell(txt_nombre.Text) && verficarNombre_Apell(txt_apellido.Text)
                    && verificarEmail(txt_correo.Text) && verficarPassWordL(txt_contrasenia.Text) && verificarIgualdadContra(txt_contrasenia.Text, txt_v_contra.Text)) 
                {
                    ModeloUsuario addUser = new ModeloUsuario();
                    if (!addUser.Add_user(txt_correo.Text, txt_nombre.Text, txt_apellido.Text, Convert.ToDateTime(pick_fecha_nacimiento.Text), txt_contrasenia.Text, comboBox_cargo.SelectedItem.ToString()))
                    {
                        MessageBox.Show("El correo registrado ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("El usuario ha sido registrado\n"+"Se ha enviado un correo al usuario para el acceso.\n", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    String nombre = txt_nombre.Text+" "+txt_apellido.Text;
                    String messageB = "Hola\n\n"
                            + nombre + "\n"
                            + "Te damos la bienvenida a YMCA-BOTSERVICE\n"
                            + "Recuerda tus datos:"
                            + "\n\t- Correo de acceso:\t" + txt_correo.Text + "\n"
                            + "\t- Contraseña:\t" + txt_contrasenia.Text + "\n\n"
                            + "Gracias!\n"
                            + "YMCA Colombia";
                    String subject = "Bienvenido a YMCA-BOTSERVICE";

                    String email = txt_correo.Text;

                    sendEmail(email, messageB, subject);

                    //Reiniciar valores para otro registro
                    txt_nombre.Text = "NOMBRE";
                    txt_apellido.Text = "APELLIDO";
                    txt_correo.Text = "CORREO";
                    pick_fecha_nacimiento.Value = DateTime.Parse("01-01-2000");
                    txt_contrasenia.UseSystemPasswordChar = false;
                    txt_v_contra.UseSystemPasswordChar = false;
                    txt_contrasenia.Text = "CONTRASEÑA";
                    txt_v_contra.Text = "VERIFICACIÓN";
                }
                else {
                    if (!verficarNombre_Apell(txt_nombre.Text)) dato_erroneo_nombre.Visible = true;
                    if (!verficarNombre_Apell(txt_apellido.Text)) dato_erroneo_apellido.Visible = true;
                    if (!verificarEmail(txt_correo.Text)) dato_erroneo_email.Visible = true;
                    if (!verficarPassWordL(txt_contrasenia.Text)) dato_erroneo_contrasenia.Visible = true;
                    if (!verificarIgualdadContra(txt_contrasenia.Text,txt_v_contra.Text)) dato_erroneo_verificar.Visible = true;
                    DialogResult datos = MessageBox.Show("Algunos datos ingresados son incorrectos", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show(messageData, "Tener en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                DialogResult datos = MessageBox.Show("Completa los campos", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private bool verficarNombre_Apell(string nom_apell)
        {
            //Verificar no numeros
            for (int i = 0; i < nom_apell.Length; i++){
                if (Char.IsDigit(nom_apell[i]) || (!Char.IsLetter(nom_apell[i]) && (!Char.IsWhiteSpace(nom_apell[i])))){
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
        public bool verificarIgualdadContra(String pass, String ver) {
            return (pass.Equals(ver));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                txt_nombre.Text = "NOMBRE";
                txt_nombre.ForeColor = Color.DimGray;
            }
        }

        private void txt_nombre_Enter(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "NOMBRE")
            {
                txt_nombre.Text = "";
                txt_nombre.ForeColor = Color.DimGray;
            }
        }
        
        private void Form_add_user_Load(object sender, EventArgs e)
        {
            MessageBox.Show(messageData, "Tener en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txt_contrasenia.UseSystemPasswordChar = false;
            txt_v_contra.UseSystemPasswordChar = false;
        }

        private void txt_apellido_Leave(object sender, EventArgs e)
        {
            if (txt_apellido.Text == "")
            {
                txt_apellido.Text = "APELLIDO";
                txt_apellido.ForeColor = Color.DimGray;
            }
        }

        private void txt_apellido_Enter(object sender, EventArgs e)
        {
            if (txt_apellido.Text == "APELLIDO")
            {
                txt_apellido.Text = "";
                txt_apellido.ForeColor = Color.DimGray;
            }
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (txt_correo.Text == "")
            {
                txt_correo.Text = "CORREO";
                txt_correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_correo_Enter(object sender, EventArgs e)
        {
            if (txt_correo.Text == "CORREO")
            {
                txt_correo.Text = "";
                txt_correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_contrasenia_Enter(object sender, EventArgs e)
        {
            if (txt_contrasenia.Text == "CONTRASEÑA")
            {
                txt_contrasenia.Text = "";
                txt_contrasenia.ForeColor = Color.DimGray;
                txt_contrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txt_contrasenia_Leave(object sender, EventArgs e)
        {
            if (txt_contrasenia.Text == "")
            {
                txt_contrasenia.Text = "CONTRASEÑA";
                txt_contrasenia.ForeColor = Color.DimGray;
                txt_contrasenia.UseSystemPasswordChar = false;
            }
        }

        private void txt_v_contra_Leave(object sender, EventArgs e)
        {
            if (txt_v_contra.Text == "")
            {
                txt_v_contra.Text = "VERIFICACIÓN";
                txt_v_contra.ForeColor = Color.DimGray;
                txt_v_contra.UseSystemPasswordChar = false;
            }
        }

        private void txt_v_contra_Enter(object sender, EventArgs e)
        {
            if (txt_v_contra.Text == "VERIFICACIÓN")
                txt_v_contra.Text = "";
                txt_v_contra.ForeColor = Color.DimGray;
                txt_v_contra.UseSystemPasswordChar = true;
            }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_contrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
