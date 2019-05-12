using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Queue_4(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;

            await Queue_4(chat);
        }

        private static async Task Queue_4(Chat chat)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "Ім’я");
            await DbServices.ChangePositionAsync(chat.Id, "🏥 Зареєструватись у чергу 5");
        }
    }
}
