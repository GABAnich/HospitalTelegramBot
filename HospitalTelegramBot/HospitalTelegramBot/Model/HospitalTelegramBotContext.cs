using System.Data.Entity;

namespace HospitalTelegramBot.Model
{
    class HospitalTelegramBotContext : DbContext
    {
        public HospitalTelegramBotContext()
            : base("HospitalTelegramBotConnection")
        { }

        public DbSet<DateOfBirth> DateOfBirths { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<TempInformation> TempInformation { get; set; }
        public DbSet<UserChat> UserChats { get; set; }
    }
}