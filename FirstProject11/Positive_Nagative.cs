using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Positive_Nagative
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a number");
            int num=Convert.ToInt32( Console.ReadLine() );

            if (num < 0)
            {

                Console.WriteLine($"number is nagative");


            }
            else if (num > 0)
            {
                Console.WriteLine($"number is positive");
            }
            else {
                Console.WriteLine($"number is zero");
            }



        }
    }
}
