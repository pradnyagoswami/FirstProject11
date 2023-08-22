using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class prime_1to100
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter number");
            int n=Convert.ToInt32(Console.ReadLine());
             for (int i= 11; i <= n; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                     if (i % j == 0)
                    {
                        count++;
                    }
                
                }
                if (count == 2)
                {
                  Console.WriteLine(i);
                }
            
            
 }









        }
    }
}
