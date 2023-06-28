using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace labsheet20236._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[5];
            double sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("enter a number:");
                arr[i] = Convert.ToDouble(Console.ReadLine());
                 sum += arr[i];
            }
            Console.WriteLine("the summation:" + sum);

            double min = arr[0];
            double max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("the minimum number:" + min);
            Console.WriteLine("the maximum number:" + max);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
               
            }
            Console.WriteLine();
            Console.WriteLine("the sorted array(asending order):");
            for (int i = 0; i < arr.Length; i++)
            {
               for(int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[j] < arr[i] )
                    {
                        double temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }

            }
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("the sorted array(desending order):");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[j] > arr[i])
                    {
                        double temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }

            }
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");

            }
            int[,] arr1 = { { 2, 3 }, { 3, 4 } };
            int mini = arr1[0, 0];
            int maxi = arr1[0, 0];
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    if (arr1[i, j] < mini)
                    {
                        mini = arr1[i, j];
                    }
                    if (arr1[i, j] > maxi)
                    {
                        maxi = arr1[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("the minimum number of array1:" + mini);
            Console.WriteLine("the maximum number of array1:" + maxi);




            Console.ReadLine();

        }
    }
}
