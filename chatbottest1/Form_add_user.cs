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
        public Form_add_user()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {
            ModeloUsuario addUser = new ModeloUsuario();
            Console.WriteLine("Fecha: "+ pick_fecha_nacimiento.Text);
            addUser.Add_user(txt_correo.Text, txt_nombre.Text, txt_apellido.Text, Convert.ToDateTime(pick_fecha_nacimiento.Text), txt_contrasenia.Text, 1);
        }
    }
}
