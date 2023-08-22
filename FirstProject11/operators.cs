using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class operators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second  number");
            int b = Convert.ToInt32(Console.ReadLine());


            int c = a + b;
            Console.WriteLine($" addition of a+b is {c}");

            int d = a - b;
            Console.WriteLine($" substraction of a-b is {d}");

            int e = a * b;
            Console.WriteLine($" multiplication of a*b is {e}");

            double f =(double) a / b;
            Console.WriteLine($" division of a/b is {f}");

            int g = a % b;
            Console.WriteLine($"mod of a%b is {g}");








        }
    }
}
