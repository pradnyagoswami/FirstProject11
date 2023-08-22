using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class IpperTOLowercs
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter character");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
                Console.WriteLine($"{ch} ");
            }
            else if(ch >='a'&& ch<='z')
            {
                ch = (char)(ch - 32);
            }



        }
    }
}
