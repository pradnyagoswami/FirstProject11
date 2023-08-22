using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class AramStrong
    {

        static void Main(String[] args)
        {

            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int temp = num;

            while (num > 0)
            { 
             int digit=num % 10;
                int cube = digit * digit * digit;
                sum = sum + cube;
                num = num / 10;

            
            }
            num = temp;
            if (num == sum)
            {

                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong");
            }







        }
    }
}
