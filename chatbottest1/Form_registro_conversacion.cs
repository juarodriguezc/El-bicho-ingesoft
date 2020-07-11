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
    public partial class Form_registro_conversacion : Form
    {
        ModeloUsuario usuario = new ModeloUsuario();
        DataTable dt;
        public Form_registro_conversacion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void MostrarRegistroConversacion() {
            dt = usuario.MostrarRegistroConversacion();
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
        }

        private void Form_registro_conversacion_Load(object sender, EventArgs e)
        {
            MostrarRegistroConversacion();
            this.ActiveControl = dataGridView1;
        }

        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_correo_Enter(object sender, EventArgs e)
        {
            if (txt_correo.Text == "CORREO")
            {
                txt_correo.Text = "";
                txt_correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (txt_correo.Text == "")
            {
                txt_correo.Text = "CORREO";
                txt_correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_nombre_Enter(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "NOMBRE")
            {
                txt_nombre.Text = "";
                txt_nombre.ForeColor = Color.DimGray;
            }
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                txt_nombre.Text = "NOMBRE";
                txt_nombre.ForeColor = Color.DimGray;
            }
        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {
            if(txt_nombre.Text == "NOMBRE")
            {
                dt.DefaultView.RowFilter = ("Correo like '%" + txt_correo.Text + "%'");
                dataGridView1.DataSource = dt.DefaultView;
            }
            else
            {
                dt.DefaultView.RowFilter = ("Correo like '%" + txt_correo.Text + "%' AND Nombre like '%" + txt_nombre.Text + "%'");
                dataGridView1.DataSource = dt.DefaultView;
            }

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if(txt_correo.Text == "CORREO")
            {
                dt.DefaultView.RowFilter = ("Nombre like '%" + txt_nombre.Text + "%'");
                dataGridView1.DataSource = dt.DefaultView;
            }
            else
            {
                dt.DefaultView.RowFilter = ("Correo like '%" + txt_correo.Text + "%' AND Nombre like '%" + txt_nombre.Text + "%'");
                dataGridView1.DataSource = dt.DefaultView;
            }
        }
    }
}
