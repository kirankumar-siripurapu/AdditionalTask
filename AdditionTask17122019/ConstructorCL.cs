using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{

    class ConstructorCL
    {
        public string firstName;
        string lastName, eyeColor;
        protected int age = 10;

        // contructors will be called at the start of the class or object/instance of the class
        //default Constructor
        // Constructors are the piece of code which needs to be executed for every class or 
        // instance/object of a class
        public ConstructorCL()
        {
            Console.WriteLine(" Please enter the Customer Details");
        }
        //Destructor will be invoked at at the end of the object or class
        ~ConstructorCL()
        {
        }
        //paremeterized constructors are constructors in which we pass the parameters
        public ConstructorCL(string fn, string ln, string eyeCl, int ag)
        {
            // here this function takes the member from the class
            this.firstName = fn;
            this.lastName = ln;
            this.eyeColor = eyeCl;
            this.age = ag;
        }

        public void CustomerDetails()
        {

            Console.WriteLine("The details of the customer First Name = {0} \n Last Name = {1} \n" + 
                " Eye Color = {2} \n  Age = {3}", firstName,lastName, eyeColor, age );  
        }


    }
}
