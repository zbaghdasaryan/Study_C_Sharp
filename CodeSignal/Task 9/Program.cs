//Given an array of strings, return another array containing all of its longest strings.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            matrixElementsSum(new string[] { "sa", "sdf", "dfg", "a" });
            Console.ReadKey();
        }
        static string [] matrixElementsSum(string[] matrix)
        {
            int max = 0;
            int count = 0;
            for (int i = 0; i < matrix.Length; i++)
                if (matrix[i].Length > max)
                {
                    max = matrix[i].Length;
                    count = 1;
                }
                else if (matrix[i].Length == max)
                    count++;

            string[] newarray = new string[count];
            int j = 0;
            for (int i = 0; i < matrix.Length; i++)
                if (matrix[i].Length == max)
                {
                    newarray[j] = matrix[i];
                    j++;
                }
            return newarray;     
            
        }       
    }
}
