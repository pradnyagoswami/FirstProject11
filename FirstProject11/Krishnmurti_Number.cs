using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Krishnmurti_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while (num != 0)
            {
                int rem = num % 10;
                int fact = 1;
                for (int i = 1; i <= rem; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            Console.WriteLine(sum);
            if (temp == sum)
            {
                Console.WriteLine("Krishnmurti number");
            }
            else 
            {

                Console.WriteLine("not krishnmurti number");
            }


           




        }
    }
}
