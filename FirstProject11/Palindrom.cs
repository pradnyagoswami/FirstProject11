using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Palindrom
    {
        static void Main(string[] args)
        { 
        Console.WriteLine($"Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int rev = 0;
            
            int temp = num;
            while (num != 0)
            {
                int rem= num% 10;
                rev = (rev * 10) + rem;
               num = num / 10;
            }
            if (temp== rev)
            {
                Console.WriteLine($"It is palindrom Number");
            }
            else 
            {
                Console.WriteLine($"It is not palindrom number");
            }

            }
}
}
