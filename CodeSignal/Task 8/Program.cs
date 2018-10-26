using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(matrixElementsSum(new int[][] { new int[] {0, 1, 1, 2},
                                                              new int [] { 0, 5, 0, 0 },
                                                              new int[] { 2, 0, 3, 3 }}));
            Console.ReadKey();
        }
        static int matrixElementsSum(int[][] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[j][i] == 0)
                        break;
                    sum = sum + matrix[j][i];
                }
            }
            return sum;
        }
    }
}