using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Dynamic
{
    class Calculator
    {
        public dynamic Add(dynamic firstNumber, dynamic secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public dynamic Sub(dynamic firstNumber, dynamic secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public dynamic Mult(dynamic firstNumber, dynamic secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public dynamic Div(dynamic firstNumber, dynamic secondNumber)
        {
            if (secondNumber != 0)
            {
                return firstNumber / secondNumber;
            }
            else
                return "cand divide by 0";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int firstNumber = 20, secondNumber = 30;

            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, calculator.Add(firstNumber, secondNumber));
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, calculator.Sub(firstNumber, secondNumber));
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, calculator.Mult(firstNumber, secondNumber));
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, calculator.Div(firstNumber, secondNumber));
           
            Console.ReadKey();
        }
    }
}
