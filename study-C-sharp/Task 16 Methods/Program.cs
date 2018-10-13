/*
Խնդիր_16:
Հաշվել տրված բնական թվի թվանշանների գումարը, քանակը, արտադրյալը։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16_Methods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
                Console.Write("enter any number ");
                int n = Convert.ToInt32(Console.ReadLine());
                 

            int sum = GetDigitSum(n);
            Console.WriteLine($"The Sum of digits in {n} is: {sum}");

            int qount = GetDigitQuont(n);
            Console.WriteLine($"The number of digits in {n} is: {qount}");

            int mult = GetDigitMult(n);
            Console.WriteLine($"The multiplication of digits in {n} is: {mult}");
            
            Console.ReadKey();
        }
        /// <summary>
        /// Returns the sum of digits
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int GetDigitSum(int num)
        {
            int sum = 0;

            for (; num > 0;)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        /// <summary>
        /// Returns the qountity of digits
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int GetDigitQuont(int num)
        {
            int qount = 0;

            for (; num > 0;)
            {
                qount ++;
                num /= 10;
            }
            return qount;
        }
        /// <summary>
        /// Returns the multiplication of digits
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int GetDigitMult(int num)
        {
            int mult = 1;

            for (; num > 0;)
            {
                mult*=num%10;
                num /= 10;
            }
            return mult;
        }
    }
}
