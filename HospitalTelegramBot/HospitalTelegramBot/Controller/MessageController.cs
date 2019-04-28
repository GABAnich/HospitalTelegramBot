using Telegram.Bot.Args;

namespace HospitalTelegramBot.Controller
{
    class MessageController
    {
        internal static async void OnMessageAsync(object sender, MessageEventArgs e)
        {
            await Program.botClient.SendTextMessageAsync(e.Message.Chat.Id, "Hello world!");
        }
    }
}
