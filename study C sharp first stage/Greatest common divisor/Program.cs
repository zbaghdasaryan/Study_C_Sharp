using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_common_divisor
{
    class Program
    {
        static double GreatestCommonDivisor(double a, double b)                   
            {
                while (b != 0)
                    b = a % (a = b);
                return a;
            }        
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the second number ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(GreatestCommonDivisor(firstNumber, secondNumber));
            Console.ReadKey();
        }
    }
}
