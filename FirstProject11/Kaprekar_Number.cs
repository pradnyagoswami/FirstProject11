using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Kaprekar_Number
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            int sq = num * num;
            int copy = num;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            int power = 1;
            for (int i = 1; i <= count; i++)
            {
                power = power * 10;
            }
            int end = sq % power;
            int start = sq / power;
            int result = end + start;
            Console.WriteLine(result);
            if (result == copy)
            {

                Console.WriteLine("Number is kaprekar");
            }
            else 
            {

                Console.WriteLine("number is not kaprekar");
            }






        }
            






        }



    }

