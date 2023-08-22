using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Alphabate_Digit_Special
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter Character");
            char ch=Convert.ToChar(Console.ReadLine());

            if (ch >= 'A' && ch <= 'Z' || ch>='a'&&ch<='z' )
            {
                Console.WriteLine($"It is Alphabate");
            }
            else if (ch >= '0' && ch <= '9')
            {

                Console.WriteLine($"it is digit");
            }
            else
            {
                Console.WriteLine($"it is special character");


            }



        }
    }
}
