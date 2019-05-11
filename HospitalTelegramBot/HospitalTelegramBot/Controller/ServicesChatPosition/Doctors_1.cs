using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Doctors_1(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;

            await Doctors_1(chat);
        }

        private static async Task Doctors_1(Chat chat)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "[Користувач отримує список лікарів]");
            await DbServices.ChangePositionAsync(chat.Id, "👨‍⚕️ Лікарі 2");
        }
    }
}
