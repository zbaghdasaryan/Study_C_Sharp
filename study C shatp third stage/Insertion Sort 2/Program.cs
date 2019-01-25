using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[3];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("unsorted array numbers is :");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            InsertionSort(array);
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j >0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("sorted array numbers is : " );
            
            foreach (var item in array)
            {
                Console.Write(item+ " ");
            }
        }

       
    }
}
