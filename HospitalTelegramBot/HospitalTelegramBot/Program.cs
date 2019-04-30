using HospitalTelegramBot.Controller;
using HospitalTelegramBot.Model;
using System;
using System.Text;
using System.Threading;
using Telegram.Bot;

namespace HospitalTelegramBot
{
    class Program
    {
        public static ITelegramBotClient botClient;

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            using (HospitalTelegramBotContext db = new HospitalTelegramBotContext())
            {
                db.DateOfBirths.Add(new DateOfBirth() { Year = 2000, Day = 5, Month = 6 });
                db.SaveChanges();
            }

            botClient = new TelegramBotClient(ConfigTelegramBot.APIToken);

            botClient.OnMessage += MessageController.OnMessageAsync;
            //botClient.OnCallbackQuery += MessageController.OnCallbackQueryAsync;

            botClient.StartReceiving();
            Thread.Sleep(int.MaxValue);
        }
    }
}
