using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_recursion
{
    class Program
    {
        static int factNumber(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
                return number * factNumber(number - 1);
        }


        static void Main(string[] args)
        {
            Console.Write("enter any number ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(factNumber(num));
            Console.ReadKey();
        }
    }
}