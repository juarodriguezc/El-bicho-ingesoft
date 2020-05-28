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

namespace chatbottest1
{
    public partial class Chatbot_menu : Form
    {

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
                Text = "Hi",
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
                        if (message != "Hello and welcome!") {
                            if (InvokeRequired)
                            {
                                BeginInvoke(new MethodInvoker(delegate {
                                    if (message != "Echo:  ") textBox.AppendText("Bot said: " + message + "\r\n");
                                }));
                            }
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
                textBox.AppendText("You said: " + input + "\r\n");
                await Client.Conversations.PostActivityAsync(this.conversation.ConversationId, userMessage);
            }
            
        }

        private void textsend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                bt_send.PerformClick();
            }
        }

        private void Chatbot_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
