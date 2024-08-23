using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class MathOperation
    {
        private int num1;
        private int num2;

        public MathOperation(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        private int add()
        {
            return num1 + num2;
        }

        private int sub()
        {
            return num1-num2; 
        }

        private int mul()
        {
            return num1 * num2;
        }
        private double div()
        {
            return num1 / num2;
        }

        public void Display()
        {
            Console.WriteLine("addition : "+add());
            Console.WriteLine("subtraction : "+sub());
            Console.WriteLine("multiplication : "+mul());
            Console.WriteLine("division : "+div());
            

        }

        
    }

}
