using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the first number ");
            double firstNumber = 0;
            try
            {
                firstNumber = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }

            Console.WriteLine("enter the second number ");
            double secondNumber = 0;
            try

            {
                secondNumber = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                
            }

            Console.WriteLine("enter mat operator ");
            char op = '0';
            try
            {
                op = char.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Calculator calculator = new Calculator();
                double? result = 0;
                bool calculation = true;

                switch (op)
                {
                    case '+':
                        result = calculator.Add(firstNumber, secondNumber);
                        break;
                    case '-':
                        result = calculator.Sub(firstNumber, secondNumber);
                        break;
                    case '*':
                        result = calculator.Mult(firstNumber, secondNumber);
                        break;
                    case '/':
                        result = calculator.Div(firstNumber, secondNumber);
                        break;
                    default:
                        {
                            Console.WriteLine("wrong operator");
                            calculation = false;
                            break;
                        }

                }
                if (calculation && result != null)
                {
                    Console.WriteLine("{0} {1} {2} = {3}", firstNumber, op, secondNumber, result);
                }
                Console.ReadKey();
            }
        }
    }
