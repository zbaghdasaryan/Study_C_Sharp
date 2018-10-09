/*
Խնդիր_12:
Տրված է N բնական թիվը։ 
Հաշվել 1.1 – 1.2 + 1.3 – … արտահայտության արժեքը։ 
Նշանափոխ գումարելիների քանակը N է։ 
Պայմանական (if) օպերատոր չօգտագործել։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            double first = 1.1;
            int i = 0;
            while (i < quantity)
            {
                sum += Math.Pow(-1, i) * (first += 0.1);
                i++;
            }
            


            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
