using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static async Task AddPerson(string lastName, string firstName, string middleName, int day, int month, int year)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                DateOfBirth date = await ServicesDateOfBirth.ForceGetDateOfBirth(day, month, year);
                Person person = new Person() { LastName = lastName, FirstName = firstName, MiddleName = middleName, DateOfBirthId = date.Id };
                db.People.Add(person);
                await db.SaveChangesAsync();
            }
        }
    }
}
