using Business;
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

namespace chatbottest1
{
    public partial class Form_RealizarMovimiento : Form
    {
        ModeloStock stock = new ModeloStock();
        public Form_RealizarMovimiento()
        {
            InitializeComponent();
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarProductos()
        {
            List<string> productos = stock.nombresProductos();
            foreach (string a in productos)
            {
                comboBox_producto.Items.Add(a);
            }
        }

        private void Form_RealizarMovimiento_Load(object sender, EventArgs e)
        {
            llenarProductos();
            cmbAccion.SelectedItem = "Ingresar";
        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {


            if (!stock.RealizarMovimiento(comboBox_producto.SelectedItem.ToString(),UserLoginCache.Id_usuario,Convert.ToInt32(txt_cantidad.Text), cmbAccion.SelectedItem.ToString()))
            {
                MessageBox.Show("La cantidad ingresada es superior a lo que hay en bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cantidad.Text = "";
            }
            else
            {
                MessageBox.Show("El movimiento se realizo correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            } 
        }

        private void comboBox_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_cantidad.Text = Convert.ToString(stock.cantidadProducto(comboBox_producto.SelectedItem.ToString()));

        }
    }
}
