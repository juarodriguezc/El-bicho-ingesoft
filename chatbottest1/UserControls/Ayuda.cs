using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatbottest1.UserControls
{
    public partial class Ayuda : UserControl
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            this.guia.Image = global::chatbottest1.Properties.Resources.GuiaInteractivaChatboot_page_0001;
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            this.guia.Image = global::chatbottest1.Properties.Resources.GuiaInteractivaChatboot_page_0002;
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            this.guia.Image = global::chatbottest1.Properties.Resources.GuiaInteractivaChatboot_page_0003;
        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            this.guia.Image = global::chatbottest1.Properties.Resources.GuiaInteractivaChatboot_page_0004;
        }

        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_menu_principal.Instance.getButton_chatbot().PerformClick();
        }
    }
}
