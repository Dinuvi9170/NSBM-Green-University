using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_4
{
    internal class array
    {
        private int[]  numbers;

        public int Findvalues(int[] array)
        {
            numbers = array;

            
             int sum =0;
            for (int i =0;i<10;i++)
            {
              sum =sum+ numbers[i];
            }
            return sum;
            
            
        }
         
        public int findV(int[] array)
        {
            int min = numbers[0];
            for (int i=0;i<10;i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                } 
            }
            
            return min;
        }
        public int findV1(int[] array)
        {
            int max = numbers[0];
            for (int i = 0; i < 10; i++)
            {
                if (max< numbers[i])
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }
}
