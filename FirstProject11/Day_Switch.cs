using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Day_Switch
    {
        static void Main(String[] args)
        {
            Console.WriteLine($"Enter a Number");
            int day=Convert.ToInt32( Console.ReadLine() );

            switch (day)
            {
                case 1:
                    Console.WriteLine($"Sunday");
                    break;

                case 2:
                    Console.WriteLine($"Monday");
                    break;

                case 3:
                    Console.WriteLine($"Tuesday");
                    break;
      
                case 4:
                    Console.WriteLine($"wendesday");
                    break;

                case 5:
                    Console.WriteLine($"Thursday");
                    break;

                case 6:
                    Console.WriteLine($"Friday");
                    break;

                case 7:
                    Console.WriteLine($"Saturday");
                    break;

                default:
                    Console.WriteLine($"Invalid choice");
                    break;










            }





        }
    }
}
