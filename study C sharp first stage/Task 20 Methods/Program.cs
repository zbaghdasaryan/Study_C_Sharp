/*
Խնդիր_20:
Գտնել տրված թվի ամենամեծ և ամենափոքր թվանշանների տարբերության քառակուսին։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_Methods
{
    class Program
    {
        /// <summary>
        /// Returns the difference and squared of difference between the largest and smallest digits.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int DiffLargeAndSmallDigits(int num)
        {
            int max = 0;
            int min = 9;

            for (; num > 0; num /= 10)
            {

                int digit = (ushort)(num % 10);
                if (digit < min)

                    min = digit;

                if (digit > max)
                    max = digit;
             }
            int diff = max - min;

            return diff;
        }
        static void Main(string[] args)
        {
            Console.Write("enter any number ");
            int n = Convert.ToInt32(Console.ReadLine());

            int diff = DiffLargeAndSmallDigits(n);
            int squDiff = DiffLargeAndSmallDigits(n) * DiffLargeAndSmallDigits(n);
            Console.WriteLine($"The difference between the largest and smallest digits in {n} is: {diff}");
            Console.WriteLine($"The square of difference between the largest and smallest digits in {n} is: {squDiff}");
            Console.ReadKey();
        }
    }
}