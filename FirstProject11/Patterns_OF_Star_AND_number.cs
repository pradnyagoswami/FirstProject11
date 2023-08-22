using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Patterns_OF_Star_AND_number
    {

        static void Main(string[] args)
        {
            //1
            //23
            //456
            //78910
            //int n = 1;
            //for (int i = 1; i <= 4; i++)//row
            //{
            //    for (int j = 1; j<= i; j++)//colunm
            //    {
            //        Console.Write(n);
            //        n++;
            //    }
            //    Console.WriteLine();
            //}


            //1
            //10
            //101
            //1010
            //10101

            
            for (int i = 1; i <= 5; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(j);
                    
                }
                
                Console.WriteLine();


            }

        
        
        }
    }
}
