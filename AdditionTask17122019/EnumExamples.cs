using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    public enum Day : int
    {
        Sunday, Monday, Tuesday, Wednesday, Thurday, Friday, Saturday
    }
    public enum Month : int
    {
        January, Febraury, March, April, May, June, July, August, September, October, November, December
    }
    class EnumExamples
    {   
        public static void EnumMethod()
        {
            int[] dayValues = (int[])Enum.GetValues(typeof(Day));
            foreach (int dayValue in dayValues)
            {
                Console.WriteLine(dayValue);
            }   
            string[] dayNames = Enum.GetNames(typeof(Day));
            foreach (string dayName in dayNames)
            {
                Console.WriteLine(dayName);
            }

            int[] monthValues = (int[])Enum.GetValues(typeof(Month));
            foreach (int monthValue in monthValues)
            {
                Console.WriteLine(monthValue);
            }
            string[] monthNames = Enum.GetNames(typeof(Month));
            foreach (string monthName in monthNames)
            {
                Console.WriteLine(monthName);
            }
        }


    }
}
