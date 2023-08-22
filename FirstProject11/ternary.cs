using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class ternary
    {
        static void Main(string[] args)
        {
            // find out max of two number
            // Console.WriteLine("Enter num1 ");
            //int num1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter num2");
            //int num2=Convert.ToInt32(Console.ReadLine());
            //string max = (num1 > num2) ? "num1 " : "num2 ";
            //Console.WriteLine($"grater number is {max}");





            ////write code to check the given number is divisible by 3 or not

            //Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //String div = (num % 3 == 0) ? "divisible by 3" : "non-divisible by 3";
            //Console.WriteLine($"This number is {div}");



            ////write code character is upper case later or lower case later using ternary

            Console.WriteLine("Enter a character");
            char ch = Convert.ToChar(Console.ReadLine());

            String result = (ch >= 'A' && ch <= 'Z') ? "upper case" : "Lower case";
            Console.WriteLine(result);





        }
    }
}
