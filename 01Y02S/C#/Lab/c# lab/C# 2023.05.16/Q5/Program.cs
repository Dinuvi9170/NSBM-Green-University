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
            
            for(int i = 0; i < 10; i++)
            {
                Console.Write("enter a number:");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("This is an even number");
                }
                else
                {
                    Console.WriteLine("This is an odd number");
                }
            }
           

            Console.ReadKey();
        }
    }
}
