/*
Խնդիր_4:
Ներածել n բնական թիվը։ 
Արտածել n–ի 1–ից մինչև 9 աստիճանների արժեքները։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            double num = Convert.ToDouble(Console.ReadLine());

            int n = 1;
            while (n<10)
            {
                Console.WriteLine(Math.Pow(num, n));
                n++;

            }
            Console.ReadKey();
        }
    }
}
