using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class Jagged
    {
        string[][] friend = new string[][]
        {
            new string[] {"Sai","Aruna","Paramjith","Harshit"},
            new string[] {"Kiran","Tuhina","Kiara"},
            new string[] {"Madhu","Nayana","Chetal","Chethan"},
        };
        public void IntroduceFamily()

        {
            //   for(int friendNumber = 0; friendNumber < friend.Length; friendNumber++)

            foreach (string mem1 in friend[0])
            {
                foreach (string mem2 in friend[1])
                {

                   
                }
            }
            foreach (string mem4 in friend[1])
            {
                foreach (string mem5 in friend[2])
                {
                    Console.WriteLine("Hi  {0} : Hi {1} \n", mem4, mem5);
                }
            }                                    
            
        }
    }

    
}
