/*
Տրված են X իրական (|X|<1) և N բնական թվերը։ 
Գտնել X–X2/2 + X3/3 –…+ (–1)N–1·XN/N արտահայտության արժեքը։ 
Ստացված թիվը ln(1+X)-ի մոտավոր արժեքն է։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any natural number (1,2,3,...) ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter any real number (-1<x<1) ");
            double x = Convert.ToDouble(Console.ReadLine());
            double sum = x;
            if (x > -1 && x < 1)
            {
                for (int i = 2; i <= N; i++)
                {
                    sum += 1.0 * Math.Pow(-1, i - 1) * Math.Pow(x, i) / i;
                }
                Console.WriteLine(sum);
            }
            else Console.WriteLine("enter x from -1 to 1"); ;

            Console.ReadKey();
        }
    }
}
