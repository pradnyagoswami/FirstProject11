using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            // Accept a number from user And check whether number is positive or nagative
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            string num = (x > 0) ? " positive" : "nagative";
            Console.WriteLine($"number is {num}");


            //Accept a number from user and check whether number is even or odd
            Console.WriteLine("Enter a number ");
            int num1=Convert.ToInt32(Console.ReadLine());
            String A = (num1 %2 ==0) ? "even" : "odd";
            Console.WriteLine($" number is {A}");




        }


    }
}
