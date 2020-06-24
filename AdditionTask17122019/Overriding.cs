using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class Overriding
    {
        public void OverridingMethod()
        {
            Console.WriteLine("Override & Hiding");
            Console.WriteLine(" Override is nothing but invoking the derived class methods\n" +
                "from the object or class of a base class");
            Console.WriteLine(" For override the same method name should exist in both \n" +
                "base class and derived class and base class with same number of parameter");
        }
    }
    class BaseClass
    {
        public int i, j, k;
        public BaseClass(int i, int j, int k)
        {
            this.i = i;
            this.j = j;
            this.k = k;
            Console.WriteLine("BaseClass the value i:{0} , j:{1} , k:{2}", i, j, k);
        }
        public void CheckBase()
        {
            Console.WriteLine("CheckBase method of inheritence Class");

        }
        public virtual void Checking()
        {
            Console.WriteLine("BaseClass  and Checking method");

        }

        public virtual void Testing()
        {
            Console.WriteLine("BaseClass and Testing method");
        }
    }
    class DerivedClass : BaseClass
    {
        public int l;
        public DerivedClass(int i, int j, int k, int l) : base(i, k, j)
        {
            this.l = l;
            Console.WriteLine("DerivedClass value i:{0} , j:{1} , k:{2} , l:{3},", i, j, k, l);
        }

        //Override function is used to call the method of derived class in base class
        //DerivedClass DC = new BaseClass(2,3,4,5);
        public new void Checking()
        {
            Console.WriteLine("Derived Class and Checking method");
        }

        //Override function is used to call the method of derived class in base class
        //BaseClass BC = new DerivedClass(2,3,4,5);
        public override void Testing()
        {
            Console.WriteLine("Derived Class and Testing method");
        }


    }
}
