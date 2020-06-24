using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class Inheritence
    {
        int i, j, k;
        public void InheritenceMethod() {

            Console.WriteLine("Below are the types of inheritence \n " +
                "1. single level \n 2.multi level \n 3. Hierarchy \n 4.multiple \n 5.hybrid ");
            Console.WriteLine("Multiple and Hybrid inheritence can achieved through interface" +
                "and rest of the interface can be achieved through classes");
        }

        public void BaseClass()
        {


        }

        //public void Derived
    }
    class ParentClass
    {
        int i, j, k;
        public ParentClass(int i, int j, int k)
        {
            this.i = i;
            this.j = j;
            this.k = k;
            Console.WriteLine(" In parent class constructor the values are i =" +
                "{0}, j = {1}, k = {2}", i, j, k);
        }
        public void ParentClassMethod()
        {
            i = j + k;
            Console.WriteLine(" The summ of J {0} and K{1) ", j,k);

        }


    }
}
