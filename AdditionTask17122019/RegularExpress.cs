using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AdditionTask17122019
{
    class RegularExpress
    {
        public static void RegularExpmethod()
        {
            string pattern = @"\d";
            string text = "The required numbers are 123456";
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(text);
            foreach(Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("The value of digit:{0} and index:{1}", group[0].Value,group[0].Index );
            }
            
        }
    }
}
