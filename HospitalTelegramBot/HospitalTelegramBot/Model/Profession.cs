using System.Collections.Generic;

namespace HospitalTelegramBot.Model
{
    class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Doctor> Doctor { get; set; }
    }
}
