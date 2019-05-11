using HospitalTelegramBot.Model.Services;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;

namespace HospitalTelegramBot.Controller
{
    internal class ServicesMessageController
    {
        internal static async Task RouteMenuAsync(string userInput, Chat chat)
        {
            if (userInput == "/start")
            {
                await DbServices.ChangePositionAsync(chat.Id, "/start");
            }
            else if (userInput == "🎛 Головне меню")
            {
                await DbServices.ChangePositionAsync(chat.Id, "🎛 Головне меню");
            }
            else if (userInput == "👨‍⚕️ Лікарі")
            {
                await DbServices.ChangePositionAsync(chat.Id, "👨‍⚕️ Лікарі 0");
            }
            else if (userInput == "❌ Зняти бронювання")
            {
                await DbServices.ChangePositionAsync(chat.Id, "❌ Зняти бронювання 0");
            }
            else if (userInput == "🏥 Зареєструватись у чергу")
            {
                await DbServices.ChangePositionAsync(chat.Id, "🏥 Зареєструватись у чергу 0");
            }
        }

        internal static async Task RouteMessageChatPositionAsync(string chatPosition, MessageEventArgs e)
        {
            if (chatPosition == "/start")
            {
                await ServicesChatPosition.StartAsync(e);
            }
            else if (chatPosition == "🎛 Головне меню")
            {
                //await ServicesChatPosition.MainMenuAsync(e);
            }
        }
        internal static async Task SendPhotoAsync(ChatId chatId,
            string photo,
            string caption,
            IReplyMarkup keyboard)
        {
            await Program.botClient.SendPhotoAsync(
                chatId: chatId,
                photo: photo,
                caption: caption,
                parseMode: ParseMode.Markdown,
                replyMarkup: keyboard);
        }
    }
}