using Data;
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
    public partial class Login_menu : Form
    {
        public Login_menu()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_menu_Load(object sender, EventArgs e)
        {

        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            ModeloUsuario user = new ModeloUsuario();
            var validLogin = user.LoginUser(txt_correo.Text, txt_contrasenia.Text);
            if (validLogin == true){            
                    Chatbot_menu bot_menu = new Chatbot_menu();
                    bot_menu.Show();
                    this.Hide();
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
    }
}
