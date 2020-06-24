using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class Ternary
    {
        public int temperature = 10;
        public string status = "";
        public void TernaryOperation()
        {
            // ternary operator
            status = (temperature == 10) ? "It is ok" : "It is not ok";
            Console.WriteLine(status);

            //null coalescing

            int? i = null;
            int j = i ?? 0;
            Console.WriteLine("The value of i is {0} and j is {1}", i, j);
        }
    }
}
