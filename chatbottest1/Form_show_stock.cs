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
    public partial class Form_show_stock : Form
    {
        ModeloStock stock = new ModeloStock();

        public Form_show_stock()
        {
            InitializeComponent();
        }

        private void bt_volver_chatbot_stock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarProductosStock()
        {
            dataGrid_stock.DataSource = stock.MostrarProductosStock();
        }

        private void Form_show_stock_Load(object sender, EventArgs e)
        {
            MostrarProductosStock();
        }
    }
}
