using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Queue_3(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;
            string userInput = e.Message.Text;

            await Queue_3(chat, userInput);
        }

        private static async Task Queue_3(Chat chat, string userInput)
        {
            //await DbServices.SaveUserTempDataAsync("Date", userInput, chat.Id);

            await ServicesMessageController.SendMessageAsync(
                chat, "Введіть прізвище: ");
            await DbServices.ChangePositionAsync(chat.Id, "🏥 Зареєструватись у чергу 4");
        }
    }
}
