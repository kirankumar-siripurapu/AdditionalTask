using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class DateTimeExamp
    {
        public static void DateTimemethod()
        {
            //DateTime datetime = new DateTime(2007, 12, 31, 10, 20, 30, DateTimeKind.Unspecified);
            DateTime datetime = new DateTime(2006, 12, 31, 10, 20, 30, DateTimeKind.Utc);
            Console.WriteLine(datetime);
            DateTime datetime1 = new DateTime(206,12,31);
            Console.WriteLine(datetime1);        
            Console.WriteLine("Current Time {0}", DateTime.Now);
            Console.WriteLine(" Days in Month{0}", DateTime.DaysInMonth(2000, 10));
            Console.WriteLine(" Compare {0}", DateTime.Compare(datetime, datetime1));

            Console.WriteLine("The time {0} o'clock and {1} minutes and {2} seconds", DateTime.Now.Hour,
               DateTime.Now.Minute, DateTime.Now.Second);
            DateTime datetime3 = DateTime.Now;
            string datefield = Console.ReadLine();
            if(DateTime.TryParse(datefield, out DateTime DT))
            {
                Console.WriteLine(DT);
                TimeSpan TS = datetime3.Subtract(DT);
                Console.WriteLine(TS.Days);
                Console.WriteLine(TS.Hours);
            }
        } 
        public static DateTime GetThousandDay( string datefield)
        {
            bool tt =DateTime.TryParse(datefield, out DateTime DT);
            return DT.AddDays(10000);
        }
    }
}
