using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AdditionTask17122019
{
    class TextFiles
    {
        
        public void ReadWriteFiles()
        {
            /*
            //Read all lines in a file
            Console.WriteLine("----------------The first way of reading the file--------------");
            string file1 = System.IO.File.ReadAllText(@"C:\Users\kiran\Desktop\C#.txt");
            Console.WriteLine("The data in file1 is  below \n{0}", file1);

            //Read all lines in a line
            Console.WriteLine("----------------The second way of reading the file--------------");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\kiran\Desktop\C#.txt");
            
            Console.WriteLine("The data in lines is  below");
            foreach (string str in lines)
            {
                Console.WriteLine(str);
            }
            */
            string[] lines = new string[] { "first line", "second line", "third line" };
            File.WriteAllLines(@"C:\Users\kiran\Downloads\WriteFile1.txt", lines);

            File.AppendAllLines(@"C:\Users\kiran\Downloads\WriteFile1.txt", lines);

            using (StreamWriter file = new StreamWriter(@"C:\Users\kiran\Downloads\WriteFile2.txt", true))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }

            }
        }       
    }
}
