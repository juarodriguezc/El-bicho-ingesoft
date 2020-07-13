using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Bot.Connector.DirectLine;
using Business;
using Common.Cache;
using System.Security.Cryptography.X509Certificates;

namespace chatbottest1
{
    public partial class Chatbot : UserControl
    {
        List<Label> Mensajes = new List<Label>();
        ModeloSesion sesion;
        private static String directLineSecret = ConfigurationManager.AppSettings["directLineSecret"];
        private static string botId = ConfigurationManager.AppSettings["BotId"];
        private static string id = "default-user";
        private static String fromUser = "User";
        private Conversation conversation;
        DirectLineClient Client = null;

        public Chatbot()
        {
            InitializeComponent();
            InitClient();
            Activity userMessage = new Activity
            {
                From = new ChannelAccount(id, fromUser),
                Text = "Inicializar_chatbot",
                Type = ActivityTypes.Message,
                TextFormat = "plain"
            };
            Client.Conversations.PostActivityAsync(this.conversation.ConversationId, userMessage);
        }
        private void InitClient()
        {
            Client = new DirectLineClient(directLineSecret);
            conversation = Client.Conversations.StartConversation();
            new System.Threading.Thread(async () => await ReadBotMessageAsync(Client, conversation.ConversationId)).Start();


        }
        private void Chatbot_Load(object sender, EventArgs e)
        {
            
            var date = DateTime.Now;
            sesion = new ModeloSesion();
            sesion.createSesion(UserLoginCache.Id_usuario, date);
            lbl_hour.Text = date.ToString("dd/MM/yyyy       hh:mm tt");
            ActiveControl = bt_sendMessage;
            
        }


        private async Task ReadBotMessageAsync(DirectLineClient client, string conversationId)
        {
            String watermark = null;

            while (true)
            {
                var activitySet = await client.Conversations.GetActivitiesAsync(conversationId, watermark);
                watermark = activitySet.Watermark;

                var activities = from x in activitySet.Activities where x.From.Id == botId select x;

                foreach (Activity activity in activities)
                {
                    if (activity.Text != null)
                    {
                        String message = activity.Text;
                        if (InvokeRequired)
                        {
                            BeginInvoke(new MethodInvoker(delegate {
                                ModeloRespuesta rta = new ModeloRespuesta();
                                string rta_fin = rta.GenRespuesta(message);
                                Console.WriteLine("Bot said: "+message+ " Shown as " + rta_fin);

                                if (!realizarAccion(message, rta_fin)) add_respuesta("No tienes acceso a esta función"); 
                                 
                            }));
                        }
                    }
                }
            }

        }

        public Boolean realizarAccion(String accion, String rta_fin)
        {
            switch (accion)
            {
                case "Hello and welcome!":
                    procesarRespuesta(rta_fin);
                    return true;
                case "start_chatbot":
                    add_respuesta("Hola, Bienvenido al Chatbot Empresarial YMCA"); //Mensaje introducción
                    if (!verificarCumple()) {
                        if (!proximoEvento()) {
                            add_respuesta("¿Qué puedo hacer por ti?"); //Mensaje de pregunta
                        }
                    }
                    return true;
                case "Add_user":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador)
                    {
                        procesarRespuesta(rta_fin);
                        Form_add_user add_user = new Form_add_user();
                        add_user.Show();
                        Console.WriteLine("Sesion: " + SesionCache.Id_acceso);
                        sesion.create_reg_function(2, SesionCache.Id_acceso);
                        return true;
                    }
                    return false;
                case "Edit_user":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador)
                    {
                        procesarRespuesta(rta_fin);
                        Form_Edit_user edit_user = new Form_Edit_user();
                        edit_user.Show();
                        sesion.create_reg_function(3, SesionCache.Id_acceso);
                        return true;
                    }
                    return false;
                case "Add_program":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador || UserLoginCache.Rol_empresa == Positions.Jefe_area)
                    {
                        procesarRespuesta(rta_fin);
                        Form_add_program addProgram = new Form_add_program();
                        addProgram.Show();
                        sesion.create_reg_function(13, SesionCache.Id_acceso);
                        return true;
                    }
                    return false;
                //Codigo Ivan
                case "Change_programInfo":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador || UserLoginCache.Rol_empresa == Positions.Jefe_area)
                    {
                        procesarRespuesta(rta_fin);
                        Form_EditProgramInfo edtProgram = new Form_EditProgramInfo();
                        edtProgram.Show();
                        sesion.create_reg_function(25, SesionCache.Id_acceso);
                        return true;
                    }
                    return false;
                //----
                case "Show_company":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador || UserLoginCache.Rol_empresa == Positions.Jefe_area || UserLoginCache.Rol_empresa == Positions.Empleado)
                    {
                        procesarRespuesta(rta_fin);
                        Form_ListComp listComp = new Form_ListComp();
                        listComp.Show();
                        sesion.create_reg_function(11, SesionCache.Id_acceso);
                        return true;
                    }
                    return false;
                case "Show_personas_info":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador || UserLoginCache.Rol_empresa == Positions.Jefe_area)
                    {
                        procesarRespuesta(rta_fin);
                        Form_Info_Personas info_personas = new Form_Info_Personas();
                        info_personas.Show();
                        Console.WriteLine("Sesion: " + SesionCache.Id_acceso);
                        sesion.create_reg_function(12, SesionCache.Id_acceso);
                        return true;
                    }
                    return false;
                case "User_request":
                    procesarRespuesta(rta_fin);
                    Form_UserRequest UserReq = new Form_UserRequest();
                    UserReq.Show();
                    Console.WriteLine("Sesion: " + SesionCache.Id_acceso);
                    sesion.create_reg_function(10, SesionCache.Id_acceso);
                    return true;
                case "Info_specific_program":
                    procesarRespuesta(rta_fin);
                    Form_InfoSpecificProgram infoSpc = new Form_InfoSpecificProgram();
                    infoSpc.Show();
                    Console.WriteLine("Sesion: " + SesionCache.Id_acceso);
                    sesion.create_reg_function(9, SesionCache.Id_acceso);
                    return true;
                case "Reg_conversacion":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador)
                    {
                        procesarRespuesta(rta_fin);
                        Form_registro_conversacion reg_conv = new Form_registro_conversacion();
                        sesion.create_reg_function(8, SesionCache.Id_acceso);
                        reg_conv.Show();
                        return true;
                    }
                    return false;
                case "Show_calendar":
                    procesarRespuesta(rta_fin);
                    Form_menu_principal.Instance.getButton_calendario().PerformClick();        
                    return true;
                case "Show_stock":
                    procesarRespuesta(rta_fin);
                    Form_show_stock show_stock = new Form_show_stock();
                    sesion.create_reg_function(17, SesionCache.Id_acceso);
                    show_stock.Show();
                    return true;
                case "Add_event":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador || UserLoginCache.Rol_empresa == Positions.Jefe_area) {
                        procesarRespuesta(rta_fin);
                        Form_add_event add_event = new Form_add_event();
                        sesion.create_reg_function(19, SesionCache.Id_acceso);
                        add_event.Show();
                        return true;
                    }
                    return false;
                 case "Add_volunteer":
                    procesarRespuesta(rta_fin);
                    Form_add_volunteer addVolunter = new Form_add_volunteer();
                    addVolunter.changeTipoVoluntario();
                    addVolunter.Show();
                    Console.WriteLine("Sesion: " + SesionCache.Id_acceso);
                    sesion.create_reg_function(16, SesionCache.Id_acceso);
                    return true;
                case "Add_person":
                    procesarRespuesta(rta_fin);
                    Form_add_volunteer addPerson = new Form_add_volunteer();
                    
                    addPerson.Show();
                    Console.WriteLine("Sesion: " + SesionCache.Id_acceso);
                    sesion.create_reg_function(27, SesionCache.Id_acceso);
                    return true;
                case "Pick_stock":
                    procesarRespuesta(rta_fin);
                    Form_RealizarMovimiento movimiento = new Form_RealizarMovimiento();
                    movimiento.Show();
                    sesion.create_reg_function(21, SesionCache.Id_acceso);
                    return true;
                case "Add_stock":
                    procesarRespuesta(rta_fin);
                    Form_add_stock addStock = new Form_add_stock();
                    addStock.Show();
                    sesion.create_reg_function(22, SesionCache.Id_acceso);
                    return true;
                case "Modificar_evento":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador || UserLoginCache.Rol_empresa == Positions.Jefe_area)
                    {
                        procesarRespuesta(rta_fin);
                        Form_modificar_evento modificar_evento = new Form_modificar_evento();
                        sesion.create_reg_function(23, SesionCache.Id_acceso);
                        modificar_evento.Show();
                        return true;
                    }
                    return false;
                case "Show_events":
                    procesarRespuesta(rta_fin);
                    Form_show_events show_events = new Form_show_events();
                    show_events.Show();
                    sesion.create_reg_function(24, SesionCache.Id_acceso);
                    return true;
                case "El bicho siuu":
                    procesarRespuesta(rta_fin);
                    sesion.create_reg_function(80, SesionCache.Id_acceso);
                    add_image(7);
                    return true;
                case "Search_program_by_person":
                    procesarRespuesta(rta_fin);
                    Form_show_program_by_person searchPersonProgram = new Form_show_program_by_person();
                    searchPersonProgram.Show();
                    Console.WriteLine("Sesion: " + SesionCache.Id_acceso);
                    sesion.create_reg_function(15, SesionCache.Id_acceso);
                    return true;
                case "Show_users":
                    procesarRespuesta(rta_fin);
                    Form_show_users show_users= new Form_show_users();
                    show_users.Show();
                    sesion.create_reg_function(5, SesionCache.Id_acceso);
                    return true;
                case "Add_volunteer_program":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador || UserLoginCache.Rol_empresa == Positions.Jefe_area)
                    {
                        procesarRespuesta(rta_fin);
                        Form_AddPersonaPrograma personaPrograma = new Form_AddPersonaPrograma();
                        sesion.create_reg_function(26, SesionCache.Id_acceso);
                        personaPrograma.Show();
                        return true;
                    }
                    return false;
                case "Program_fecha":
                    procesarRespuesta(rta_fin);
                    Form_InfoPrograma_date formDate = new Form_InfoPrograma_date(DateTime.Today);
                    formDate.Show();
                    sesion.create_reg_function(29, SesionCache.Id_acceso);
                    return true;
                case "Search_foreign_volunteers":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador || UserLoginCache.Rol_empresa == Positions.Jefe_area)
                    {
                        procesarRespuesta(rta_fin);
                        Form_show_foreign_volunteers voluntariosForaneos= new Form_show_foreign_volunteers();
                        sesion.create_reg_function(14, SesionCache.Id_acceso);
                        voluntariosForaneos.Show();
                        return true;
                    }
                    return false;
                case "Add_empresa":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador || UserLoginCache.Rol_empresa == Positions.Jefe_area)
                    {
                        procesarRespuesta(rta_fin);
                        Form_add_empresa addEmpresa = new Form_add_empresa();
                        sesion.create_reg_function(29, SesionCache.Id_acceso);
                        addEmpresa.Show();
                        return true;
                    }
                    return false;
                case "Help":
                    add_respuesta("Para usar el chatbot escribe en la barra de comandos lo que desees realizar." +
                         System.Environment.NewLine + System.Environment.NewLine+ " Para más información haz clic en el botón de ayuda.");
                    return true;
                default:
                    procesarRespuesta(rta_fin);
                    return true;
            }
        }
        private bool verificarCumple()
        {
            ModeloUsuario user = new ModeloUsuario();
            DateTime nacimiento = user.getNacimiento(UserLoginCache.Id_Persona);
            string dia_mes_user = nacimiento.ToString("dd - MM");
            string dia_mes_actual = DateTime.Today.ToString("dd - MM");
            if (dia_mes_user == dia_mes_actual) 
            {
                add_respuesta("Desde el grupo de YMCA te deseamos un Feliz cumpleaños! :D");
                add_image(1); //Número para cumpleaños
                return true;
            }
            return false;
        }
        private bool proximoEvento() {
            ModeloEventos eventos = new ModeloEventos();
            string[] prox = eventos.ConsultarProxEvento(UserLoginCache.Id_usuario);
            if (prox != null && prox.Length > 0)
            {
                DateTime evento = DateTime.Parse(prox[0]);
                Console.WriteLine(evento);
                //Solo mostrar los eventos próximos a 8 días
                if ((evento - DateTime.Now).TotalDays < 8) { 
                    string dia_mostrar;
                    if (IsTheSameDay(DateTime.Today, evento))
                    {
                        dia_mostrar = "de hoy";
                    }
                    else
                    {
                        dia_mostrar = evento.ToString("dd 'de' MMMM 'del' yyyy");
                    }
                    string prox_event = prox[2];
                    add_respuesta("Tienes el evento: " + System.Environment.NewLine+" \" "+prox_event + " \" "+System.Environment.NewLine +
                        " programado el día " + dia_mostrar + System.Environment.NewLine + System.Environment.NewLine + "No olvides asistir! ;)");
                    return true;
                }
            }
            return false;
        }
        private bool IsTheSameDay(DateTime date1, DateTime date2)
        {
            return (date1.Year == date2.Year && date1.DayOfYear == date2.DayOfYear);
        }
        public void procesarRespuesta(String rta_fin) {
            string[] multiple_lines = rta_fin.Split('*');
            foreach (string a in multiple_lines)
            {
                add_respuesta(a);
            }
            wait(1500);//Simular tiempo espera
        }
        public void add_mensaje(string mensaje) {
            /*for (int a = 25; label7.Width+20 > 350; a -= 1)
            {
                if (a == 0) {
                    for (int b = 25; label7.Width + 20 > 350 && b > 0; b -= 1)
                    {
                        mes2 = ForcedSplit(mensaje, b);
                        label7.Text = mes2;
                    }
                    break;
                }
                mes2 = SplitBySpace(mensaje, a);
                label7.Text = mes2;
            }*/ //Algoritmo anterior de acomodación de texto - Obsoleto
            label7.Text = mensaje; //Label de respaldo con valor actual
            label7.Padding = new Padding(10, 10, 10, 10);
            label7.AutoSize = true;
            label7.MaximumSize = new Size(350, 1000);
            Label msg = new Label();
            msg.Text = mensaje;
            msg.BackColor = Color.FromArgb(27, 131, 185);
            msg.AutoSize = true;
            msg.Padding = new Padding(10, 10, 10, 10);
            msg.MaximumSize = new Size(350, 1000);
            msg.ForeColor = Color.White;
            msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            msg.Location = new Point(panel_chat.Width - label7.Width - 100, panel_chat.Height + 20);
            panel_chat.Controls.Add(msg);
        }
        public void add_respuesta(string mensaje) {
            panel_chat.VerticalScroll.Value = panel_chat.VerticalScroll.Maximum; //Forzar el scroll bajo
            label7.Text = mensaje;
            Label msgrta = new Label();
            msgrta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            msgrta.Text = mensaje;
            msgrta.AutoSize = true;
            msgrta.Padding = new Padding(10, 10, 10, 10);
            msgrta.MaximumSize = new Size(350, 1000);
            msgrta.BackColor = Color.FromArgb(235, 235, 235);
            msgrta.Location = new Point(50, panel_chat.Height + 20);
            panel_chat.Controls.Add(msgrta);
        }

        public void add_image(int tipo_imagen) {
            Label msg = new Label();
            Image img;
            switch (tipo_imagen) {
                case 1: //cumpleaños
                    img = Image.FromFile("../../Images/cumple_test2.jpg");
                    break;
                case 7: //Ay mi madre el bichoooooooooooooooo
                    img = Image.FromFile("../../Images/creeper.png");
                    break;
                default:
                    img = Image.FromFile("../../Images/creeper.png");
                    break;
            }

            msg.BackColor = Color.FromArgb(225, 225, 225);
            img = resizeImage(img, new Size(300, 300));
            msg.Size = new Size(300, 300);
            msg.Location = new Point(50, panel_chat.Height + 20);
            msg.Image = img;
            msg.ImageAlign = ContentAlignment.MiddleCenter;
            msg.Padding = new Padding(10, 10, 10, 10);
            panel_chat.Controls.Add(msg);
            wait(1000);
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "Escribe lo que deseas hacer")
            {
                String input = textBox1.Text.Trim();
                textBox1.Clear();
                if (input.Length > 0)
                {
                    Activity userMessage = new Activity
                    {
                        From = new ChannelAccount(id, fromUser),
                        Text = input,
                        Type = ActivityTypes.Message,
                        TextFormat = "plain"
                    };
                    add_mensaje(input);
                    Client.Conversations.PostActivityAsync(this.conversation.ConversationId, userMessage);

                }
            }
        }
        /*public string SplitBySpace(string str, int chunkSize) //Obsoleto
        {
            string resul = "";
            for (int a = 0; a < str.Length; a++)
            {
                if (a != 0 && a % chunkSize == 0 && str[a] == ' ')
                {
                    resul += "\n";
                }
                resul += str[a];
            }
            return resul;
        }*/

        /*public string ForcedSplit(string str, int chunkSize)  //Obsoleto
        {
            string resul = "";
            for (int a = 0; a < str.Length; a++)
            {
                if (a != 0 && a % chunkSize == 0)
                {
                    resul += "\n";
                }
                resul += str[a];
            }
            return resul;
        }*/

        private void Panel_chat_ControlAdded(object sender, ControlEventArgs e)
        {
            panel_chat.HorizontalScroll.Maximum = 0;
            panel_chat.AutoScroll = false;
            panel_chat.VerticalScroll.Visible = false;
            panel_chat.AutoScroll = true;
            panel_chat.ScrollControlIntoView(e.Control);

        }

        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void panel_chat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_hour_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Escribe lo que deseas hacer")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel_chat.VerticalScroll.Value = panel_chat.VerticalScroll.Maximum;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_sendMessage.PerformClick();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_chat_bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_sendmessage_ellipse_Click(object sender, EventArgs e)
        {
            bt_sendmessage_ellipse.BackColor = Color.FromArgb(27, 131, 185);
            bt_sendMessage.PerformClick();
            ActiveControl = textBox1;
        }

        private void bt_sendmessage_ellipse_MouseDown(object sender, MouseEventArgs e)
        {
            bt_sendmessage_ellipse.BackColor = Color.FromArgb(37, 141, 195);
        }

        private void bt_sendmessage_ellipse_MouseLeave(object sender, EventArgs e)
        {
            bt_sendmessage_ellipse.BackColor = Color.FromArgb(27, 131, 185);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_help2_Click(object sender, EventArgs e)
        {
            Form_menu_principal.Instance.getButton_ayuda().PerformClick();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Escribe lo que deseas hacer";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
