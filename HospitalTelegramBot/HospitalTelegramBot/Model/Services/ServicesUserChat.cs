using System.Linq;
using System.Threading.Tasks;

namespace HospitalTelegramBot.Model.Services
{
    class ServicesUserChat
    {
        public static UserChat GetUserChatByIdChat(long idChat)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                return db.UserChats
                    .Where(u => u.IdChat == idChat)
                    .FirstOrDefault();
            }
        }

        public static async Task AddUserChatAsync(long idChat, string chatPosition)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                UserChat user = new UserChat() { IdChat = idChat, ChatPosition = chatPosition};
                db.UserChats.Add(user);
                await db.SaveChangesAsync();
            }
        }

        public static async Task UpdateChatPositionAsync(long idChat, string position)
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