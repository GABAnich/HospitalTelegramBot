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
    }
}
