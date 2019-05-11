using HospitalTelegramBot.Model.Services;
using HospitalTelegramBot.View;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace HospitalTelegramBot.Controller
{
    class ServicesChatPosition
    {
        internal static async Task StartAsync(MessageEventArgs e)
        {
            Chat chat = e.Message.Chat;

            await DbServices.ClearUserTempDataAsync(chat.Id);
            await ServicesMessageController.SendPhotoAsync(
                chat,
                AboutHospital.ImageAboutHotel,
                AboutHospital.InfoAboutHotel,
                Keyboards.MainKeyboard);
        }
    }
}
