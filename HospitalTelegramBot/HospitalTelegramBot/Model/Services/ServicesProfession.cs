using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTelegramBot.Model.Services
{
    class ServicesProfession
    {
        public static Profession GetProfesionById(int id)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                return db.Professions
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
            }
        }

        public static Profession GetProfesionByName(string name)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                return db.Professions
                    .Where(p => p.Name == name)
                    .FirstOrDefault();
            }
        }

        public static async Task AddProfesioon(string name)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                Profession profession = new Profession() { Name = name };
                db.Professions.Add(profession);
                await db.SaveChangesAsync();
            }
        }
    }
}
