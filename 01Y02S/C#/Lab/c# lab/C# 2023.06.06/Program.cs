using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] numbers =  { 1, 2, 3,4, 5, 6, 7, 8, 9, 10 };
            array obj = new array();
            double sum = obj.Findvalues(numbers);
            double avg = sum / 10;
            int min = obj.findV(numbers);
            Console.WriteLine("the minimum value:" +min);
            int max = obj.findV1(numbers);
            Console.WriteLine("the maximum value:" +max );
            Console.WriteLine("the average:" + avg);
            Console.ReadLine();

        }
    }
}
