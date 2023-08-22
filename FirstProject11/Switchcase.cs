using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Switchcase
    {
        static void Main(String[] args)
        {
            Console.WriteLine($"Enter first Number");
            int num1=Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"Enter second Number");
            int num2=Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine($"Enter your choise");
            int menu=Convert.ToInt32( Console.ReadLine() );

            switch(menu) 
            {
                case 1:
                    int add = num1 + num2;
                    Console.WriteLine($"addition = {add}");
                    break;

                case 2:
                    int sub = num1 - num2;
                    Console.WriteLine($"addition = {sub}");
                    break;

                case 3:
                
                    int mul = num1 * num2;
                    Console.WriteLine($"addition = {mul}");
                    break;
                case 4:
               
                    int div = num1 / num2;
                    Console.WriteLine($"addition = {div}");
                    break;
                case 5:
                     int mod = num1 % num2;
                    Console.WriteLine($"addition = {mod}");
                    break;

                default:
                    Console.WriteLine($"input is wrong");
                    break;




            }










        }
    }
}
