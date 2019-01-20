using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insetrtion_Sort
{
    class Program
    {

        static public void InsertionSort(int[] items)
        {
            int sortedRangeEndIndex = 1;

            while (sortedRangeEndIndex < items.Length)
            {
                if (items[sortedRangeEndIndex].CompareTo(items[sortedRangeEndIndex - 1]) < 0)
                {
                    int insertIndex = FindInsertionIndex(items, items[sortedRangeEndIndex]);
                    Insert(items, insertIndex, sortedRangeEndIndex);
                }

                sortedRangeEndIndex++;
            }
        }

        static private int FindInsertionIndex(int[] items, int valueToInsert)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].CompareTo(valueToInsert) > 0)
                {
                    return i;
                }
            }

            throw new InvalidOperationException("Индекс не найден");
        }

        static private void Insert(int[] itemArray, int indexInsertingAt, int indexInsertingFrom)
        {
            // itemArray =       0 1 2 4 5 6 3 7     
            // insertingAt =     3     
            // insertingFrom =   6     

            // Действия      
            //  1: Сохранить значение 4 в temp -> temp = 4     
            //  2: Записать 3 по индексу 3: 0 1 2 3 5 6 3 7 -> itemArray[3] = 3     
            //  3: Сдвинуть массив на одно значение в право, от индекса 4 до 6:     
            //     itemArray =       0 1 2 3 5 6 3 7
            //     itemArray =       0 1 2 3 5 6 6 7   temp = 4
            //     itemArray =       0 1 2 3 5 5 6 7   temp = 4

            //  4: Запись значения переменной temp по индексу 4.     
            //     0 1 2 3 4 5 6 7   temp = 4  

            // Шаг 1.     
            int temp = itemArray[indexInsertingAt];

            // Шаг 2.  
            itemArray[indexInsertingAt] = itemArray[indexInsertingFrom];

            // Шаг 3.     
            for (int current = indexInsertingFrom; current > indexInsertingAt; current--)
            {
                itemArray[current] = itemArray[current - 1];
            }

            // Шаг 4.     
            itemArray[indexInsertingAt + 1] = temp;
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 4, 6, 5, 8 };

            InsertionSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
