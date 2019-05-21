using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Queue_7(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;

            await Queue_7(chat);
        }

        private static async Task Queue_7(Chat chat)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "Реєстрація відбулась успішно");
            await DbServices.ChangePositionAsync(chat.Id, "🎛 Головне меню");
        }
    }
}
