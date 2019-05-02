using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{

    class Program
    {
        static Random rand = new Random();

        public static int[] GetRandomArray(int length, int MinValue, int MaxValue)
        {
            int[] ret = new int[length];
            for (int i = 0; i < length; i++)
                ret[i] = rand.Next(MinValue, MaxValue);
            return ret;
        }

        public static void swap(ref int a, ref int b)
        {
            if (a == b) return;
            a = a + b;
            b = a - b; // a + b - b = a   
            a = a - b; // a + b - a = b    
        }

        public static void swap1(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }



        static void Main(string[] args)
        {

            int[] a = GetRandomArray(20, -100, 100);
            //BubbleSort(a);
            //SelectionSort(a);
            //InsertionSort(a);
            IntArrayQuickSort(a);


            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        public static void BubbleSort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j + 1] < array[j])
                        swap(ref array[j + 1], ref array[j]);
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            int N = array.Length;

            for (int i = 0; i < N - 1; i++)
            {
                int min = array[i];
                int minind = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        minind = j;
                    }
                }
                //if(i != minind)
                swap1(ref array[i], ref array[minind]);
            }
        }

        public static void InsertionSort(int[] array)
        {
            int N = array.Length;

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (array[j] > array[j + 1])
                        swap(ref array[j], ref array[j + 1]);
                    else
                        break;
                }
            }

        }

        public static void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    swap(ref data[i], ref data[j]);
                    i++; j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }

        public static void IntArrayQuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }

        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}