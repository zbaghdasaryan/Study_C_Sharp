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

namespace Number_Reverse
{
    class Program
    {
        static void reversNumber(int num)
        {
            while (num > 0)
            {
                int digit = num % 10;
                num /= 10;
                Console.Write(digit+"0");
            }
            
        }
        static void Main(string[] args)
        {
            reversNumber(125);
            Console.ReadKey();
        }
    }
}
