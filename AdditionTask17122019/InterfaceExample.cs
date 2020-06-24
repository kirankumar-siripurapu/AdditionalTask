using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    interface Interface1
    {
        int X  {set;get;}
        int Y { set; get; }
        int Summation(int x, int y);
        int Substraction(int x, int y);
        int Modulus(int x, int y);
    }
    interface Interface2
    {
        int Multiplication(int x, int y);
        int Division(int x, int y);
        int Modulus(int x, int y);
    }
    class Algorithm : Interface1,Interface2
    {
        int _x;
        int _y;
        //public int X { get => X; set => _x = value; }
        //public int Y { get => Y; set => _y = value; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Summation(int x,int y)
        {
            return x + y;
        }
        public int Division(int x, int y)
        {
            return x / y;
        }
        public int Substraction(int x, int y)
        {
            return x - y;
        }
        public int Multiplication(int x, int y)
        {
            return x * y;
        }
        public int Modulus(int x, int y)
        {
            return x % y;
        }
    }
}
