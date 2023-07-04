using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capital
{
    internal class number
    {
        public int[] array(int size)
        {
            int[] a = new int[size * 2];
            for (int i = 0; i < a.Length; i+=2)
            {
                Console.Write("enter the value :");
                int value = Convert.ToInt32(Console.ReadLine());
                a[i] = value;
                a[i + 1] = 0;
            }
            return a;
        }
    }
}
