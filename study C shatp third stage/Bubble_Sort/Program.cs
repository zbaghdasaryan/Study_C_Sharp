using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{

    class Program
    {

        // Метод перестановки элементов

        static void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        // Метод реализует сортировку пузырьком 

        public static void BubbleSort(ref int[] items)
        {
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i - 1].CompareTo(items[i]) > 0)
                    {
                        Swap(items, i - 1, i);

                        swapped = true;
                    }
                }
            }

            while (swapped != false);
        }

        static void Main(string[] args)
        {


            int[] array = { 3, 7, 4, 4, 6, 5, 8 };

            Console.Write("Массив до сортировки: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.Write(" \nОтсортированный массив: ");

            BubbleSort(ref array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();
        }
    }
}
