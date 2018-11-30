using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_Task_2
{
    class Program
    {
        delegate double MyDelegat(double a, double b);

        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the second number");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the operator (+,-,*,/)");
            string c = Console.ReadLine();

            MyDelegat op = null;

            switch (c)
            {
                case "+":
                    op = (x, y) => { return x + y; };
                    break;
                case "-":
                    op = (x, y) => { return x - y; };
                    break;
                case "*":
                    op = (x, y) => { return x * y; };
                    break;
                case "/":
                    op = (x, y) =>
                    {
                        if (y != 0)
                        {
                            return x / y;
                        }

                        else
                        {
                            Console.WriteLine("cante dividet by 0");
                            return 0;
                        }
                    };
                    break;
                default:
                    Console.WriteLine("wrong operator");
                    break;
            }
            Console.WriteLine(new string('-', 30));
            if (op != null)
                Console.WriteLine(op(a, b));
            Console.ReadKey();
        }
    }
}