using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            double num = Convert.ToDouble(Console.ReadLine());

            for (int n = 1; n < 9; n++)
            {
                Console.WriteLine(Math.Pow(num, n));

            }
            Console.ReadKey();
        }
    }
}
