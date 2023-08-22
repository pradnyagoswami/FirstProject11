using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Whileloop
    {


        static void Main(string[] args) 
        {
            static void Main(string[] args)
            {
                //Print number from 1- 10

                //int a = 1;
                //while (a <= 10)
                //{
                //    Console.WriteLine(a);
                //    a++;

                //}


                //Print even number from 1 to 100 (if)

                //int b = 1;
                //while (b<=100)
                //{

                //    if (b % 2 == 0)
                //    {
                //        Console.WriteLine(b);


                //    }
                //    b++;


                //}


                //Print odd number from 1- 50 (if)
                //int c = 1;
                //while (c <= 50)
                //{
                //    if (c % 2 != 0)
                //    {
                //        Console.WriteLine(c);
                //    }
                //    c++;

                //}


                //Print the table to a number
                Console.WriteLine($"Enter number");
                int x = Convert.ToInt32(Console.ReadLine());
                int d = 1;
                while (d <= 10)
                {
                    int y = d * x;
                    Console.WriteLine($"{x}*{d}={y}");
                    d++;
                }


                //Print 1- 10 & its sum

                //int sum = 0;
                //int f = 1;
                //while (f <= 10)
                //{
                //    sum = sum + f;
                //    Console.WriteLine(f);
                //    f++;
                //}
                //Console.WriteLine($"sum of above Numbers ={sum}");





            }





        }

    }
}
