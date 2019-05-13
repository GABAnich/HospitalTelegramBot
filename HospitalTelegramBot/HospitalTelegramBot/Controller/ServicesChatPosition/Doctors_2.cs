using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Doctors_2(CallbackQueryEventArgs e)
        {
            Chat chat = e.CallbackQuery.Message.Chat;
            string userInput = e.CallbackQuery.Data;

            await Doctors_2(chat, userInput);
        }

        private static async Task Doctors_2(Chat chat, string userInput)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "[Детальна інформація про лікаря]");
            await DbServices.ChangePositionAsync(chat.Id, "🎛 Головне меню");
        }
    }
}
