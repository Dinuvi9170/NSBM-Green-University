using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the distance in kilometer:");
            double km = Convert.ToDouble(Console.ReadLine());
            ConvertValues obj = new ConvertValues();
            obj.kilometerTometer(km);
            Console.ReadKey();
        }
    }
}
