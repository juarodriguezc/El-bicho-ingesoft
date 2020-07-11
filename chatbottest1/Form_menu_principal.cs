using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Bot.Connector.DirectLine;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Configuration;
using System.Drawing.Text;
using Common.Cache;
using Business;
using System.Reflection;
using chatbottest1.UserControls;

namespace chatbottest1
{

    public partial class Form_menu_principal : Form
    {
        //object user
        public static ModeloUsuario _loggedUser;
        //Object main form
        public static Form_menu_principal _obj;
        //User control used
        public Chatbot cb;
        public Perfil_usuario profile;
        public Calendario calendar;
        public Ayuda help;


        public static ModeloUsuario UserInstance
        {
            get
            {
                if (_loggedUser == null)
                {
                    _loggedUser = new ModeloUsuario();
                }
                return _loggedUser;
            }
        }


        public static Form_menu_principal Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new Form_menu_principal();
                }
                return _obj;
            }
        }

        

        public Panel PnlContainer
        {
            get
            {
                return panel_principal;
            }
            set
            {
                panel_principal = value;
            }
        }
        private void Chatbot_menu_Load(object sender, EventArgs e)
        {
            loadUserdata();
            //Create objects

            _loggedUser = new ModeloUsuario();

            //Create Ayuda
            help = new Ayuda();

            //User control create
            _obj = this;
            cb = new Chatbot();
            cb.Dock = DockStyle.Fill;
            panel_principal.Controls.Add(cb);
            //Instanciacion inicial
            profile = new Perfil_usuario();
            calendar = new Calendario();

            help.Visible = false;
            profile.Visible = false;
            calendar.Visible = false;
        }


        //Carga de datos

        private void loadUserdata() {
            lblName.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
            lblCargo.Text = UserLoginCache.Rol_empresa ;
            lbl_iniciales.Text = "";
            lbl_iniciales.Text = (UserLoginCache.Nombre[0].ToString() + UserLoginCache.Apellido[0].ToString()).ToUpper();
        }
       

        public Form_menu_principal()
        {
            InitializeComponent();


        }

      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void bt_logout_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("¿Estas seguro que quieres cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Form_login_menu.loginInstance.changeTxt();
                this.Close();
                
            }*/
            this.Close();
        }
        private void Chatbot_menu_Leave(object sender, EventArgs e)
        {
            
        }
        private void Chatbot_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
 
        }

        private void bt_profile_Click(object sender, EventArgs e)
        {
            panel_selected_window.Height = bt_profile.Height;
            panel_selected_window.Top = bt_profile.Top;
            if (profile != null) profile.Dispose(); //no overload the memory
            profile = new Perfil_usuario();
            profile.Dock = DockStyle.Fill;
            //Cerrar todo lo demas
            help.Visible = false;
            calendar.Visible = false;
            cb.Visible = false;
            calendar.Dispose();
            //mostrar el usercontrol
            profile.Visible = true;
            panel_principal.Controls.Add(profile);
        }

        private void button_chatbot_Click(object sender, EventArgs e)
        {

            panel_selected_window.Height = bt_chatbot.Height;
            panel_selected_window.Top = bt_chatbot.Top;
            //Cerrar todo lo demas
            profile.Dispose();
            calendar.Dispose();

            //Cerrar todo 
            calendar.Visible = false;
            profile.Visible = false;
            help.Visible = false;

            //Abrir
            cb.Visible = true;
            
        }
        public Button getButton_chatbot() {
            return bt_chatbot;
        }

        public Button getButton_calendario() {
            return bt_calendario;
        }
        public Button getButton_ayuda()
        {
            return BtH;
        }

        private void lbl_iniciales_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_funcionalidad_Click(object sender, EventArgs e)
        {

        }

        private void bt_calendario_Click(object sender, EventArgs e)
        {
            panel_selected_window.Height = bt_calendario.Height;
            panel_selected_window.Top = bt_calendario.Top;
            Calendario calendar2 = new Calendario();
            calendar2.Dock = DockStyle.Fill;

            if (calendar != null) calendar.Dispose(); //no overload the memory
            calendar = calendar2;
            //Cerrar todo
            profile.Visible = false;
            help.Visible = false;
            cb.Visible = false;
            profile.Dispose();
            //Mostrar nuevo form
            calendar.Visible = true;
            panel_principal.Controls.Add(calendar);
        }

        private void panel_principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtH_Click(object sender, EventArgs e)
        {
            panel_selected_window.Height = BtH.Height;
            panel_selected_window.Top = BtH.Top;

            help = new Ayuda();

            //Cerra todo
            cb.Visible = false;
            calendar.Visible = false;
            profile.Visible = false;

            //Mostar 
            help.Visible = true;
            panel_principal.Controls.Add(help);

        }

        private void Form_menu_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
