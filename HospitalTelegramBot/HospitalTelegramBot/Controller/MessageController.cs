using HospitalTelegramBot.Model.Services;
using HotespitalTelegramBot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    class MessageController
    {
        internal static async void OnMessageAsync(object sender, MessageEventArgs e)
        {
            string userInput = e.Message.Text;
            Chat chat = e.Message.Chat;
            string chatPosition;

            if (e.Message == null)
            {
                return;
            }

            try
            {
                await DbServices.CrateIfNotExistUserChatAsync(chat.Id);
                await ServicesMessageController.RouteMenuAsync(userInput, chat);

                chatPosition = DbServices.GetChatPositionByIdChat(chat.Id);
                Logger.Log(chatPosition, e);
                await ServicesMessageController.RouteMessageChatPositionAsync(chatPosition, e);
            }
            catch (Telegram.Bot.Exceptions.ApiRequestException exception)
            {
                if (exception.Message == "Forbidden: bot was blocked by the user")
                {
                    Logger.Log(exception.Message);
                    return;
                }
            }
        }
    }
}
