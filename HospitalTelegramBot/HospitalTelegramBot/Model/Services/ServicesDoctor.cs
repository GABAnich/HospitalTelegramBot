using System.Collections.Generic;
using System.Linq;

namespace HospitalTelegramBot.Model.Services
{
    class ServicesDoctor
    {
        public static Doctor GetDoctorById(int id)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                return db.Doctors
                    .Where(d => d.Id == id)
                    .FirstOrDefault();
            }
        }
    }
}
