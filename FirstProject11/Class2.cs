using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    internal class Class2
    {
        static void Main(String[] args)
        { 
          int rollNO = 12;
          int id = 123;

            Console.WriteLine("Student roll number is "+rollNO+" Student id is "+id);

            Console.WriteLine($"Student roll no is {rollNO} student id is {id}");

            Console.WriteLine("student roll no is {0} student id is {1}",rollNO,id);


        }
    }
}
