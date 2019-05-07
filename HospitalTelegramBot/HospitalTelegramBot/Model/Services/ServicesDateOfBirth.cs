using System.Linq;
using System.Threading.Tasks;

namespace HospitalTelegramBot.Model.Services
{
    class ServicesDateOfBirth
    {
        public static DateOfBirth GetDateOfBirth(int day, int month, int year)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                return db.DateOfBirths
                    .Where(d => d.Day == day)
                    .Where(d => d.Month == month)
                    .Where(d => d.Year == year)
                    .FirstOrDefault();
            }
        }

        public static async Task AddDateOfBirth(int day, int month, int year)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                DateOfBirth date = new DateOfBirth() { Day = day, Month = month, Year = year };
                db.DateOfBirths.Add(date);
                await db.SaveChangesAsync();
            }
        }
    }
}
