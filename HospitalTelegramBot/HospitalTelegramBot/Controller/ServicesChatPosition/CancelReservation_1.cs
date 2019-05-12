using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task CancelReservation_1(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;

            await CancelReservation_1(chat);
        }

        private static async Task CancelReservation_1(Chat chat)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "Операція завершена");
            await DbServices.ChangePositionAsync(chat.Id, "🎛 Головне меню");
        }
    }
}
