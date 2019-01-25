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

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber, result;

            firstNumber = Convert.ToDouble(Console.ReadLine());

            string matOperator = Console.ReadLine();

            secondNumber = Convert.ToDouble(Console.ReadLine());

            if (matOperator == "+")
            {

                result = firstNumber + secondNumber;
                Console.WriteLine("=" + result);
            }


            else if (matOperator == "-")
            {

                result = firstNumber - secondNumber;
                if (firstNumber < secondNumber)
                {
                    Console.WriteLine("result is <0");

                }
                else
                {
                    Console.WriteLine("=" + result);
                }

            }

            else if (matOperator == "*")

            {

                result = firstNumber * secondNumber;
                Console.WriteLine("=" + result);
            }

            else if (matOperator == "/")

            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("you can not devide to 0");

                }
                else
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine("=" + result);
                }


            }


            else if (matOperator == "%")

            {

                result = firstNumber % secondNumber;
                Console.WriteLine("=" + result);
            }

            else if (matOperator == "^")

            {

                result = Math.Pow(firstNumber, secondNumber);
                Console.WriteLine("=" + result);
            }

            else

            {
                Console.WriteLine("Please enter a valid matematical operation");
            }


            Console.ReadKey();

        }
    }
}
