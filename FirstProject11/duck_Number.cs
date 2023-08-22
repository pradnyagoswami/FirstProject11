using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class duck_Number
    {
        static void Main(string[] args)
        {

           // 3 > WA code to check the number is duck number

            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int rem = 0;

            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;

                if (rem == 0)
                {

                    count++;
                }
            }
                if (count == 1)
                {
                    Console.WriteLine("the number is  duck number");
                }
                else
                {
                    Console.WriteLine("the number is not duck");

                }


            }

            
           


        }
    }

