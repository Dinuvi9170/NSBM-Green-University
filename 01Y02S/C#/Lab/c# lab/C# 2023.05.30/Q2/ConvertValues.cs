using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertion
{
    internal class ConvertValues
    { 
        //no return with parameters
        public void kilometerTometer(double km)
        {
           
            double m = km * 1000;
            Console.WriteLine("The distance in meters:" + m+"m");
            
        }
      
    }
}
