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
using Common.Cache;

namespace chatbottest1
{
    public partial class Form_Edit_user : Form
    {
        //Atributos
        ModeloUsuario usuario = new ModeloUsuario();
        public Form_Edit_user()
        {
            InitializeComponent();
        }

        private void Edit_user_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        private void MostrarUsuarios() {
            dataGridView1.DataSource = usuario.MostrarUsuarios(UserLoginCache.Correo);
        }
    }
}
