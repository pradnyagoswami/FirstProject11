using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Swap_Without_thirdvariablecs
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Enter first number");
            int A=Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"Enter second number");
            int B=Convert.ToInt32( Console.ReadLine() ) ;
            Console.WriteLine($"Before Swapping A={A} B={B}");

            A = A + B;
            B = A - B;
            A= A - B;
            Console.WriteLine($"After Swapping A={A} B={B}");










        }

    }
}
