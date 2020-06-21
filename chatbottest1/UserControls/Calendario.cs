using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using Business;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using Common.Cache;

namespace chatbottest1.UserControls
{

    public partial class Calendario : UserControl
    {
       
        public  static DateTime dateInfo;

        public Calendario()
        {
            InitializeComponent();
        }

        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_menu_principal.Instance.getButton_chatbot().PerformClick();
        }

        //Felipe
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            dateInfo = this.calendarioPersonalizado1.SelectionStart;
     
            string date = "¿La fecha que desea consultar es " + dateInfo.ToString("d") + " ?";
            const string tittle = "Confirmación";
            var result = MessageBox.Show(date, tittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Resultado
            if (result == DialogResult.Yes)
            {

                Form_InfoProgram_Date bot_cal = new Form_InfoProgram_Date();

                bot_cal.Show();

                Console.WriteLine("Si");
            }
        }
    }
}
