/*
Խնդիր_19:
Հաշվել տրված թվի 7-ից փոքր զույգ թվանշանների արտադրյալը։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19_Methods
{
    class Program
    {
        /// <summary>
        /// Returns the multiplication of less then 7 even digits
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int Multless7EvenDigit(int num)
        {
            int mult = 1;
            for (; num > 0; num /= 10)
            {

                int digit = (ushort)(num % 10);

                if (digit < 7 && digit % 2 == 0)

                    mult*= digit;
            }
            return mult;
        }
        static void Main(string[] args)
        {
            Console.Write("enter any number ");
            int n = Convert.ToInt32(Console.ReadLine());

            int mult = Multless7EvenDigit(n);
            Console.WriteLine($"The multiplication of less then 7 even digits in {n} is: {mult}");
            Console.ReadKey();
        }
    }
}