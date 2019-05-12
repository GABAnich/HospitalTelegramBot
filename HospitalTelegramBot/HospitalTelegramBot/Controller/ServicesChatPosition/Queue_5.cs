using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Queue_5(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;

            await Queue_5(chat);
        }

        private static async Task Queue_5(Chat chat)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "По батькові");
            await DbServices.ChangePositionAsync(chat.Id, "🏥 Зареєструватись у чергу 6");
        }
    }
}
