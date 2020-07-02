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
    public partial class Form_show_users : Form
    {
        ModeloUsuario usuario = new ModeloUsuario();
        public Form_show_users()
        {
            InitializeComponent();
        }

        private void Form_show_users_Load(object sender, EventArgs e)
        {
            switch (UserLoginCache.Rol_empresa){
                case Positions.Empleado:
                    dataGridView1.DataSource = usuario.MostrarUsuarios(UserLoginCache.Id_usuario);
                    panel_completo.Visible = false;
                    panel_acortado.Visible = true;
                    break;
                default:
                    dataGridView1.DataSource = usuario.CompletaUsuarios(UserLoginCache.Id_usuario);
                    panel_completo.Visible = true;
                    panel_acortado.Visible = false;
                    
                    break;
            }
            dataGridView1.ClearSelection();

        }
        private void llenarDatos() {
            switch (UserLoginCache.Rol_empresa)
            {
                case Positions.Empleado:
                    txt_name_short.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                    txt_ap_short.Text = Text = dataGridView1.CurrentRow.Cells["APELLIDO"].Value.ToString();
                    txt_tele_short.Text = dataGridView1.CurrentRow.Cells["TELEFONO"].Value.ToString();
                    txt_correo_short.Text = dataGridView1.CurrentRow.Cells["CORREO ELECTRONICO"].Value.ToString();
                    break;
                default:
                    //Llenar datos
                    txt_id.Text = dataGridView1.CurrentRow.Cells["ID_PERSONA"].Value.ToString();
                    txt_name_detail.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                    txt_ap_detail.Text = Text = dataGridView1.CurrentRow.Cells["APELLIDO"].Value.ToString();
                    txt_tele_detail.Text = dataGridView1.CurrentRow.Cells["TELEFONO"].Value.ToString();
                    txt_correo_detail.Text = dataGridView1.CurrentRow.Cells["CORREO ELECTRONICO"].Value.ToString();
                    pick_fecha.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["FECHA NACIMIENTO"].Value.ToString());
                    txt_cargo.Text = dataGridView1.CurrentRow.Cells["CARGO"].Value.ToString();
                    txt_genero.Text = dataGridView1.CurrentRow.Cells["GENERO"].Value.ToString();
                    txt_pais.Text = dataGridView1.CurrentRow.Cells["PAIS DE ORIGEN"].Value.ToString();
                    break;
            }
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDatos();
        }
    }
}
