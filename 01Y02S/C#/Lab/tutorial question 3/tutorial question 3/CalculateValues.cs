using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tutorial_question_3
{
    internal class CalculateValues
    {
        public double addition(double num1, double num2)
        {
            
            double add = num1 + num2;
            return add;
        }
        public double substraction(double num1, double num2)
        {
            double sub = num1 - num2;
            return sub;
        }
        public double multipication(double num1, double num2)
        {
            double mul = num1 * num2;
            return mul;
        }
        public double division(double num1, double num2)
        {
            double div = num1 / num2;
            return div ;
        }
    }
}
