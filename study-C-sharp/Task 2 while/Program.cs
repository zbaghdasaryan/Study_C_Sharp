/*
Խնդիր_2:
Տրված են K և N(N > 0) ամբողջ թվերը։ 
N անգամ արտածել K թիվը։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how many time you wont to show N ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            int K = 0;

            while (K < firstNum)
            {
                Console.WriteLine("N");
                K = K + 1;
                Console.ReadKey();

            }
        }
    }
}
