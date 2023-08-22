using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class switch_vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter character");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {

                case 'a':
                case 'A':
                    Console.WriteLine($"It is vowel {ch}");
                    break;

                case 'e':
                case 'E':
                    Console.WriteLine($"It is vowel {ch}");
                    break;

                case 'i':
                case 'I':
                    Console.WriteLine($"It is vowel {ch}");
                    break;

                case 'o':
                case 'O':
                    Console.WriteLine($"It is vowel {ch}");
                    break;

                case 'u':
                case 'U':
                    Console.WriteLine($"It is vowel {ch}");
                    break;

                default:
                    Console.WriteLine($"it is consonent");
                    break;




            }
        
        
        
        
        
        }
    }
}
