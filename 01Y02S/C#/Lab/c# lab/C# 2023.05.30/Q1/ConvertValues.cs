using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertion
{
    internal class ConvertValues
    { 
        //no return no parameters
        public void kilometerTometer()
        {
            Console.Write("enter the distance in kilometer:");
            double km = Convert.ToDouble(Console.ReadLine());
            double m = km * 1000;
            Console.WriteLine("The distance in meters:" + m+"m");
            
        }
      
    }
}
