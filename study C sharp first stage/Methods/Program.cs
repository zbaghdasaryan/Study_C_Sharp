using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Calculator(double num1, double num2)
        {
            double sum = num1 + num2;
            Console.WriteLine("firstNumber + secondNumber = "+sum);
            double diff = num1 - num2;
            Console.WriteLine("firstNumber - secondNumber = "+diff);
            double mult = num1 * num2;
            Console.WriteLine("firstNumber * secondNumber = "+mult);
            if (num2 != 0)
            {
                double div = num1 / num2;
                Console.WriteLine("firstNumber / secondNumber = "+div);
            }
            else
            {
                Console.WriteLine("can't divide to 0, please choose another secondNumber");
            }
        }
        static void ArithmaticalGeometricalMeans (double num1, double num2)
        {
            double am = (num1 + num2) / 2;
            Console.WriteLine("arithmetic mean is equal " + am);
            double gm = Math.Sqrt(num2 * num2);
            Console.WriteLine("geometric mean is equal " + gm);
        }
        static double GreatestCommonDivisor(double num1, double num2)
        {
            double minnumber = Math.Min(num1, num2);

            for (double i = minnumber; i >= 2; i--)
            {
                if (num1 % i == 0 & num2 % i == 0)
                    return i;
            }
            return 1;
        }
        static void LeastCommonMultiple(double num1, double num2)
        {
            for (double i = 0; i < (num1 * num2 + 1); i++)
            {
                if (i % num2 == 0 && i % num1 == 0)
                {
                    double LCM = i;
                    if (i != 0)
                    {
                        Console.WriteLine("LCM = {0}", i);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
        static void IsItFactorial(ulong number)
        {
            ulong factorial = 1;
            ulong i = 1;
            while (factorial < number)
            {
                factorial = factorial * i;
                i = i + 1;
            }
            if (factorial == number)
            {
                Console.WriteLine("number {1} is factorial of {0}", i - 1, number);
            }
            else Console.WriteLine("there is no number wich factorial is "+number);
        }
        static void IsItFibonacci(ulong number)
        {
            ulong fibnum1 = 1;
            ulong fibnum2 = 1;
            ulong fibonacci = 1;
            
            while (fibonacci < number)
            {
                fibonacci = fibnum1 + fibonacci;
                fibnum1 = fibnum2;
                fibnum2 = fibonacci;
            }
            if (fibonacci == number)
            {
                Console.WriteLine("number {0} is a fibonacci number", number);
            }
            else Console.WriteLine("number {0} is not fibonacci number", number);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number ");
            ulong firstNumber = Convert.ToUInt64(Console.ReadLine());
            //Console.WriteLine("please enter the second number ");
            //double secondNumber = Convert.ToDouble(Console.ReadLine());
            IsItFibonacci(firstNumber);
            Console.ReadKey();
        }
    }
}
