using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject11
{
    public  class ArithMatic_Operation
    {

        private int a,b,c,x,y,z;
        public void Accept(int a,int b)
        {
           this.a = a;
            this.b=b;
        
        
        }

        public int Addition()
        {

             c = a + b;
            return c;

        }
        public int Substraction()
        {
            z = a - b;
            return z;
        
        }
        public int Multiplication() 
        {
         y=a * b;
            return y;
        
        }
        public int Division() 
        {
           x=b / a;  
            return x;
        
        
        }
        public String Show()
        {
            return $"{c},{x},{y},{z}";
        
        }
        





        static void Main(string[] args)
        { 
        
        
        ArithMatic_Operation arith = new ArithMatic_Operation();
            arith.Accept(5,6);
            Console.WriteLine(arith.Show());
        
        
        
        
        
        
        
        
        }


    }
}
