using System.Linq;
using System.Threading.Tasks;

namespace HospitalTelegramBot.Model.Services
{
    class ServicesTempInformation
    {
        public static async Task AddTempInformationAsync(int chatId, string property, string value)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                var obj = new TempInformation()
                {
                    UserChatId = chatId,
                    Property = property,
                    Value = value
                };
                db.TempInformation.Add(obj);

                await db.SaveChangesAsync();
            }
        }

        public static TempInformation GetTempInformation(int chatId, string property)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                return db.TempInformation
                    .Where(t => t.UserChatId == chatId)
                    .Where(t => t.Property == property)
                    .First();
            }
        }

        public static async Task RemoveRangeTempInformationByChatIdAsync(long chatId)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                var values = db.TempInformation
                    .Where(t => t.UserChatId == chatId);

                db.TempInformation
                    .RemoveRange(values);

                await db.SaveChangesAsync();
            }
        }
    }
}
