/*
Խնդիր_22:
Հաշվել տրված թվի բոլոր բաժանարարների գումարը։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter any number ");
            long num = Convert.ToInt64(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("bajanararneri gumar@ = "+sum);
            Console.ReadKey();
        }
    }
}
