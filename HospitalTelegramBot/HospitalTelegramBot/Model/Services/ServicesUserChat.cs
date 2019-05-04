using System.Linq;
using System.Threading.Tasks;

namespace HospitalTelegramBot.Model.Services
{
    class ServicesUserChat
    {
        public static UserChat GetUserChatByIdChat(int idChat)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                return db.UserChats
                    .Where(u => u.IdChat == idChat)
                    .FirstOrDefault();
            }
        }

        public static async Task AddUserChatAsync(int idChat, string chatPosition)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                UserChat user = new UserChat() { IdChat = idChat, ChatPosition = chatPosition};
                db.UserChats.Add(user);
                await db.SaveChangesAsync();
            }
        }

        public static async Task UpdateChatPositionAsync(int idChat, string position)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                db.UserChats
                    .Where(u => u.IdChat == idChat)
                    .FirstOrDefault().ChatPosition = position;

                await db.SaveChangesAsync();
            }
        }
    }
}