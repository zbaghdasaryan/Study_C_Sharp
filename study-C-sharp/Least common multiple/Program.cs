using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Least_common_multiple
{
    class Program
    {
        static void LeastCommonMultiple(double num1, double num2)
            {
            for (double i = 0; i<(num1* num2 + 1); i++)
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
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the second number ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            LeastCommonMultiple(firstNumber, secondNumber);
            Console.ReadKey();
        }
    }
}
