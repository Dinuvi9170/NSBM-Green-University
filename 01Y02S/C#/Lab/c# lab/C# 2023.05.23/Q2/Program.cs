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
            Console.Write("enter a string:");
            string array = Console.ReadLine();

            int vowel = 0;
            foreach (char c in array.ToLower())
            {
                if ("aeiou".Contains(c))
                    vowel++;
            }
            Console.WriteLine("the total number of vowels:" + vowel);
            Console.ReadKey();
        }
    }
}
