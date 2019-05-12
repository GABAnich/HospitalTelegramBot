using HospitalTelegramBot.Model;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace HospitalTelegramBot.View
{
    class Keyboards
    {
        internal static readonly IReplyMarkup MainKeyboard = new ReplyKeyboardMarkup
        {
            Keyboard = new KeyboardButton[][]
            {
                new KeyboardButton[] { "👨‍⚕️ Лікарі", "❌ Зняти бронювання" },
                new KeyboardButton[] { "🏥 Зареєструватись у чергу" },
            },
            ResizeKeyboard = true,
            OneTimeKeyboard = true
        };

        internal static IReplyMarkup GetAviableProfessions(List<Profession> aviableProfessions)
        {
            List<List<InlineKeyboardButton>> keyboards = new List<List<InlineKeyboardButton>>();
            foreach (Profession p in aviableProfessions)
            {
                keyboards.Add(new List<InlineKeyboardButton>() {
                    InlineKeyboardButton.WithCallbackData($"{p.Name}", $"{p.Id}")
                });
            }

            return new InlineKeyboardMarkup(keyboards);
        }
    }
}
