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
                await ServicesChatPosition.MainMenuAsync(e);
            }
            else if (chatPosition == "👨‍⚕️ Лікарі 0")
            {
                await ServicesChatPosition.Doctors_0(e);
            }
            else if (chatPosition == "🏥 Зареєструватись у чергу 0")
            {
                await ServicesChatPosition.Queue_0(e);
            }
            else if (chatPosition == "🏥 Зареєструватись у чергу 3")
            {
                await ServicesChatPosition.Queue_3(e);
            }
            else if (chatPosition == "🏥 Зареєструватись у чергу 4")
            {
                await ServicesChatPosition.Queue_4(e);
            }
            else if (chatPosition == "🏥 Зареєструватись у чергу 5")
            {
                await ServicesChatPosition.Queue_5(e);
            }
            else if (chatPosition == "🏥 Зареєструватись у чергу 6")
            {
                await ServicesChatPosition.Queue_6(e);
            }
            else if (chatPosition == "🏥 Зареєструватись у чергу 7")
            {
                await ServicesChatPosition.Queue_7(e);
            }
            else if (chatPosition == "❌ Зняти бронювання 0")
            {
                await ServicesChatPosition.CancelReservation_0(e);
            }
            else if (chatPosition == "❌ Зняти бронювання 1")
            {
                await ServicesChatPosition.CancelReservation_1(e);
            }
        }

        internal static async Task RouteMessageChatPositionAsync(string chatPosition, CallbackQueryEventArgs e)
        {
            if (chatPosition == "👨‍⚕️ Лікарі 1")
            {
                await ServicesChatPosition.Doctors_1(e);
            }
            else if (chatPosition == "👨‍⚕️ Лікарі 2")
            {
                await ServicesChatPosition.Doctors_2(e);
            }
            else if (chatPosition == "🏥 Зареєструватись у чергу 1")
            {
                await ServicesChatPosition.Queue_1(e);
            }
            else if (chatPosition == "🏥 Зареєструватись у чергу 2")
            {
                await ServicesChatPosition.Queue_2(e);
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

        internal static async Task SendMessageAsync(ChatId chatId,
            string text,
            IReplyMarkup keyboard = null)
        {
            if (keyboard == null)
            {
                keyboard = new ReplyKeyboardRemove();
            }

            Message message = await Program.botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: text,
                    parseMode: ParseMode.Markdown,
                    disableNotification: true,
                    replyMarkup: keyboard
                );
        }
    }
}