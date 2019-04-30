namespace HospitalTelegramBot.Model
{
    class TempInformation
    {
        public int Id { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }

        public int UserChatId { get; set; }
        public UserChat UserChat { get; set; }
    }
}
