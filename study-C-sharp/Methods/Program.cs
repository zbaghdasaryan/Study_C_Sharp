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
