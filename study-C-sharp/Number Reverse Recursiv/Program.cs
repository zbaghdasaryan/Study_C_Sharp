/*
Խնդիր_27:
Ներածել n բնական թիվը և տպել այդ թիվը՝ շրջելով և նրա ամեն մի թվանշանից հետո ավելացնելով 0 
(օրինակ՝ 125 - 502010):
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Revers_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            long n = long.Parse(t);

            Console.WriteLine(reverseNumber(n,0));
            Console.ReadKey();
        }     
        static long reverseNumber(long n, long i)
            {
                return (n == 0) ? i : reverseNumber(n / 10, 10*(i * 10 + n % 10));
            }
        }
}
