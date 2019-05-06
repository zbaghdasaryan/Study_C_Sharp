using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    class Program
    {
        // Метод переставляе местами две ячейки массива

        

        // Метод быстрой сортировки

        static public void QuickSort(int[] items)
        {
            quicksort(items, 0, items.Length - 1);
        }

        static private void quicksort(int[] items, int left, int right)
        {
            Random _pivotRng = new Random();

            if (left < right)
            {
                // Генератор псевдослучайных чисел. Определение точки раздела массива.               
                int pivotIndex = _pivotRng.Next(left, right);

                int newPivot = partition(items, left, right, pivotIndex);
                quicksort(items, left, newPivot - 1);
                quicksort(items, newPivot + 1, right);
            }
        }

        static private int partition(int[] items, int left, int right, int pivotIndex)
        {
            int pivotValue = items[pivotIndex];

            Swap(items, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (items[i].CompareTo(pivotValue) < 0)
                {
                    Swap(items, i, storeIndex);
                    storeIndex += 1;
                }
            }

            // Перестановка значений местами.
            Swap(items, storeIndex, right);
            return storeIndex;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Алгоритм быстрой сортировки");

            int[] array = { 3, 7, 4, 4, 6, 5, 8, 12, 19, 2, 0 };

            QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
