using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a string:");
            int num =Convert.ToInt32( Console.ReadLine());

            
            int sum = 0;
            while (num > 0)
            {
               int digit= num % 10;
                sum+=digit;
                num /= 10;
            }
            
            Console.WriteLine("the sum of the digits:" + sum);
            Console.ReadKey();
        }
    }
}
