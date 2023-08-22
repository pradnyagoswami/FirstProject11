using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class DivisibleBy_11_1to25
    {
        static void Main(String[] args)
        {
            //write code to disply number between 1 to 25 if any number is divisible by 11 then stop the disply process.
            //ForLoop
            //for (int i = 1; i <= 25; i++)
            //{
            //    if (i % 11 == 0)
            //    {

            //        break;
            //    }
            //    Console.WriteLine(i);

            //}


            //ForWhile Loop
            int i = 1;
            while (i <= 25)
            {
                if (i % 11 == 0)
                {
                    
                    break;
                
                }
                Console.WriteLine(i);
                i++;


            }








        }
    }
}
