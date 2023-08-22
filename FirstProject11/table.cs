using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class table
    {
        static void Main(string[] args)
        {
            //Print the table to a number

            Console.WriteLine($"Enter table");
            int t=Convert.ToInt32( Console.ReadLine() );

            for (int i = 1; i <= 10; i++)
            {
                int d= i * t;
                Console.WriteLine($"{t}*{i}={d}");

            }

        }
    }
}
