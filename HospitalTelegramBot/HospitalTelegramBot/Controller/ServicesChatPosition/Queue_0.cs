using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Queue_0(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;

            await Queue_0(chat);
        }

        private static async Task Queue_0(Chat chat)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "[Користувач отримує список професій які наявні в лікарні]");
            await DbServices.ChangePositionAsync(chat.Id, "🏥 Зареєструватись у чергу 1");
        }
    }
}
