using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatbottest1
{
    public partial class Form_add_stock : Form
    {
        ModeloStock stock = new ModeloStock();
        public Form_add_stock()
        {
            InitializeComponent();
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {

            if (verificarNombre(txt_producto.Text) && verificarCantidad(txt_cantidad.Text)) { 
                
                if (!stock.addProducto(txt_producto.Text,Convert.ToInt32(txt_cantidad.Text),cmb_localizacion.SelectedItem.ToString()))
                {
                    MessageBox.Show("El producto ya existe en bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("El producto se agrego correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool verificarNombre(string nombre)
        {
            if (nombre.Length!=0)
            {
                return true;
            }
            else
            {
                lbl_errorNombreProducto.Visible = true;
                return false;
            }
        }

        private bool verificarCantidad(string cantidad)
        {
            if (cantidad.Length != 0)
            {
                return true;
            }
            else
            {
                lbl_errorCantidad.Visible = true;
                return false;
            }
        }

        private void llenarLocalizacion()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j=1; j <= 5; j++)
                {
                    cmb_localizacion.Items.Add((char)(65 + i) + ""+ j);
                }
            }

        }
        private void Form_add_stock_Load(object sender, EventArgs e)
        {
            llenarLocalizacion();
        }

        private void txt_producto_Enter(object sender, EventArgs e)
        {
            if (txt_producto.Text == "NOMBRE DEL PRODUCTO")
            {
                txt_producto.Text = "";
                txt_producto.ForeColor = Color.DimGray;
            }
        }

        private void txt_producto_Leave(object sender, EventArgs e)
        {
            if (txt_producto.Text == "")
            {
                txt_producto.Text = "NOMBRE DEL PRODUCTO";
                txt_producto.ForeColor = Color.DimGray;
            }
        }
    }
}
