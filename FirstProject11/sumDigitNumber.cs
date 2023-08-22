using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class sumDigitNumber
    {
        static void Main(string[] args)
        {
            //Find the sum of all digits of a number.  → 123 ⇒ 1 + 2 + 3 → 6

            Console.WriteLine($"Enter Number");
            int num=Convert.ToInt32( Console.ReadLine() );
            int sum = 0;
            while (num != 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine(sum);




        }
    }
}
