/*
Խնդիր_35:
Տրված են X իրական և N բնական թվերը։ 
Գտնել 1 – X2/(2!) + X4/(4!) – … + (–1)N·X2·N/((2·N)!) արտահայտության արժեքը (N! = 1·2·…·N)։ 
Ստացված թիվը cos(X)-ի մոտավոր արժեքն է։
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
            double sum = 1;
            int factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial *= 2*i*(2*i-1);
                sum += 1.0 * Math.Pow(-1, i) * Math.Pow(x, 2*i) / factorial;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
