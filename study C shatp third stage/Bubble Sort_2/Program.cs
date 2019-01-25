using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_2
{
    class Program
    {
        int[] array = { 2, 5, 12, 1, 4, 32, 8, 9, 4 };

        //public void swap(int a, int b)
        //{
        //    int temp = b;
        //    b = a;
        //    a = temp;
        //}

        public void printArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                
            }
            Console.WriteLine();
        }

        public void bubbleSort()
        {
            for (int i = array.Length; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        //swap(array[j+1], array[j]);
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }            
        }
        static void Main(string[] args)
        {
            Program inst = new Program();
            inst.printArray();
            inst.bubbleSort();
            inst.printArray();
            
            Console.ReadKey();
        }
    }
}
