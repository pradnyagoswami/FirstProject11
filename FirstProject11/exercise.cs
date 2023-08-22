using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class exercise
    {
        static void Main(String[] args)
        {
            //1 > write code to disply table between 1 to 5

            Console.WriteLine("Enter table Number");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + "*" + (j) + "=" + (i * j));

                }

            }

            //2>write code to disply all the prime numbers between 1 to 10


            //for (int i = 1; i <= 10; i++)
            //{
            //    bool isprime = true;

            //    for (int j=2; j <i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isprime = false;
            //            break;
            //        }
            //    }

            //    if (isprime == true)
            //    {

            //        Console.WriteLine(i);

            //    }






















        }








        }




    }

