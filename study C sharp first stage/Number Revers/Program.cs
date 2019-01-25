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

namespace Number_Revers
{
    class Program
    {
        static void reversNumber(int num)
        {
            int digit = num % 10;
            num /= 10;
            Console.WriteLine(digit);
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            reversNumber(num);
        }
    }
}
