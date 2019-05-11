using System.Threading.Tasks;

namespace HospitalTelegramBot.Model.Services
{
    class DbServices
    {
        public static async Task CrateIfNotExistUserChatAsync(long idChat)
        {
            UserChat userChat = ServicesUserChat.GetUserChatByIdChat(idChat);
            if (userChat != null) return;

            await ServicesUserChat.AddUserChatAsync(idChat, "/start");
        }

        public static async Task ClearUserTempDataAsync(long chatId)
        {
            await ServicesTempInformation.RemoveRangeTempInformationByChatIdAsync(chatId);
        }

        public static string GetChatPositionByIdChat(long idChat)
        {
            return ServicesUserChat.GetUserChatByIdChat(idChat).ChatPosition;
        }

        public static async Task ChangePositionAsync(long idChat, string position)
        {
            await ServicesUserChat.UpdateChatPositionAsync(idChat, position);
        }
    }
}
