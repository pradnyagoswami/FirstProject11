using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n=Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            
            }
            Console.WriteLine(fact);




        }
    }
}
