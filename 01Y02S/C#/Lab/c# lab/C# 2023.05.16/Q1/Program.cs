using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("The summation:" + sum);
            Console.ReadKey();
        }
    }
}
