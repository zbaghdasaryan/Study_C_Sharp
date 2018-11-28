/*
 for Addition use "+" simbol";
 for Subtraction use "-" simbol;
 for Multiplication use * simbol;
 for Division use "/" simbol";
 for Degree use "^" simbol";
 for Remainder use "%" simbol";
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_Calculator
{
    class Program
    {
        public delegate double DelCalc(double x, double y);

        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            Console.Write("please enter the valu of x = ");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            //string matOperator = Console.ReadLine();
            Console.Write("please enter the valu of y = ");
            secondNumber = Convert.ToDouble(Console.ReadLine());


            double DoDivision(double x, double y)
            {
                if (y == 0)
                {
                    Console.WriteLine("you cant divide by 0");
                    return double.NaN;
                }
                else
                    return x / y;
            }

            double DoMultiplication(double x, double y)
            {
                return x * y;
            }

            double DoSubtraction(double x, double y)
            {
                return x - y;
            }

            double DoAddition(double x, double y)
            {
                return x + y;
            }

            double DoRemainder(double x, double y)
            {
                return x % y;
            }

            double DoDegree(double x, double y)
            {
                return Math.Pow(x, y);
            }

            DelCalc delCalc1 = new DelCalc(DoAddition);
            DelCalc delCalc2 = new DelCalc(DoSubtraction);
            DelCalc delCalc3 = new DelCalc(DoMultiplication);
            DelCalc delCalc4 = new DelCalc(DoDivision);
            DelCalc delCalc5 = new DelCalc(DoRemainder);
            DelCalc delCalc6 = new DelCalc(DoDegree);

            Console.WriteLine();
            Console.Write("x + y = ");
            Console.WriteLine(delCalc1(firstNumber, secondNumber));
            Console.Write("x - y = ");
            Console.WriteLine(delCalc2(firstNumber, secondNumber));
            Console.Write("x * y = ");
            Console.WriteLine(delCalc3(firstNumber, secondNumber));
            Console.Write("x / y = ");
            Console.WriteLine(delCalc4(firstNumber, secondNumber));
            Console.Write("x % y = ");
            Console.WriteLine(delCalc5(firstNumber, secondNumber));
            Console.Write("x ^ y = ");
            Console.WriteLine(delCalc6(firstNumber, secondNumber));

            Console.ReadKey();
        }
    }
}

