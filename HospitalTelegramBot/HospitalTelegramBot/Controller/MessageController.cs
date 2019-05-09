using Telegram.Bot.Args;

namespace HospitalTelegramBot.Controller
{
    class MessageController
    {
        internal static async void OnMessageAsync(object sender, MessageEventArgs e)
        {
            await Program.botClient.SendTextMessageAsync(
                chatId: e.Message.Chat.Id,
                text: "Hello world!",
                replyMarkup: View.Keyboards.MainKeyboard);
        }
    }
}
