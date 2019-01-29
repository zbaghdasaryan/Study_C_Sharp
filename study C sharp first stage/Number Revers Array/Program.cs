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

namespace Number_Revers_Array
{
    class Program
    {
        static void reversNumber(int number)
        {
            int[] arrayDigit = new int[number.ToString().Length];
            for (int i=0; i< number.ToString().Length; i++)
            {
                while (number > 0)
                {
                    arrayDigit[i] = number % 10;
                    number /= 10;
                    Console.Write(arrayDigit[i]+"0");
                }                                
            }                        
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            reversNumber(num);
            Console.ReadKey();
        }
    }
}
