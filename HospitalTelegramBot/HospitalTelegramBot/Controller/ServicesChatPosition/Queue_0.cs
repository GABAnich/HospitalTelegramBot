using HospitalTelegramBot.Model;
using HospitalTelegramBot.Model.Services;
using HospitalTelegramBot.View;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

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
            List<Profession> doctorProfessions = DbServices.GetAviableProfessions();
            IReplyMarkup keyboards = Keyboards.Professions(doctorProfessions);

            await ServicesMessageController.SendMessageAsync(chat, "Оберіть професію", keyboards);
            await DbServices.ChangePositionAsync(chat.Id, "🏥 Зареєструватись у чергу 1");
        }
    }
}
