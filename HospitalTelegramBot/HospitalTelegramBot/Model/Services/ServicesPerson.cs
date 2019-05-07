using System.Linq;
using System.Threading.Tasks;

namespace HospitalTelegramBot.Model.Services
{
    class ServicesPerson
    {
        public static Person GetPersonById(int id)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                return db.People
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
            }
        }

        public static async Task AddPerson(int dateOfBirthId, string lastName, string firstName, string middleName)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                Person person = new Person() { LastName = lastName, FirstName = firstName, MiddleName = middleName, DateOfBirthId = dateOfBirthId };
                db.People.Add(person);
                await db.SaveChangesAsync();
            }
        }
    }
}
