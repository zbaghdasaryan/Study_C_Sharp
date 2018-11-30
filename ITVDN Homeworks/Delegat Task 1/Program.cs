using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_Task_1
{
    class Program
    {
        public delegate double DelegatArithmeticMean(double a, double b, double c);

        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the second number");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the third number");
            double z = Convert.ToDouble(Console.ReadLine());

            DelegatArithmeticMean del = (a, b, c) => (double)(a + b + c) / 3;

            Console.WriteLine("Arithmetic mean = "+ del(x,y,z));

            Console.ReadKey();
        }
    }
}
