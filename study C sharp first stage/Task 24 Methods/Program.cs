/*
Խնդիր_24:
Պարզել, հանդիսանում է, արդյոք, տրված թիվը 3-ի աստիճան։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter any number ");
            long num = Convert.ToInt64(Console.ReadLine());

            int n = 0;
            for (; num > 0 && num % 3 == 0; num /= 3)
            {
                n++;
            } 
            if (num == 1)
                Console.WriteLine($"num = 3^{n}");
            else
                Console.WriteLine($"number is not degree of 3");
            Console.ReadKey();

        }
    }
}
