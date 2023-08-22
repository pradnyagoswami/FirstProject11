using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class star
    {

        static void Main(String[] args)
        {

            //   *
            //  **
            // ***
            //****
            //for (int i = 1; i <= 4; i++)
            //{
            //  for (int k = 4; k >= i; k--)
            //    {
            //     Console.Write(" ");
            //    }
            //  for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //





            //****
            // ***
            //  **
            //   *
            //for (int i = 1; i <= 4; i++)
            // {
            //     for (int k = 4; k >= i; k--)
            //     {
            //         Console.Write("*");
            //     }
            //     for (int j = 1; j <= i; j++)
            //     {
            //         Console.WriteLine(" ");
            //     }
            //     Console.WriteLine();
            // }





          //  *
          //  *
          //*****
          //  *
          //  *
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 3 || j == 3)
                    {
                        Console.Write("*");

                    }
                    else 
                    {
                        Console.Write(" ");

                    }
                    Console.Write(" ");
                }
                Console.WriteLine();


            }



















        
        
        
        }
    }
}
