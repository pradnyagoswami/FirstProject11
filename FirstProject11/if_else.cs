using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class if_else
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a day");
            int day=Convert.ToInt32(Console.ReadLine());

            if (day == 0)
            {
                Console.WriteLine($"sunday");
            }
            else if (day == 1)
            {
                Console.WriteLine($"monday");
            }
            else if (day == 2)
            {
                Console.WriteLine($"tuesday");
            }
            else if (day == 3)
            {
                Console.WriteLine($"wednesday");

            }
            else if (day == 4)
            {
                Console.WriteLine($"thursday");
            }
            else if (day == 5)
            {
                Console.WriteLine($"friday");
            }
            else if (day == 6)
            {
                Console.WriteLine($"saturday");
            }
            else 
            {
                Console.WriteLine($"wrong nuber");
            }




        }
    }
}
