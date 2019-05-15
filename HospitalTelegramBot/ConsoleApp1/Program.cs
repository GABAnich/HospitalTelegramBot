using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan start = new TimeSpan(8, 0, 0);
            TimeSpan end = new TimeSpan(16, 0, 0);
            TimeSpan step = new TimeSpan(0, 20, 0);

            Dates(start, end, step);

            Console.ReadKey();
        }

        public static List<TimeSpan> Dates(TimeSpan start, TimeSpan end, TimeSpan step)
        {
            List<TimeSpan> times = new List<TimeSpan>();

            while(start < end)
            {
                times.Add(start);
                start += step;
            }

            return times;
        }
    }
}
