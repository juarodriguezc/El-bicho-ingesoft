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
    public partial class Principal_Menu : Form
    {
        public Principal_Menu()
        {
            InitializeComponent();
        }

        private void imgChat_Click(object sender, EventArgs e)
        {
            Form_menu_principal bot_menu = new Form_menu_principal();
            bot_menu.Show();
        }

        private void txtChat_Click(object sender, EventArgs e)
        {
            Form_menu_principal bot_menu = new Form_menu_principal();
            bot_menu.Show();
        }

        private void Principal_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
