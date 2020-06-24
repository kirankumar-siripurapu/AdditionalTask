using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class Program
    {
        public static void Main(string[] args)
        {
            //ArithmeticOperation AO = new ArithmeticOperation();
            //AO.Arithmetic();
            //Ternary ter = new Ternary();
            //ter.TernaryOperation();
            //Decision D = new Decision();
            //D.ForDecisionMaking();
            //D.ForEachDecisionMaking();
            //D.WhileDecisionMaking();
            //D.DoWhileDecisionMaking();

            //Decision DF = new Decision();
            //DF.GreeFriends();
            //-----------------------------------Constructor---------------------------------------

            //ConstructorCL CL = new ConstructorCL("Kiran", "Kumar", "Black", 30);
            //CL.CustomerDetails();
            //Console.WriteLine("--------------------------------------------");
            //ConstructorCL TL = new ConstructorCL("Tuhina", "Rahaman", "Black", 30);
            //TL.CustomerDetails();

            //--------------------------------Pass by value and reference---------------------------------

            //Parameters par = new Parameters();
            //int x, y, z=40;
            //par.PassByValue(10, 20, 30, out x ,out y);
            //Console.WriteLine("The value of x = {0}, y = {1}, z = {2}", x, y, z);
            //par.PassByReference(ref x, ref y , ref z);
            //Console.WriteLine("The value of x = {0}, y = {1}, z = {2}", x, y, z);
            //int l = par.Paramsmethos(x,y,z);
            //Console.WriteLine("The value of l = {0}", l);
            //Console.WriteLine(" the value of j {0} " ,par.ParametersReturn());


            //----------------------------------------------Inheritence----------------------------------


            // Console.WriteLine(" Testing and Checking are method common in both base and derived class");
            // BaseClass BB = new BaseClass(99,98,97); //BaseClass object with BaseClass reference
            // BB.Testing(); // Checking Method from base class will be invoked
            // BB.Checking(); // Testing Method from base class will be invoked

            // Console.WriteLine("----DerivedClass object with DerivedClass reference----");
            ////Console.WriteLine("Testing and Checking Method from Derived class will be invoked " +
            ////"from the object or class of Derived Class by default");
            //  DerivedClass DD = new DerivedClass(5, 6, 7, 8);
            //  DD.Checking(); // Checking Method from derived class will be invoked//
            //  DD.Testing();  // Testing Method from derived class will be invoked//

            //Console.WriteLine("---Hidden Testing and Checking Method from Base class will be invoked " +
            //    "from the object or class of Derived Class");

            // ((BaseClass)DD).Checking(); //new 
            // ((BaseClass)DD).Testing(); //override

            ////Console.WriteLine("-----BaseClass object with DerivedClass reference-----");
            //  BaseClass BD = new DerivedClass(51,52,53,54);

            //  BD.Checking();
            ////Console.WriteLine("---override Testing method from Base class will be invoked.");
            //  BD.Testing();

            //--------------------------------------Properties--------------------------------------------
            //Properties Prop = new Properties();
            //Prop.Width(10);
            //Prop.Length = 20;
            //Prop.GetHeight();
            //Prop.Depth = 40;
            //Prop.VolumeResult();

            //Console.WriteLine(" the value of the depth is {0}", Prop.Depth);
            //Console.WriteLine("The volume is {0}", Prop.Volume);

            //TikTacToe TTT = new TikTacToe();
            //bool player1 = true;
            //int player1Counter = 0;
            //int player2Counter = 0;
            //bool gameOver; 

            //for (int i =1; i <= 9; i++)
            //{                
            //    if (player1)
            //    {
            //        player1Counter++;
            //        TTT.PlayGame(1, player1Counter,out gameOver);
            //        player1 = false;
            //    }
            //    else
            //    {
            //        player2Counter++;
            //        TTT.PlayGame(2, player2Counter,out gameOver);
            //        player1 = true;
            //    }
            //    if (gameOver)
            //    {
            //        Console.WriteLine("****************Game over*********************************");
            //        break;
            //    }
            //    else
            //    { if (i >= 9)
            //        {
            //            Console.WriteLine("No one has won. Better luck next time");
            //            Console.WriteLine("****************Game over*********************************");
            //        }

            //    }
            //}             
            //Jagged JG = new Jagged();
            //JG.IntroduceFamily();

            //PostInheritence PI = new PostInheritence("Thanks for the Birthday Wishes", "Tuhina", true);
            //Console.WriteLine(PI.ToString());
            //PostImageInheritence PII = new PostImageInheritence("Check out the shoes", "Tuhina", "https://www.google.com/Gpay", true);
            //Console.WriteLine(PII.ToString());
            ////Console.WriteLine(((PostInheritence)(PII)).ToString());
            //VideoPostInheritence VPI = new VideoPostInheritence("check the video","Tuhina","https://www.google.com/video",true,20);
            //Console.WriteLine(VPI.ToString());
            //Interface1 I1 = new Algorithm();
            //I1.X = 49;
            //I1.Y = 6;

            //int a = I1.Substraction(I1.X, I1.Y);
            //int b = I1.Summation(I1.X, I1.Y);
            //int c = I1.Modulus(I1.X, I1.Y);

            //Interface2 I2 = new Algorithm();

            //int d = I2.Modulus(I1.X, I1.Y);
            //int e = I2.Division(I1.X, I1.Y);
            //int f = I2.Multiplication(I1.X, I1.Y);

            //Console.WriteLine(" I1.X:{0}, I1.Y{1}", I1.X, I1.Y);
            //Console.WriteLine(" Sub:{0}, Sum{1}, Mod1{2}, Mod2{3}, DIV{4}, Mult{5}", a, b, c, d, e, f);
            //Algorithm A1 = new Algorithm();
            //int l = ((Interface1)A1).Modulus(30, 7);
            //Console.WriteLine("l:{0}", l);
            //Console.Read();

            //TextFiles TF = new TextFiles();
            //TF.ReadWriteFiles();
            //EnumExamples.EnumMethod();
            //RandomClass.RandomNumber();
            //RegularExpress.RegularExpmethod();
            DateTimeExamp.DateTimemethod();
            Console.ReadKey();
        }
    }
}
