﻿using Business;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatbottest1
{
    public partial class Form_add_event : Form
    {
        ModeloEventos eventos = new ModeloEventos();
        List<string[]> usuarios;
        List<string> id_personas  = new List<string>();
        Image userImg = Image.FromFile("../../Images/plus_icon2.png");
        public Form_add_event()
        {
            InitializeComponent();
        }

        

        private void Form_add_event_Load(object sender, EventArgs e)
        {
            pick_fecha_evento.MinDate = DateTime.Now;
            llenarUsuarios();
            userImg = resizeImage(userImg , new Size(25, 25));


        }

        private void pick_fecha_nacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pick_fecha_evento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void llenarUsuarios()
        {
            usuarios = eventos.ShowUsersCargo();
            foreach (string[] a in usuarios)
            {
                participantes.Items.Add(a[0]+" "+a[1]);
            }
        }

        private void participantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_adduser.Enabled = true;
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
                panel_user.Size = new Size(flowPanel_users.ClientSize.Width - 10, 40);
                flowPanel_users.Controls.Add(panel_user);
                //Imgaen del usuario a mostrar
                PictureBox img = new PictureBox();
                img.Image = userImg;
                img.Size = new Size(30, 30);
                img.Location = new Point(10, 8);
                panel_user.Controls.Add(img);
                //Configuracion label
                user_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                //user_info.Text = participantes.SelectedItem.ToString();
                user_info.AutoSize = true;
                user_info.MaximumSize = new Size(310, 25);
                user_info.Text = participantes.SelectedItem.ToString();
                user_info.Location = new Point(50, 10);
                //COnfiguracion boton
                bt_delete.Location = new Point(flowPanel_users.ClientSize.Width - 50, 5);
                bt_delete.Size = new Size(30, 30);
                bt_delete.BackColor = Color.FromArgb(64, 64, 64);
                bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                bt_delete.FlatAppearance.BorderSize = 0;
                bt_delete.Click += delete_user;
                
                panel_user.Controls.Add(bt_delete);
                //Organizacion dependiendo del tiempo de agregacion LIFO
                flowPanel_users.Controls.SetChildIndex(panel_user, 0);  


                participantes.Items.Remove(participantes.SelectedItem.ToString());
            }
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
            private void backHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void flowPanel_users_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowPanel_users_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_add_event_Click(object sender, EventArgs e)
        {
            if (txt_asunto.Text.Length > 0) {
            
            }
        }
    }
}
