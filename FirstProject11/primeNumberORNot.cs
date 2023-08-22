using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class primeNumberORNot
    {
        static void Main(String[] args)
        {

            Console.WriteLine($"Enter Number");
            int num=Convert.ToInt32( Console.ReadLine() );
            int a = 0;
            for (int i=2; i<num/2; i++)
            {
                if (num % i == 0)
                {
                    a = 1;
                    break;
                }
             }
            if (a == 0)
            {
                Console.WriteLine($"Its prime");
            }
            else
            {
                Console.WriteLine($"Its not  prime");
            }



        }
    }
}
