using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Doctors_0(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;

            await Doctors_0(chat);
        }

        private static async Task Doctors_0(Chat chat)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "[Користувач отримує список професій які наявні в лікарні]");
            await DbServices.ChangePositionAsync(chat.Id, "👨‍⚕️ Лікарі 1");
        }
    }
}
