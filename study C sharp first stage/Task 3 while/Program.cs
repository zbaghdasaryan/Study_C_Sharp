/*
Խնդիր_3:
Ներածել n միանիշ թիվը։ Արտածել n-ին չգերազանցող թվանշանները։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            int K = 0;

            while (K < firstNum+1)
            {
                Console.WriteLine(K);
                K++;

            }
            Console.ReadKey();
        }
    }
}

