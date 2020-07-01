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
    public partial class Form_modificar_evento : Form
    {
        ModeloEventos eventos = new ModeloEventos();
        List<string[]> usuarios = new List<string[]>();
        List<string> id_personas = new List<string>();
        Image userImg = Image.FromFile("../../Images/user_icon.png");
        Image deleteImg = Image.FromFile("../../Images/delete_icon.png");
        int id_evento;
        public Form_modificar_evento()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_modificar_evento_Load(object sender, EventArgs e)
        {
            MostrarEventos();
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 60;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[3].Width = 80;
            pick_fecha_evento.MinDate = DateTime.Today.AddDays(1);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) {
                usuarios.Clear();
                id_personas.Clear();
                flowPanel_users.Controls.Clear();
                pick_fecha_evento.Enabled = true;
                txt_asunto.Enabled = true;
                participantes.Enabled = true;
                bt_adduser.Enabled = true;
                bt_save_event.Enabled = true;
                //Cargar los datos
                id_evento = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                txt_asunto.Text = dataGridView1.CurrentRow.Cells["Asunto del evento"].Value.ToString();
                pick_fecha_evento.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Fecha del evento"].Value.ToString());
                id_personas = eventos.ShowUsersEvent(id_evento, UserLoginCache.Id_usuario);
                llenarUsuarios();
                
            }
        }
        private void llenarUsuarios() {
            participantes.Items.Clear();
            usuarios = eventos.ShowUsersCargo();
            foreach (string[] a in usuarios)
            {
                if (a[1] != UserLoginCache.Id_Persona.ToString()) {
                    if(id_personas.Contains(a[1])){
                        crearUserMostrar(a[0] + " " + a[1]);
                    }else {
                        participantes.Items.Add(a[0] + " " + a[1]);
                    } 
                }
                    
            }
        }

        private void crearUserMostrar(string userToshow) {
            //Creacion del panel interno
            Panel panel_user = new Panel();
            //Creacion de la informacion del usuario
            Label user_info = new Label();
            //Creacion del boton para eliminar
            Button bt_delete = new Button();
            //Configuracion panel
            panel_user.Controls.Add(user_info);
            panel_user.BackColor = Color.FromArgb(27, 131, 185);
            panel_user.Size = new Size(flowPanel_users.ClientSize.Width - 30, 40);
            flowPanel_users.Controls.Add(panel_user);
            //Imgaen del usuario a mostrar
            PictureBox img = new PictureBox();
            img.Image = userImg;
            img.Size = new Size(30, 30);
            img.Location = new Point(10, 4);
            panel_user.Controls.Add(img);
            //Configuracion label
            user_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            user_info.AutoSize = true;
            user_info.MaximumSize = new Size(275, 25);
            user_info.Text = userToshow;
            user_info.Location = new Point(40, 10);
            //COnfiguracion boton
            bt_delete.Location = new Point(285, 0);
            bt_delete.Size = new Size(40, 40);
            bt_delete.BackColor = Color.FromArgb(64, 64, 64);
            bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_delete.FlatAppearance.BorderSize = 0;
            bt_delete.Click += delete_user;
            bt_delete.Image = deleteImg;

            panel_user.Controls.Add(bt_delete);
            //Organizacion dependiendo del tiempo de agregacion LIFO
            flowPanel_users.Controls.SetChildIndex(panel_user, 0);
        }
        public void delete_user(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string userRecuperado = btn.Parent.Controls[0].Text;
            string[] ids = userRecuperado.ToString().Split(' ');
            id_personas.Remove(ids[2]);
            participantes.Items.Add(userRecuperado);
            btn.Parent.Visible = false;
        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {
            if (participantes.SelectedItem != null)
            {
                string[] ids = participantes.SelectedItem.ToString().Split(' ');
                id_personas.Add(ids[2]);
                //Creacion del panel interno
                Panel panel_user = new Panel();
                //Creacion de la informacion del usuario
                Label user_info = new Label();
                //Creacion del boton para eliminar
                Button bt_delete = new Button();
                //Configuracion panel
                panel_user.Controls.Add(user_info);
                panel_user.BackColor = Color.FromArgb(27, 131, 185);
                panel_user.Size = new Size(flowPanel_users.ClientSize.Width - 30, 40);
                flowPanel_users.Controls.Add(panel_user);
                //Imgaen del usuario a mostrar
                PictureBox img = new PictureBox();
                img.Image = userImg;
                img.Size = new Size(30, 30);
                img.Location = new Point(10, 4);
                panel_user.Controls.Add(img);
                //Configuracion label
                user_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
                user_info.AutoSize = true;
                user_info.MaximumSize = new Size(275, 25);
                user_info.Text = participantes.SelectedItem.ToString();
                user_info.Location = new Point(40, 10);
                //COnfiguracion boton
                bt_delete.Location = new Point(285, 0);
                bt_delete.Size = new Size(40, 40);
                bt_delete.BackColor = Color.FromArgb(64, 64, 64);
                bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                bt_delete.FlatAppearance.BorderSize = 0;
                bt_delete.Click += delete_user;
                bt_delete.Image = deleteImg;

                panel_user.Controls.Add(bt_delete);
                //Organizacion dependiendo del tiempo de agregacion LIFO
                flowPanel_users.Controls.SetChildIndex(panel_user, 0);
                participantes.Items.Remove(participantes.SelectedItem.ToString());
            }
        }

        private void pick_fecha_evento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_save_event_Click(object sender, EventArgs e)
        {
            /*Console.WriteLine("---------9*--------: ");
            foreach (string a in id_personas) {
                Console.WriteLine("reg: " + a);
            }
            Console.WriteLine("----------**-------: ");*/

            lbl_campo_obligatorio.Visible = false;
            lbl_add_user_obligatorio.Visible = false;
            if (txt_asunto.Text.Length > 0 && id_personas.Count >= 1)
            {
                Console.WriteLine("ID_evento: " + id_evento);
                eventos.updateEvent(id_evento,UserLoginCache.Id_usuario, id_personas, txt_asunto.Text, pick_fecha_evento.Value);
                MessageBox.Show("El evento ha sido modificado", "Evento modificado", MessageBoxButtons.OK, MessageBoxIcon.Question);
                MostrarEventos();
                LimpiarCasillas();
            }
            else
            {
                if (txt_asunto.Text.Length == 0) lbl_campo_obligatorio.Visible = true;
                if (id_personas.Count < 2) lbl_add_user_obligatorio.Visible = true;
            }
        }
        private void MostrarEventos()
        {
            dataGridView1.DataSource = eventos.MostrarEventosPersona(UserLoginCache.Id_usuario);
            dataGridView1.ClearSelection();
        }
        private void LimpiarCasillas() {
            usuarios.Clear();
            id_personas.Clear();
            flowPanel_users.Controls.Clear();
            pick_fecha_evento.Enabled = false;
            txt_asunto.Text = string.Empty;
            txt_asunto.Enabled = false;
            participantes.Enabled = false;
            bt_adduser.Enabled = false;
            bt_save_event.Enabled = false;
        }

        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
