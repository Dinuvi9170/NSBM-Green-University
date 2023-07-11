using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            Operation obj = new Operation();
            obj.Setnum1(num1,num2);
            Console.WriteLine("the summation:"+obj.getSum());
            Console.WriteLine("the substraction:" + obj.getSub());
            Console.WriteLine("the multipication:" + obj.getMul());
            Console.WriteLine("the division:" + obj.getDiv());


            Console.ReadKey();
        }
    }
}
