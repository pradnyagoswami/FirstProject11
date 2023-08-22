using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Alphabate {

        static void Main(string[] args)
        {
            Console.WriteLine($"Enter character");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine($"it is uppercase");
            }
            else if(ch>='a'&& ch<='z')
            {
                Console.WriteLine($"it is lowecase");
            }





        }

    }
}
