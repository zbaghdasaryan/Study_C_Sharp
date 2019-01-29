// This program calculates the arithmetic and geometric means of two numbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_and_geometrical_means
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("enter value of x = ");
            string t = Console.ReadLine();
            double x = Convert.ToDouble(t);
            Console.Write("enter value of y = ");
            t = Console.ReadLine();
            double y = Convert.ToDouble(t);
            double am = (x + y) / 2;
            Console.WriteLine("arithmetic mean is equal " + am);
            double gm = Math.Sqrt(x * y);
            Console.WriteLine("geometric mean is equal " + gm);
            Console.ReadKey();

        }
    }
}