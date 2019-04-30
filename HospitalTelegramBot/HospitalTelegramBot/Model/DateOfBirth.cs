using System.Collections.Generic;

namespace HospitalTelegramBot.Model
{
    class DateOfBirth
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public ICollection<Person> Person { get; set; }
    }
}
