using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the radius of the circle:");
            double radius = double.Parse(Console.ReadLine());
            
            FindValues objfind = new FindValues();
            double area= objfind.findArea(radius);
            
            Console.WriteLine("The area of the circle :"+area);
            double cir = objfind.findcircumference(radius);
            Console.WriteLine("The area of the circle :" +cir);

            Console.ReadLine();
        }
    }
}
