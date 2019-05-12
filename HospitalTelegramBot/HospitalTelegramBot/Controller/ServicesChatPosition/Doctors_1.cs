using HospitalTelegramBot.Model;
using HospitalTelegramBot.Model.Services;
using HospitalTelegramBot.View;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Doctors_1(CallbackQueryEventArgs e)
        {
            Chat chat = e.CallbackQuery.Message.Chat;
            string userInput = e.CallbackQuery.Data;

            await Doctors_1(chat, userInput);
        }

        private static async Task Doctors_1(Chat chat, string userInput)
        {
            List<Person> people = DbServices.GetDoctorPeopleByProfession(Convert.ToInt32(userInput));
            IReplyMarkup keyboards = Keyboards.People(people);

            await ServicesMessageController.SendMessageAsync(
                chat, "Оберіть лікаря", keyboards);
            await DbServices.ChangePositionAsync(chat.Id, "👨‍⚕️ Лікарі 2");
        }
    }
}
