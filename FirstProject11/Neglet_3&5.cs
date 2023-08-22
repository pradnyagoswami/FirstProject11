using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Neglet_3_5
    {
        static void Main(String[] args)
        {

            //write code to disply number between 1 to 20 neglet the numbers which is divisible by 3 and 5
            //By forloop.
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 3==0 && i % 5==0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);


            //}


            //By WhileLoop
            int i = 1;
            while (i <= 20)

            {

                if (i %3== 0 && i % 5 == 0)
                {
                    i++;
                    continue;
                    
                
                }
                
                Console.WriteLine(i);
                i++;


            }









        
        
        }
    }
}
