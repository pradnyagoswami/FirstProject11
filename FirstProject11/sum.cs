using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class sum
    {
        static void Main(string[] args)
        {
            // Print 1 - 10 & its sum
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine(i);
                sum = sum + i;



            }
            Console.WriteLine($"sum of 1 to 10 ={sum}");


        }
    }
}
