using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Queue_1(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;

            await Queue_1(chat);
        }

        private static async Task Queue_1(Chat chat)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "[Список лікарів та їх найближчий вільний час]");
            await DbServices.ChangePositionAsync(chat.Id, "🏥 Зареєструватись у чергу 2");
        }
    }
}
