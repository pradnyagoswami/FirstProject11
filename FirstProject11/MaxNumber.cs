using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class MaxNumber
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Enter num1");
            //int num1=Convert.ToInt32( Console.ReadLine() );
            //Console.WriteLine($"Enter num2");
            //int num2=Convert.ToInt32( Console.ReadLine() );
            //Console.WriteLine($"Enter num3");
            //int num3=Convert.ToInt32( Console.ReadLine() );
            int num1 = 5;
            int num2 = 16;
            int num3 = 7;

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"num1 is grater");

            }
            else if (num2 > num3)
            {
                Console.WriteLine($"num2 is greater");

            }
            else 
            {
                Console.WriteLine($"num3 is greater");
            }




        }
    }
}
