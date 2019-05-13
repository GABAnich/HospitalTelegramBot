using HospitalTelegramBot.Model;
using HospitalTelegramBot.Model.Services;
using HospitalTelegramBot.View;
using System;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    partial class ServicesChatPosition
    {
        internal static async Task Doctors_2(CallbackQueryEventArgs e)
        {
            Chat chat = e.CallbackQuery.Message.Chat;
            string userInput = e.CallbackQuery.Data;

            await Doctors_2(chat, userInput);
        }

        private static async Task Doctors_2(Chat chat, string userInput)
        {
            int personId = Convert.ToInt32(userInput);
            Person person = ServicesPerson.GetPersonById(personId);
            Doctor doctor = ServicesDoctor.GetDoctorByPersonId(personId);
            string text = ViewPerson.GetTextAboutPerson(person, doctor);

            await ServicesMessageController.SendPhotoAsync(chat, person.ImageURL, text, Keyboards.MainKeyboard);
            await DbServices.ChangePositionAsync(chat.Id, "🎛 Головне меню");
        }
    }
}
