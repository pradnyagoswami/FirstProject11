using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class desariam_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int sum = 0;
             int temp = num;

            while (num > 0)//89
            {
                count++;
                num = num / 10;
            }
            num = temp;
            while (num > 0)
            {
                int digit = num % 10;
                int power = 1;
                for (int i = 1; i <= count; i++)
                {

                    power = power * digit;

                }
                sum = sum + power;
                count--;
                num = num / 10;
            }
                if (temp == sum)
                {
                    Console.WriteLine("number is desarian");
                }
                else 
                {
                    Console.WriteLine("number is not desarian");


                }
            
            
            
            }


        }
    }

