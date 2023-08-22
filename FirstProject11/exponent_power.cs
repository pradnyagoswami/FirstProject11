using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class exponent_power
    {
        static void Main(String[] args)
        {
            Console.WriteLine($"enter exponent ");
            int exp=Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"Enter power");
            int pow=Convert.ToInt32( Console.ReadLine() );

            int ans = 1;
            for (int i = 1; i <= exp; i++)
            {
                ans = ans * pow;
            
            }
            Console.WriteLine(ans);


        }
    }
}
