using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class sumOfEvenNumber
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                { 
                sum = sum + i;


                }
                Console.WriteLine(i);


            }
            Console.WriteLine($"sum of above even number={sum}");



        }
    }
}
