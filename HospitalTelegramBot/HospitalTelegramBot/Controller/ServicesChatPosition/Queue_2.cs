using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Queue_2(CallbackQueryEventArgs e)
        {
            Chat chat = e.CallbackQuery.Message.Chat;

            await Queue_2(chat);
        }

        private static async Task Queue_2(Chat chat)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "[Список доступних годин для запису у чергу]");
            await DbServices.ChangePositionAsync(chat.Id, "🏥 Зареєструватись у чергу 3");
        }
    }
}
