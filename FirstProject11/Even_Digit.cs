using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Even_Digit
    {
        static void Main(String[] args)
        {
            //write code to disply even digit from the given numbers.

            Console.WriteLine($"Enter Number");
            int num=Convert.ToInt32( Console.ReadLine() );

           while (num !=0)
            {
                int rem = num % 10;

                if (num % 2 == 0)
                {
                    Console.WriteLine(rem);
                }
                num = num / 10;

             }

        }
    }
}
