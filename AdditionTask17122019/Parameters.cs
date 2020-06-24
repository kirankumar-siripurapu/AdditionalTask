using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{

    class Parameters
    {
        public int i, j, k;
        //string a, b, c;
        int[] z = new int[5];
        //In the Pass by value the values of the parameters will be passed but not the memory
        //The values of the parameters cannot be modified by calling the object/instance
        public void PassByValue(int a, int b, int c, out int x, out int y)
        {
            x = a + b + c;
            y = x + a + b + c;

        }
        //In the Pass by reference the memory of the parameters will be passed.
        //The value of the parameters can be modfied by changing the value in its memory 
        //while calling object/instance
        public void PassByReference(ref int i, ref int j, ref int k)
        {
            this.j = i + j + k;
            j = i + j + k;
        }
        // Using the params the values of the array can be passed
        // params should be always the last parameter
        public int Paramsmethos(params int[] x)
        {
            int y = 0;
            foreach (int g in x)
            {
                y = y + g;
                
            }
            return y;
        }

        //In a method we can return the value and the data type of the return parameter 
        //should be mentioned
        public int ParametersReturn()
        {
            return j;
        }



    }
}
