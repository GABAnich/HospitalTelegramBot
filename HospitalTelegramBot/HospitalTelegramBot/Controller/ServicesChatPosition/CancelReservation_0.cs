using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task CancelReservation_0(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;

            await CancelReservation_0(chat);
        }

        private static async Task CancelReservation_0(Chat chat)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "[Користувач отримує перелік реєстрацій. Натиснувши на одне із них, він покине місце у черзі]");
            await DbServices.ChangePositionAsync(chat.Id, "❌ Зняти бронювання 1");
        }
    }
}
