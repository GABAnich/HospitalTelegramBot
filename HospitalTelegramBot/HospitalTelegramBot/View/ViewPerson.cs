using HospitalTelegramBot.Model;

namespace HospitalTelegramBot.View
{
    class ViewPerson
    {
        public static string GetTextAboutPerson(Person p, Doctor d)
        {
            return "" +
                $"*{p.LastName} {p.FirstName} {p.MiddleName}*\n\n" +
                $"Тривалість прийому: *{d.Duration} хв*\n" +
                $"Поверх: *{d.Floor}*";
        }
    }
}
