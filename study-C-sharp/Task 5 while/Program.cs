/*
Խնդիր_5:
Հաշվել տրված բնական թվին չգերազանցող զույգ թվերի գումարը՝ առանց զույգությունը ստուգելու։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int K = 2;

            while (K<=num)
            {
                Console.Write(K + " + ");
                sum = sum + K;
                K += 2;
            }
            Console.CursorLeft = Console.CursorLeft - 2;

            Console.WriteLine("= " + sum);
            Console.ReadKey();
        }
    }
}
