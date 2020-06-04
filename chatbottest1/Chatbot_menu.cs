using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Microsoft.Bot.Connector.DirectLine;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Configuration;
using System.Drawing.Text;
using Common.Cache;
using Business;
using System.Reflection;

namespace chatbottest1
{

    public partial class Chatbot_menu : Form
    {
        ModeloSesion sesion;

        private void Chatbot_menu_Load(object sender, EventArgs e)
        {
            loadUserdata();
            sesion = new ModeloSesion();
            sesion.createSesion(UserLoginCache.Id_usuario, DateTime.Now);
        }


        //Carga de datos

        private void loadUserdata() {
            lblName.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
            lblCargo.Text = UserLoginCache.Rol_empresa ;
        }
       



    private static String directLineSecret = ConfigurationManager.AppSettings["directLineSecret"];
        private static string botId = ConfigurationManager.AppSettings["BotId"];
        private static string id = "default-user";
        private static String fromUser = "User";
        private Conversation conversation;
        DirectLineClient Client = null;




        public Chatbot_menu()
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


      

        private void InitClient() {
            Client = new DirectLineClient(directLineSecret);
            conversation = Client.Conversations.StartConversation();
            new System.Threading.Thread(async () => await ReadBotMessageAsync(Client, conversation.ConversationId)).Start();

            
        }



        private async Task ReadBotMessageAsync(DirectLineClient client, string conversationId)
        {
            String watermark = null;

            while (true) {
                var activitySet = await client.Conversations.GetActivitiesAsync(conversationId,watermark);
                watermark = activitySet.Watermark;

                var activities = from x in activitySet.Activities where x.From.Id == botId select x;

                foreach (Activity activity in activities) {
                    if (activity.Text != null) {
                        String message = activity.Text;
                        if (InvokeRequired)
                        {
                                BeginInvoke(new MethodInvoker(delegate {
                                lbl_func.Text = message;
                                    /*ModeloRespuesta rta = new ModeloRespuesta();
                                    string rta_fin = rta.generarRespuesta(message);
                                    string[] multiple_lines = rta_fin.Split('*');
                                    if (realizarAccion(message))
                                    {
                                        foreach (string a in multiple_lines)
                                        {
                                            textBox.AppendText("Bot said: " + a + "\r\n");
                                        }
                                    }
                                    else {
                                        textBox.AppendText("Bot said: " + "No tienes acceso a esta función" + "\r\n");
                                    }

                                     textBox.AppendText("Bot said: " + "No tienes acceso a esta función" + "\r\n");*/
                                   
                                    if (realizarAccion(message))
                                    {
                                       textBox.AppendText("Bot said: " + message + "\r\n");
                                      
                                    }
                                    else
                                    {
                                        textBox.AppendText("Bot said: " + "No tienes acceso a esta función" + "\r\n");
                                    }

                                    textBox.AppendText("Bot said: " + "No tienes acceso a esta función" + "\r\n");

                                }));
                        }
                    }
                }
            }

        }

        private async void bt_send_Click(object sender, EventArgs e)
        {
            String input = textsend.Text.Trim();
            textsend.Clear();
            if (input.Length > 0) {
                Activity userMessage = new Activity
                {
                    From = new ChannelAccount(id, fromUser),
                    Text = input,
                    Type = ActivityTypes.Message,
                    TextFormat = "plain"
                };
                textBox.AppendText("\r\n"+"                                                               You said: " + input + "\r\n"+ "\r\n");
                await Client.Conversations.PostActivityAsync(this.conversation.ConversationId, userMessage);
            }
            
        }

        public Boolean realizarAccion(String accion) {
            switch (accion) {
                case "Add_user":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador) {
                        Form_add_user add_user = new Form_add_user();
                        add_user.Show();
                        sesion.create_reg_function(2, UserLoginCache.Id_usuario, SesionCache.Id_acceso);
                        return true;
                    }
                    return false;
                case "Edit_user":
                    if (UserLoginCache.Rol_empresa == Positions.Administrador) {
                        Form_Edit_user edit_user = new Form_Edit_user();
                        edit_user.Show();
                        sesion.create_reg_function(3, UserLoginCache.Id_usuario, SesionCache.Id_acceso);
                        return true;
                    }
                    return false;
                default:
                    return true;
            }
        }
        



        private void textsend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                bt_send.PerformClick();
            }
        }





        private void textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textsend_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        


        private void bt_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
            }
        }

        private void Chatbot_menu_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
