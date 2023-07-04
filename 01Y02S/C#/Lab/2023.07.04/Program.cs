using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            number obj = new number();
            int[] a= obj.array(size);

            
            Console.WriteLine("The array values are:");
            foreach(int value in a)
            {

                Console.Write(value + " ");
            }
            Console.ReadLine();
        }
    }
}
