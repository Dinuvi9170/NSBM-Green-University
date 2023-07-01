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
            Console.Write("enter an integer:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else
            {
                Console.WriteLine("This is an odd number");
            }
            Console.ReadKey();
        }
    }
}
