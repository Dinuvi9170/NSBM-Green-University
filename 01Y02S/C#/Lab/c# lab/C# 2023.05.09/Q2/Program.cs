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

            Console.WriteLine("Enter the radius:");
            double r = Convert.ToDouble(Console.ReadLine());
            const double PI = 3.14;
            double area = PI * r * r;
            Console.WriteLine("The area of the circle: " + area);
           
            Console.ReadKey();
        }
    }
}
