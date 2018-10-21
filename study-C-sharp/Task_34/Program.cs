/*
Խնդիր_34:
Տրված են X իրական և N բնական թվերը։ 
Գտնել X – X3/(3!) + X5/(5!) – … + (–1)N·X2·N+1/((2·N+1)!) արտահայտության արժեքը (N! = 1·2·…·N)։ 
Ստացված թիվը sin(X)-ի մոտավոր արժեքն է։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any natural number");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter any real number");
            double x = Convert.ToDouble(Console.ReadLine());
            double sum = x;      
            for (int i = 1; i <= N; i++)
            {
                sum += 1.0 * Math.Pow(-1, i)*Math.Pow(x,2*i+1) / (2*i*(2*i+1));               
            }
            Console.WriteLine(sum); 
            Console.ReadKey();
        }
    }
}
