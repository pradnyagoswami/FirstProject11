using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class AvgOfOdd_DigitNumber
    {
        static void Main(String[] args)
        {
            //WAP to calculate avg of odd digit from number.
            Console.WriteLine($"Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while (num != 0)
            {
                int rem = num % 10;
                num = num / 10;

                if (rem % 2 != 0)
                {
                    
                    sum = sum + rem;
                    count++;
                    Console.WriteLine(rem);

                }
              
            }
            int avg = sum / count;
            Console.WriteLine("Avrage = "+avg);




        }
    }
}
