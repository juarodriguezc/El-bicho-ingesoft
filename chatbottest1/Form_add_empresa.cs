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
    public partial class Form_add_empresa : Form
    {
        ModeloEmpresa empresa = new ModeloEmpresa();
        public Form_add_empresa()
        {
            InitializeComponent();
        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {
            error_nombre.Visible = false;
            error_telefono.Visible = false;
            error_direccion.Visible = false;
            error_nit.Visible = false;
            if (txt_nombre.Text.Length > 0 && txt_telefono.Text.Length > 0 && txt_nit.Text.Length > 0 && txt_direccion.Text.Length > 0
                && txt_nombre.Text != "NOMBRE EMPRESA" && txt_direccion.Text != "DIRECCIÓN" && txt_nit.Text != "NIT" && txt_telefono.Text != "TELÉFONO DE CONTACTO")
            {
                if (!empresa.add_empresa(txt_nombre.Text, txt_direccion.Text, txt_nit.Text, txt_telefono.Text))
                {
                    MessageBox.Show("El NIT o teléfono ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error_nit.Visible = true;
                    error_telefono.Visible = true;
                }
                else
                {
                    MessageBox.Show("La empresa ha sido registrada", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Completa la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txt_nombre.Text.Length == 0 || txt_nombre.Text == "NOMBRE EMPRESA") error_nombre.Visible = true;
                if (txt_telefono.Text.Length == 0 || txt_telefono.Text == "TELÉFONO DE CONTACTO") error_telefono.Visible = true;
                if (txt_nit.Text.Length == 0 || txt_nit.Text == "NIT") error_nit.Visible = true;
                if (txt_direccion.Text.Length == 0 || txt_direccion.Text == "DIRECCIÓN") error_direccion.Visible = true;
            
            }
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nombre_Enter(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "NOMBRE EMPRESA")
            {
                txt_nombre.Text = "";
                txt_nombre.ForeColor = Color.DimGray;
            }
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                txt_nombre.Text = "NOMBRE EMPRESA";
                txt_nombre.ForeColor = Color.DimGray;
            }
        }

        private void txt_direccion_Enter(object sender, EventArgs e)
        {
            if (txt_direccion.Text == "DIRECCIÓN")
            {
                txt_direccion.Text = "";
                txt_direccion.ForeColor = Color.DimGray;
            }
        }

        private void txt_direccion_Leave(object sender, EventArgs e)
        {
            if (txt_direccion.Text == "")
            {
                txt_direccion.Text = "DIRECCIÓN";
                txt_direccion.ForeColor = Color.DimGray;
            }
        }

        private void txt_nit_Enter(object sender, EventArgs e)
        {
            if (txt_nit.Text == "NIT")
            {
                txt_nit.Text = "";
                txt_nit.ForeColor = Color.DimGray;
            }
        }

        private void txt_nit_Leave(object sender, EventArgs e)
        {
            if (txt_nit.Text == "")
            {
                txt_nit.Text = "NIT";
                txt_nit.ForeColor = Color.DimGray;
            }
        }

        private void txt_telefono_Enter(object sender, EventArgs e)
        {
            if (txt_telefono.Text == "TELÉFONO DE CONTACTO")
            {
                txt_telefono.Text = "";
                txt_telefono.ForeColor = Color.DimGray;
            }
        }

        private void txt_telefono_Leave(object sender, EventArgs e)
        {
            if (txt_telefono.Text == "")
            {
                txt_telefono.Text = "TELÉFONO DE CONTACTO";
                txt_telefono.ForeColor = Color.DimGray;
            }
        }
    }
}
