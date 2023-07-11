using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace my_program
{
    internal class Operation
    {
        private double number1;
        private double number2;

        public void Setnum1(double num1,double num2)
        {
            number1 = num1;
            number2 = num2;
        }
        
        public double getSum()
        {
            return number1+number2;
        }
        public double getSub()
        {
            return number1 - number2;
        }
        public double getMul()
        {
            return number1 * number2;
        }
        public double getDiv()
        {
            return number1 /number2;
        }
    }
}  
