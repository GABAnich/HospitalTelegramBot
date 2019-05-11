using System.Collections.Generic;

namespace HospitalTelegramBot.Model
{
    class UserChat
    {
        public long idChat;

        public int Id { get; set; }
        public long IdChat { get; set; }
        public string ChatPosition { get; set; }

        public ICollection<TempInformation> TempInformation { get; set; }
        public ICollection<Record> Record { get; set; }
    }
}
