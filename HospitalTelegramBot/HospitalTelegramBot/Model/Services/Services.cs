using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalTelegramBot.Model.Services
{
    class DbServices
    {
        public static async Task CrateIfNotExistUserChatAsync(long idChat)
        {
            UserChat userChat = ServicesUserChat.GetUserChatByIdChat(idChat);
            if (userChat != null) return;

            await ServicesUserChat.AddUserChatAsync(idChat, "/start");
        }

        public static async Task ClearUserTempDataAsync(long chatId)
        {
            await ServicesTempInformation.RemoveRangeTempInformationByChatIdAsync(chatId);
        }

        public static string GetChatPositionByIdChat(long idChat)
        {
            return ServicesUserChat.GetUserChatByIdChat(idChat).ChatPosition;
        }

        public static async Task ChangePositionAsync(long idChat, string position)
        {
            await ServicesUserChat.UpdateChatPositionAsync(idChat, position);
        }

        public static List<Person> GetDoctorPeopleByProfession(int professionId)
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                return db.Doctors
                    .Where(d => d.ProfessionId == professionId)
                    .Select(d => d.Person)
                    .ToList();
            }
        }

        public static List<Profession> GetAviableProfessions()
        {
            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                List<int> doctorProfessionId = db.Doctors.Select(d => d.ProfessionId).ToList();

                return db.Professions
                    .Where(p => doctorProfessionId.Contains(p.Id))
                    .ToList();
            }
        }
    }
}
