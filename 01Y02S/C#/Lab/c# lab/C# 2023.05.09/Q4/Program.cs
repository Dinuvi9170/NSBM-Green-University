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

            Console.Write("Enter salary:");
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the tax rate(%):");
            double tax = Convert.ToDouble(Console.ReadLine());
            sal -= (sal * tax) / 100;
           
            Console.WriteLine("The salary after the tax: " + sal);
           
            Console.ReadKey();
        }
    }
}
