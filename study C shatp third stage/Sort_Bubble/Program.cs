using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Bubble
{

    class Program
    {
        int[] a = new int[6] { 1, 4, 10, 6, 5, 3 };

        
        public void showArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public void bubbleSort()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Program sort = new Program();
           // sort.generateArray();
            sort.showArray();
            sort.bubbleSort();
            sort.showArray();
            Console.ReadKey();
        }
    }
}
