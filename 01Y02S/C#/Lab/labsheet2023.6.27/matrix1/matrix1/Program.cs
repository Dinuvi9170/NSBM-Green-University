using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2, 2] { { 2, 3 }, { 4, 1 } };
            int[,] matrix2 = new int[2, 2] { { 5, 2 }, { 6, 3 } };

            int[,] result = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            Console.WriteLine("Resultant Matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
