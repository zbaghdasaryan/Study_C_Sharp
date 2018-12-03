using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_try_catch
{
    class Calculator
    {
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public double Sub(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public double Mult(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public double? Div(double firstNumber, double secondNumber)
        {

            try
            {
                return firstNumber / secondNumber;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
