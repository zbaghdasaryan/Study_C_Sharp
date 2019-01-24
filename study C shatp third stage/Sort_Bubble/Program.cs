using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Bubble
{

    class Program
    {
        int[] a = new int[4];

        public void generateArray()
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1,10);
            }
        }
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
            sort.generateArray();
            sort.showArray();
            sort.bubbleSort();
            sort.showArray();
            Console.ReadKey();
        }
    }
}
