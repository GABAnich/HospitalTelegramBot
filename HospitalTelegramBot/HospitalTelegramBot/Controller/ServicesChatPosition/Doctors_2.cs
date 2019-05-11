using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Doctors_2(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;

            await Doctors_2(chat);
        }

        private static async Task Doctors_2(Chat chat)
        {
            await ServicesMessageController.SendMessageAsync(
                chat, "[Детальна інформація про лікаря]");
            await DbServices.ChangePositionAsync(chat.Id, "👨‍⚕️ Лікарі 2");
        }
    }
}
