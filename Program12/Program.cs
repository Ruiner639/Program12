 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Program12
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\1392659\Desktop\test1\12.txt";//path where the file was created
            using (StreamWriter sw = new StreamWriter(path, true)) //math instruction
            {
                sw.WriteLine(3.1);//
                sw.WriteLine("+");
                sw.WriteLine(2.3);
            };
            double a;
            string operation;
            double b;

            using (StreamReader sr = new StreamReader(path, true))//reading information from a file
            {
                a = Convert.ToDouble(sr.ReadLine());//assigning information from a file
                operation = sr.ReadLine();
                b = Convert.ToDouble(sr.ReadLine());
            };
            switch (operation)//choosing the right solution
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
            }
            File.Delete(path);//it is necessary to delete the file so that there are no errors when replaying the code
        }
    }
}
