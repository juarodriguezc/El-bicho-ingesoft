using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Business;

namespace chatbottest1.UserControls
{
    public partial class Calendario : UserControl
    {
        List<Label> Eventos_dia = new List<Label>();
        ModeloUsuario userLog = new ModeloUsuario();
        ModeloEventos eventos = new ModeloEventos();

        int position = 10;
        public static DateTime dateInfoProgram;

        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            lbl_hora_actual.Text = DateTime.Now.ToString("hh:mm:ss");
            lblampm.Text = DateTime.Now.ToString("tt");
            lbl_fecha_actual.Text = DateTime.Now.ToLongDateString();

            panel_eventos_dia.Controls.Clear();
            string start_day = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine(DateTime.Parse(start_day));
            List<string> eventos_dia = eventos.ConsultarEventosDia(UserLoginCache.Id_usuario, DateTime.Parse( start_day ));
            if (eventos_dia.Any())
            {
                foreach (string a in eventos_dia)
                {
                    Console.WriteLine("name: " + a);
                    add_eventos_dia_panel(a);
                }
            }
            else
            {
                panel_eventos_dia.Controls.Add(lbl_no_eventos);
            }
            Label inferior = new Label();
            inferior.Location = new Point(20, position - 20);
            panel_eventos_dia.Controls.Add(inferior);

            //Calcular el próximo evento

            string[] prox = eventos.ConsultarProxEvento(UserLoginCache.Id_usuario);
            if (prox != null && prox.Length > 0)
            {
                DateTime fecha_proxima = DateTime.Parse(prox[0]);
                lbl_asunto_proximo.Text = prox[2];
                lbl_fecha_proximo.Text = fecha_proxima.ToLongDateString();
                lbl_hora_proxima.Text = "a las "+ fecha_proxima.ToShortTimeString();
                lbl_no_prox.Visible = false;
            }
            else 
            {
                lbl_asunto_proximo.Visible = false;
                lbl_fecha_proximo.Visible = false;
                lbl_hora_proxima.Visible = false;
                lbl_no_prox.Visible = true;
            }
            



        }
        private void bt_volver_chatbot_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_menu_principal.Instance.getButton_chatbot().PerformClick();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lbl_hora_actual.Text = DateTime.Now.ToString("hh:mm:ss");
            lblampm.Text = DateTime.Now.ToString("tt");
            lbl_fecha_actual.Text = DateTime.Now.ToLongDateString();
        }

        private void calendarioPersonalizado1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lbl_current_day.Text = calendar_events.SelectionRange.Start.ToString("dddd dd") + " de " + 
                calendar_events.SelectionRange.Start.ToString("MMMMMMMMMMM");
            panel_eventos_dia.Controls.Clear();
            List<string> eventos_dia = eventos.ConsultarEventosDia(UserLoginCache.Id_usuario, calendar_events.SelectionRange.Start);
            if (eventos_dia.Any()) {
                foreach (string a in eventos_dia)
                {
                    Console.WriteLine("name: " + a);
                    add_eventos_dia_panel(a);
                }
            }
            else
            {
                panel_eventos_dia.Controls.Add(lbl_no_eventos); 
            }
            Label inferior = new Label();
            inferior.Location = new Point(20, position-20);
            position = 10;
            panel_eventos_dia.Controls.Add(inferior);
        }

        private void bt_add_event_Click(object sender, EventArgs e)
        {
            eventos.ConsultarEventosDia(UserLoginCache.Id_usuario, calendar_events.SelectionRange.Start);

        }

        public void add_eventos_dia_panel(string evento)
        { 
            Console.WriteLine(panel_eventos_dia.Height);
            Label b_lateral = new Label();
            b_lateral.Text = "";
            b_lateral.AutoSize = true;
            b_lateral.Padding = new Padding(10, 10, 0, 10);
            b_lateral.BackColor = Color.FromArgb(27, 131, 185);
            b_lateral.Location = new Point(0, position);
            Label evento_panel = new Label();
            evento_panel.AutoSize = false;
            evento_panel.Size = new Size(250, 20);
            evento_panel.Text = evento;
            //evento_panel.Text = evento;
            //evento_panel.Location = new Point(20, panel_eventos_dia.Height - 10);
            evento_panel.Location = new Point(20, position);
            panel_eventos_dia.Controls.Add(b_lateral);
            panel_eventos_dia.Controls.Add(evento_panel);
            position += 50;
        }

        private void panel_eventos_dia_ControlAdded(object sender, ControlEventArgs e)
        {
           
        }

        private void lbl_calendario_Click(object sender, EventArgs e)
        {

        }

        private void BtnInfoProgramDate_Click(object sender, EventArgs e)
        {

            dateInfoProgram = this.calendar_events.SelectionStart;

            string mensaje = "¿El programa del que deseas obtener información es de la fecha " + dateInfoProgram.ToString("d") + "?";
            string titulo = "Informacion programa";

            DialogResult d = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (d == DialogResult.Yes)
            {
                Form_InfoPrograma_date formDate = new Form_InfoPrograma_date();
                formDate.Show();
            }
        }
    }
}
