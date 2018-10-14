/*
Խնդիր_23:
Հաշվել տրված թվի բոլոր բաժանարարների գումարի և դրանց քանակի քանորդը։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter any number ");
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();
            double divide = allDivisorsSumDividedByCount(n);
            Console.WriteLine("all divisors sum divided by count = " + divide);
            Console.ReadKey();
        }
        /// <summary>
        /// Returns all divisors sum divided by count
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static double allDivisorsSumDividedByCount(long num)
        {
            double sum = num;
            double count = 1.0;
            double div;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("the number divisors are " + i);
                    sum += i;
                    count++;
                }      
            }
            Console.WriteLine("the number divisors are " + num);
            Console.WriteLine();
            Console.WriteLine("the sum of number divisors are " + sum);
            Console.WriteLine();
            Console.WriteLine("the count of number divisos is " + count);
            Console.WriteLine();
            div = sum / count;
            return div;
        }   
    }
}
