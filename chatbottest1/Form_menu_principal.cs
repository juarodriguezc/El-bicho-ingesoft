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

namespace chatbottest1
{

    public partial class Form_menu_principal : Form
    {
        
        static Form_menu_principal _obj;

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
            _obj = this;
            Chatbot cb = new Chatbot();
            cb.Dock = DockStyle.Fill;
            panel_principal.Controls.Add(cb);
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
            if (MessageBox.Show("¿Estas seguro que quieres cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
            }
        }
        private void Chatbot_menu_Leave(object sender, EventArgs e)
        {
            
        }
        private void Chatbot_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
