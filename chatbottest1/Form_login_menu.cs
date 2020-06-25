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
    public partial class Form_login_menu : Form
    {
        //Variables a utilizar
        public String datoErro = "Verficar datos de:";

        private string messageData = "1. La contraseña debe tener entre 8 y 25 caracteres,\n almenos una letra mayuscula y al menos un número\n";

        static Form_login_menu _login;
        public static Form_login_menu loginInstance
        {
            get
            {
                if (_login == null)
                {
                    _login = new Form_login_menu();
                }
                return _login;
            }
        }
        public Form_login_menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_menu_Load(object sender, EventArgs e)
        {
            _login = this;
            panel_login.Visible = true;
            panel_forgot.Visible = false;
            panel_verificacion.Visible = false;
            txt_contrasenia.UseSystemPasswordChar = false;
            ActiveControl = bt_ingresar;
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
        }
        
        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            ModeloUsuario user = new ModeloUsuario();
            var validLogin = user.LoginUser(txt_correo.Text, txt_contrasenia.Text);

            if (validLogin == true){
                
                Form_menu_principal bot_menu = new Form_menu_principal();
                bot_menu.Show();
                this.Hide();
                bot_menu.FormClosed += Logout;
            }
            else {
                lbl_error_data.Visible = true;
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
                    //enviar correo con la nueva contraseña
                    envioMail();

                    //Limpiar TextBox
                    

                    panel_forgot.Visible = false;
                    panel_verificacion.Visible = true;
                    //panel_ver.Visible = true;

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
            
        }

        private void envioMail()
        {
            String nombre = UserRecuperaCache.nombre_completo;
            String Menssage = "Buen día: "+ nombre + "\n"
                    + "\tTe habla " + "YMCA-BOTSERVICE" + ", ¿haz olvidado tu contraseña?\n"
                    + "\tEl siguiente es tu codigo de recuperación \n"
                    + "\t\n\t --->" + UserRecuperaCache.cod_verificación + " <--- \n"
                    + "\t\nIngresalo en la app para poder cambiar tu contraseña\n"
                    + "\t\nEste tendra una duración de 5 minutos\n"
                    + "Gracias\n"
                    + "YMCA COLOMBIA";

            String Subject = "Codigo de verificación YMCA";

            String email = emailTxbRecContr.Text;

            sendEmail(email, Menssage, Subject);
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            panel_forgot.Visible = false;
            panel_login.Visible = true;
            
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

            txt_correo.Text = "";
            txt_correo.ForeColor = Color.DimGray;

            txt_contrasenia.Text = "CONTRASEÑA";
            txt_contrasenia.ForeColor = Color.DimGray;

            lbl_error_data.Visible = false;
        }


        private void btn_verificar_Click(object sender, EventArgs e)
        {

        }

        

        public bool verificarPassWordL(String password)
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


        public bool verificarIgualContr(String pass, String ver)
        {
            return (pass.Equals(ver));
        }

        private void btn_volver_login_Click(object sender, EventArgs e)
        {
            btn_volver_login.Visible = false;
            panel_login.Visible = true;

            txt_correo.Text = "CORREO";
            txt_correo.ForeColor = Color.DimGray;

            txt_contrasenia.Text = "CONTRASEÑA";
            txt_contrasenia.ForeColor = Color.DimGray;
        }

        private void txt_cont_ver_Enter(object sender, EventArgs e)
        {
                txt_contrasenia.Text = "";
                txt_contrasenia.ForeColor = Color.DimGray;
                txt_contrasenia.UseSystemPasswordChar = true;
        }

        private void txt_rep_cont_ver_TextChanged(object sender, EventArgs e)
        {
            txt_contrasenia.Text = "";
            txt_contrasenia.ForeColor = Color.DimGray;
            txt_contrasenia.UseSystemPasswordChar = true;

        }

        private void lbl_verificar_codigo_Click(object sender, EventArgs e)
        {
            DateTime tiempoVer = DateTime.Now;
            TimeSpan span = tiempoVer.Subtract(UserRecuperaCache.fecha_envio);
            if (verifyNumeric(txt_codigo_ver.Text)) {
                if (Convert.ToInt32(txt_codigo_ver.Text) == UserRecuperaCache.cod_verificación && span.Minutes <= 5)
                {
                    //panel_ver.Visible = false;
                    panel_verificacion.Visible = false;
                    panel_cambio_contrasenia.Visible = true;
                    txt_codigo_ver.Text = "";
                    emailTxbRecContr.Text = "";
                    MessageBox.Show(messageData, "Tener en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Convert.ToInt32(txt_codigo_ver.Text) != UserRecuperaCache.cod_verificación)
                    {
                        lbl_codigo_incorrecto.Visible = true;
                        txt_codigo_ver.Clear();

                    }
                    if (span.Minutes > 5)
                    {
                        Random rnd = new Random();
                        UserRecuperaCache.cod_verificación = rnd.Next(1000, 9999);
                        UserRecuperaCache.fecha_envio = DateTime.Now;
                        txt_codigo_ver.Clear();
                        //lbl_cod_exp.Visible = true;
                        lbl_cod_expirado.Visible = true;
                        envioMail();
                    }
                }
            }
            else
            {
                lbl_codigo_incorrecto.Visible = true;
                txt_codigo_ver.Clear();
            }

        }

        public bool verifyNumeric(string text) {
            foreach (char a in text) {
                if (!char.IsNumber(a)) return false;
            }
            return true;
        }

        public void changeTxt() {
            txt_correo.Text = "asdasdasd";
            txt_contrasenia.UseSystemPasswordChar = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_cont_ver.Text.Length != 0 && txt_rep_cont_ver.TextLength != 0)
            {
                if (verificarPassWordL(txt_cont_ver.Text) && verificarIgualContr(txt_cont_ver.Text, txt_rep_cont_ver.Text))
                {

                    ModeloUsuario recupera = new ModeloUsuario();
                    recupera.CambiarPassword(UserRecuperaCache.id_persona, txt_cont_ver.Text);
                    panel_cambio_correcto.Visible = true;
                    panel_cambio_contrasenia.Visible = false;
                }
                else
                {
                    if (!verificarPassWordL(txt_cont_ver.Text))
                    {
                        lbl_verCon.Visible = false;
                        lbl_cont_req.Visible = true;
                        txt_cont_ver.Clear();
                        txt_rep_cont_ver.Clear();
                    }

                    if (!verificarIgualContr(txt_cont_ver.Text, txt_rep_cont_ver.Text))
                    {
                        lbl_verCon.Visible = true;
                        lbl_cont_req.Visible = false;
                        txt_cont_ver.Clear();
                        txt_rep_cont_ver.Clear();
                    }

                }

            }
            else
            {
                DialogResult datos = MessageBox.Show("Completa los campos", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btn_volver_login_Click_1(object sender, EventArgs e)
        {
            panel_cambio_correcto.Visible = false;
            panel_login.Visible = true;

            txt_correo.Text = "CORREO";
            txt_correo.ForeColor = Color.DimGray;

            txt_contrasenia.Text = "CONTRASEÑA";
            txt_contrasenia.ForeColor = Color.DimGray;
        }

        private void bt_cancelar_cambio_Click(object sender, EventArgs e)
        {
            lbl_cont_req.Visible = false;
            lbl_verCon.Visible = false;
            panel_cambio_contrasenia.Visible = false;
            panel_login.Visible = true;
            
            emailTxbRecContr.Text = "";
        }

        private void bt_volver_inicio_codigo_Click(object sender, EventArgs e)
        {
            txt_codigo_ver.Text = "";
            lbl_cod_expirado.Visible = false;
            panel_verificacion.Visible = false;
            panel_login.Visible = true;
            
            emailTxbRecContr.Text = "";
        }

        private void Form_login_menu_Shown(object sender, EventArgs e)
        {
            
        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
