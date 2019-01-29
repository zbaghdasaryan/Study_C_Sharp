/*
Խնդիր_33:
Տրված են X իրական և N բնական թվերը։ 
Գտնել 1 + X + X2/(2!) + … + XN/(N!) արտահայտության արժեքը (N! = 1·2·…·N)։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any natural number");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter any real number");
            double x = Convert.ToDouble(Console.ReadLine());
            double sum = 1, factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
                sum += 1.0*Math.Pow(x,i) / factorial;               
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
