using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class ArithmeticOperation
    {
        // The arithmetic operations can be performed as follows.
        // Addition             -> a = b + c;
        // Substraction         -> a = b - c;
        // Multiplication       -> a = b * c;
        // Division             -> a = b / c;
        // Mod                  -> a = b % c;
        int firstNumber, secondNumber, result;
        string oper;
        public void Arithmetic( ) {
            Console.WriteLine("Please enter the first number");
            //Checking whether the first number is integer
            //TryParse function always provides the boolean as result.
            // Syntac of parse function is as follows
            // bool variable = (datatype).TryParse(input field, out outputfield)
            bool isNumber1 = int.TryParse(Console.ReadLine(), out firstNumber);
            if (!isNumber1)
            {
                Console.WriteLine("Format of first number is not correct");
            }
            Console.WriteLine("Please enter the second number");
            //Checking whether the first number is integer
            bool isNumber2 = int.TryParse(Console.ReadLine(), out secondNumber);
            if (!isNumber2)
            {
                Console.WriteLine("Format of second number is not correct");
            }

            Console.WriteLine("Please enter the operator");
            oper = Console.ReadLine();

            if (isNumber1 && isNumber2)
            {
                // Switch case usage
                switch (oper)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        Console.WriteLine(" The sum result is {0}", result);
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        Console.WriteLine("The substraction result is {0}", result);
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        Console.WriteLine("The divison result is {0}", result);
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        Console.WriteLine("The multiplication result is {0}", result);
                        break;
                    case "%":
                        result = firstNumber % secondNumber;
                        Console.WriteLine("The mod result is {0}", result);
                        break;
                }
            }
            else
            {
                //Sum cannot be done as first number or second number or first number & second number are not integers - failure case
                Console.WriteLine("The sum cannot be done between the provided numbers");
            }


        }

    }
}
