using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_swich
{
    class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result;


        Console.Write("enter first number num1 = ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter second number num2 = ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("enter mat operation (+, -, *, /, ) ");
        string operation = Console.ReadLine();

        result = 0;

        bool flag = true;
        switch (operation)

        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
            default:
                flag = false;
                Console.WriteLine("error");
                break;

                Console.WriteLine(flag ? $"{num1} {operation} {num2} = {result}" : "wrong operation");

        }

        Console.ReadKey();
    }
}
}
