using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static int fibNumber(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
                return fibNumber(number - 1) + fibNumber(number - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("enter any number ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(fibNumber(num));
            Console.ReadKey();
        }
    }
}