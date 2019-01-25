/*
Խնդիր_9:

Տրված է N բնական թիվը։ 
Հաշվել 1 + 1/2 + 1/3 + … + 1/N գումարը(այն իրական թիվ է)։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            int num = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            int n = 1;
            while (n<=num)
            {
                sum += 1.0 / n;
                n++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
