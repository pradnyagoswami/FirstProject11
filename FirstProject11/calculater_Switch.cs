using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class calculater_Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Adiition 1");
            Console.WriteLine($"Substraction 2");
            Console.WriteLine($"Multiplication 3");
            Console.WriteLine($"Division 4");
           


            Console.WriteLine($"Enter case");
            int ch=Convert.ToInt32( Console.ReadLine() );


            int c = 0;
            switch (ch)
            {
                case 1:
                    Console.WriteLine($"Enter num 1");
                    int a=Convert.ToInt32( Console.ReadLine() );
                    Console.WriteLine($"Enter num 2");
                    int b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine($"addition ={c}");
                    break;

                case 2:
                    Console.WriteLine($"Enter num 1");
                    int e = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter num 2");
                    int f = Convert.ToInt32(Console.ReadLine());
                    c = e - f;
                    Console.WriteLine($"substraction ={c}");
                    break;

                case 3:
                    Console.WriteLine($"Enter num 1");
                    int k = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter num 2");
                    int u = Convert.ToInt32(Console.ReadLine());
                    c = k * u;
                    Console.WriteLine($"Multiplication ={c}");
                    break;

                case 4:
                    Console.WriteLine($"Enter num 1");
                    int j = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter num 2");
                    int v = Convert.ToInt32(Console.ReadLine());
                    c = j / v;
                    Console.WriteLine($"division {c}");
                    break;

                default:
                    Console.WriteLine($"invalid choice");
                    break;



            }

        }
    }
}
