using System.Collections.Generic;

namespace HospitalTelegramBot.Model
{
    class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }

        public ICollection<Record> Record { get; set; }
    }
}
