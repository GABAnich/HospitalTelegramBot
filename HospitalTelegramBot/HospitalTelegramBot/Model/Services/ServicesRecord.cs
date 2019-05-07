using System.Linq;
using System.Threading.Tasks;

namespace HospitalTelegramBot.Model.Services
{
    class ServicesRecord
    {
        public static Record GetRecordById(int id)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                return db.Records
                    .Where(r => r.Id == id)
                    .FirstOrDefault();
            }
        }

        public static async Task AddRecord(
            int doctorId,
            int userChatId,
            string lastName,
            string firstName,
            string middleName,
            string number,
            string date)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                Record record = new Record() {
                    DoctorId = doctorId,
                    UserChatId = userChatId,
                    LastName = lastName,
                    FirstName = firstName,
                    MiddleName = middleName,
                    Number = number,
                    Date = date
                };
                db.Records.Add(record);
                await db.SaveChangesAsync();
            }
        }
    }
}
