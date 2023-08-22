using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class prime_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter Number");
            int num=Convert.ToInt32( Console.ReadLine() );
            int count = 0;
            int i = 1;
            while (i <= num)
            {

                if (num % i == 0)
                {
                    count++;

                }
                i++;
                }
            if (count == 2)
            {
                Console.WriteLine($"it is prime");
            }
            else 
            {
                Console.WriteLine($"it is not prime");
            }



        }
    }
}
