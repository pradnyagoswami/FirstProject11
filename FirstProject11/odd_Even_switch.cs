using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class odd_Even_switch
    {
        static void Main(String[] args)
        {
            Console.WriteLine($"Enter Number");
            int num=Convert.ToInt32( Console.ReadLine() );
            
           switch (num%2) 
            {
                case 0:
                    Console.WriteLine($"Even number");
                    break;
                default:
                    Console.WriteLine($"it is odd");
                    break;
                    







            }





        }
    }
}
