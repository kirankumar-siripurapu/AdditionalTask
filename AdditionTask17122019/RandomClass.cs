using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class RandomClass
    {       
        public static void RandomNumber()
        {
            Random Num = new Random();
            for (int i = 0;i < 10; i++)
            {
                int y = Num.Next(1, 4);
                switch (y)
                {
                    case 1:
                        Console.WriteLine("Yes");
                        break;
                    case 2:
                        Console.WriteLine("No");
                        break;
                    case 3:
                        Console.WriteLine("Maybe");
                        break;
                }

            }

        }
    }
}
