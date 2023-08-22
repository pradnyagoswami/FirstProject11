using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Sum_Prime_digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                int rem = n % 10;
                bool isprime = true;
                for (int i = 2; i < rem; i++)
                {
                    if (rem % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                  sum = sum + rem;
                }
                n = n / 10;
            }
            Console.WriteLine(sum);




        }
    }
}
