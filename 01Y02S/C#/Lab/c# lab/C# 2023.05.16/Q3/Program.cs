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
            Console.Write("enter the radius:");
            double r = Convert.ToDouble(Console.ReadLine());


            const double PI = 3.14;
            double area = PI * r * r;
            double cir = 2 * PI * r;

            Console.WriteLine("The area of the circle:" + area);
            Console.WriteLine("The circumference of the circle:" + cir);




            Console.ReadKey();
        }
    }
}
