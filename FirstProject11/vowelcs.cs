using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class vowelcs
    {
        static void Main(String[] args)
        {
            Console.WriteLine($"Enter a character");
            char  ch=Convert.ToChar( Console.ReadLine() );

            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine($"it's vowel {ch}");


            }
            else 
            {
                Console.WriteLine($"it's consonent");

            }


        }
    }
}
