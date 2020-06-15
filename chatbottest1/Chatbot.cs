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
            Image img;
            img = Image.FromFile("../../Images/icon3.png");
            
            bt_sendMessage.Image = img;
            
            var date = DateTime.Now;
            sesion = new ModeloSesion();
            sesion.createSesion(UserLoginCache.Id_usuario, date);

            string day = "AM";
            string minute = date.Minute.ToString();
            string hour = (date.Hour%12).ToString();
            if (date.Minute < 10) minute = "0" + minute;
            if (date.Hour % 12 < 10) {
                hour = "0" + hour;
            }
            if (date.Hour > 11) day = "PM";
            lbl_hour.Text = (date.Day.ToString()) + "/" + (date.Month.ToString()) + "/" 
                + (date.Year.ToString()) + "     " +  hour + ":" + minute +" "+day;
            ActiveControl = textBox1;
            
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
                                Console.WriteLine("Bot said: " + rta_fin);

                                if (realizarAccion(message, rta_fin)) { }
                                else { add_respuesta("No tienes acceso a esta función"); }
                                 
                            }));
                        }
                    }
                }
            }

        }

        public Boolean realizarAccion(String accion, String rta_fin)
        {
            string[] multiple_lines = rta_fin.Split('*');
            foreach (string a in multiple_lines)
            {
                add_respuesta(a);  
            }
            wait(2000);//Simular tiempo espera
            switch (accion)
            {
                case "Add_user":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador)
                    {
                        Form_add_user add_user = new Form_add_user();
                        add_user.Show();
                        sesion.create_reg_function(2, SesionCache.Id_acceso);
                        return true;
                    }
                    return false;
                case "Edit_user":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador)
                    {
                        Form_Edit_user edit_user = new Form_Edit_user();
                        edit_user.Show();
                        sesion.create_reg_function(3, SesionCache.Id_acceso);
                        return true;
                    }
                    return false;
                case "Reg_conversacion":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador)
                    {
                        Form_registro_conversacion reg_conv = new Form_registro_conversacion();
                        sesion.create_reg_function(8, SesionCache.Id_acceso);
                        reg_conv.Show();

                        return true;
                    }
                    return false;
                case "El bicho siuu":
                    sesion.create_reg_function(80, SesionCache.Id_acceso);
                    add_image(7);
                    return true;
                default:
                    return true;
            }
        }




        public void add_mensaje(string mensaje) {
            label7.Text = mensaje;
            string mes2 = mensaje;
            for (int a = 25; label7.Width+20 > 350; a -= 1)
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
            }
            mensaje = mes2;
            Label msg = new Label();
            msg.Text = mensaje;
            msg.BackColor = Color.FromArgb(27, 131, 185);
            msg.AutoSize = true;
            msg.Padding = new Padding(10, 10, 10, 10);
            msg.ForeColor = Color.White;
            msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            msg.Location = new Point(panel_chat.Width - label7.Width - 100, panel_chat.Height + 20);
            panel_chat.Controls.Add(msg);
        }
        public void add_respuesta(string mensaje) {
            panel_chat.VerticalScroll.Value = panel_chat.VerticalScroll.Maximum; //Forzar el scroll bajo
            label7.Text = mensaje;
            string mes2 = mensaje;
            for (int a = 25; label7.Width + 20 > 350; a -= 1)
            {
                if (a == 0)
                {
                    for (int b = 25; label7.Width + 20 > 350 && b > 0 ; b -= 1)
                    {
                        mes2 = ForcedSplit(mensaje, b);
                        label7.Text = mes2;
                    }
                    break;
                }
                mes2 = SplitBySpace(mensaje, a);
                label7.Text = mes2;
            }
            mensaje = mes2;
            Label msgrta = new Label();
            msgrta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            msgrta.Text = mensaje;
            msgrta.AutoSize = true;
            msgrta.Padding = new Padding(10, 10, 10, 10);
            msgrta.BackColor = Color.FromArgb(225, 225, 225);
            msgrta.Location = new Point(50, panel_chat.Height + 20);
            panel_chat.Controls.Add(msgrta);
        }

        public void add_image(int tipo_imagen) {
            Label msg = new Label();
            Image img;
            switch (tipo_imagen) {
                case 7:
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
        public string SplitBySpace(string str, int chunkSize)
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
        }

        public string ForcedSplit(string str, int chunkSize)
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
        }

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
            bt_sendMessage.PerformClick();
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
    }
}
