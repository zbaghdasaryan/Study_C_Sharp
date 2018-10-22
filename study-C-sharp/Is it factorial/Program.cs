using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_it_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number ");
            double number = Convert.ToDouble(Console.ReadLine());
            int factorial = 1;
            int i = 1;
            while (factorial <= number)
            {
                factorial = factorial * i;
                i = i + 1;
            }
            if (factorial == number)
            {
                Console.WriteLine(i-1); 
            }
            else Console.WriteLine(0);

            Console.ReadKey();
        }

/*
        static bool IsFactorial(ulong n)
        {
            ulong k = 1;
            for (ulong i = 0; k <= n; i++)
                if ((k = Factorial(i)) == n) return true;
            return false;
        }
        static ulong Factorial(ulong n)
        {
            ulong ret = 1;
            for (ulong i = 1; i <= n; i++)
                ret *= i;
            return ret;
        }
*/
    }
}
