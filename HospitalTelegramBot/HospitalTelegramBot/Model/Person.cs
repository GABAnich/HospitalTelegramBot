using System.Collections.Generic;

namespace HospitalTelegramBot.Model
{
    class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string ImageURL { get; set; }

        public int DateOfBirthId { get; set; }
        public DateOfBirth DateOfBirth { get; set; }

        public ICollection<Doctor> Doctor { get; set; }
    }
}
