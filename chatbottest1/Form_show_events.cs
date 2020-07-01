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
    public partial class Form_show_events : Form
    {
        ModeloEventos eventos = new ModeloEventos();
        public Form_show_events()
        {
            InitializeComponent();
        }

        private void Form_show_events_Load(object sender, EventArgs e)
        {
            pick_fecha_inicio.Value = DateTime.Today;
            pick__fecha_fin.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            dataGridView1.DataSource = eventos.TotalEventos(UserLoginCache.Id_usuario);
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 100;
        }
        private void MostrarEventos(DateTime fecha_inicio, DateTime fecha_fin)
        {
            
            if (fecha_inicio > fecha_fin) {
                DateTime aux = fecha_inicio;
                fecha_inicio = fecha_fin;
                fecha_fin = aux;
            }
            fecha_fin = fecha_fin.AddDays(1);
            string fecha_in = fecha_inicio.ToString("yyyy-MM-dd");
            string fecha_f = fecha_fin.ToString("yyyy-MM-dd");
            Console.WriteLine("iNIT_DATE: "+ DateTime.Parse(fecha_in));
            Console.WriteLine("eND_DATE: " + DateTime.Parse(fecha_f));
            dataGridView1.DataSource = eventos.EventosDosFechas(UserLoginCache.Id_usuario,DateTime.Parse(fecha_in),DateTime.Parse(fecha_f));
            dataGridView1.ClearSelection();
        }

        private void bt_consultar_Click(object sender, EventArgs e)
        {
            MostrarEventos(pick_fecha_inicio.Value, pick__fecha_fin.Value);
        }

        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_todos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = eventos.TotalEventos(UserLoginCache.Id_usuario);
        }
    }
}
