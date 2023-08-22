using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class ADD_Of_Factorial
    {
        static void Main(string[] args)
        {
           //Sum of factorial.
            Console.WriteLine($"Enter Number");
            int num=Convert.ToInt32( Console.ReadLine() );

            int sum = 0;
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
                sum = sum + fact;
              
            }
            Console.WriteLine(sum);



        }
    }
}
