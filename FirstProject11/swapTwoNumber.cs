using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class swapTwoNumber
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a first number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"before swapping numbers num1={num1} num2={num2}");
            int num3 = 0;

            num3 = num1;
            num1= num2;
            num2= num3;
            Console.WriteLine($"after swapping numbers num1={num1} num2={num2}");




        }
    }
}
