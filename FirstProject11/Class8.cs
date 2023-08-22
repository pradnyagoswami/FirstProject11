using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int x = ++a + ++b;              
            Console.WriteLine($" value of x ={x} value of a ={a} value of b ={b}");

            x = ++a  -  b--;
            Console.WriteLine($" value of x ={x} value of a ={a} value of b ={b}");


            x = ++a - b++;
            Console.WriteLine($" value of x ={x} value of a ={a} value of b ={b}");


            x = --a - --b - a;
            Console.WriteLine($" value of x ={x} value of a ={a} value of b ={b}");


            x = b++ - a-- + b;
            Console.WriteLine($" value of x ={x} value of a ={a} value of b ={b}");


            x = ++a + ++b - b;
            Console.WriteLine($" value of x ={x} value of a ={a} value of b ={b}");









        }

    }
}
