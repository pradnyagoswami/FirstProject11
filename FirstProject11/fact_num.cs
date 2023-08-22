using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class fact_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter Number");
            int num=Convert.ToInt32( Console.ReadLine() );
            int fact = 1;
            int i = 1;
            while (i<=num)
            {
                
                if (num % i == 0)
                {
                    Console.WriteLine(i);

                }
                

                i++;


            }




        }

        
    }
}
