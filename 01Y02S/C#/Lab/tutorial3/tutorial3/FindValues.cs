using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tutorial3
{
    internal class FindValues
    {
        public double findArea(double radius)
        {
             const double  PI = 3.14;
            double area = PI * radius * radius;
            return area;
        }
        public double findcircumference(double radius)
        {
            const double PI = 3.14;
            double cir = 2 * PI * radius;
            return cir;
        }
    }
}
