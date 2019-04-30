using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTelegramBot.Model
{
    class Record
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Number { get; set; }
        public string Date { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int UserChatId { get; set; }
        public UserChat UserChat { get; set; }
    }
}
