/*
Խնդիր_18:
Հաշվել տրված թվի 4-ից մեծ կենտ թվանշանների գումարը։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18
{
    class Program
    {
        /// <summary>
        /// Returns the sum of more then 4 odd digits
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int SumMore4OddDigit(int num)
        {
            int sum = 0;
            for (; num > 0; num /= 10)
            {

                int digit = (ushort)(num % 10);

                if (digit > 4 && digit % 2 != 0)

                    sum = sum + digit;
            }
            return sum;
        }
        static void Main(string[] args)
        {
                Console.Write("enter any number ");
                int n = Convert.ToInt32(Console.ReadLine());

                int sum = SumMore4OddDigit(n);
                Console.WriteLine($"The Sum of more then 4 odd digits in {n} is: {sum}");
                Console.ReadKey();
            }
        }
    }

