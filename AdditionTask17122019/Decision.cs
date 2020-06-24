using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class Decision
    {
        int arraySize;
        
        
        public void ForDecisionMaking() 
        {
            int y;
            Console.WriteLine("Please enter the array size");
            arraySize = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[arraySize];
            for(y=0; y< 10; y++)
            {
                x[y] = y;
                Console.WriteLine("The value of x[{0}] is {1}", y, x[y]);
            }
            
        }
        public void ForEachDecisionMaking()
        {
            int[] c = new int[10] { 2, 4, 5, 6, 8, 9, 20, 90, 32, 56 };
            foreach (int z in c)
            {
                Console.WriteLine("The value of x is {0}", z);
            }
        }
        public void WhileDecisionMaking()
        {
            int y =0;
            Console.WriteLine("Please enter the array size");
            arraySize = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[arraySize];
            while (y < 10)
            {
                x[y] = y;
                Console.WriteLine("The value of x[{0}] is {1}", y, x[y]);
                y++;
            }             
        }

        public void DoWhileDecisionMaking()
        {
            int y = 0;
            Console.WriteLine("Please enter the array size");
            arraySize = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[arraySize];
            do
            {
                x[y] = y;
                Console.WriteLine("The value of x[{0}] is {1}", y, x[y]);
                y++;
            } while (y < 9);
        }

        public void GreeFriends()
        {
            string[] friends = new string[5] { "Kiran", "Uppu","leela","Vinay","Sudheer"};
            int counter = 0;
            foreach(string friendsNames in friends)
            {
                counter++;
                Console.WriteLine("print friend{0} Name {1}",counter,friendsNames );
                
            }
        }

    }
}
