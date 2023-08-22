using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Avg_DigitNumber
    {

        static void Main(String[] args)
        {
            //find the avg of digit from the number.

            Console.WriteLine($"Enter Number");
            int num=Convert.ToInt32( Console.ReadLine() );
            int sum = 0;
            int count = 0;
            while (num>0)
            {
                int digit = num % 10;
                sum = sum + digit;
                count++;
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);

                }
                num = num / 10;
            
            }
            int avg=sum/count;
            Console.WriteLine(sum);




        }
    }
}
