/*
Խնդիր_11:
Տրված է N բնական թիվը։ 
Հաշվել 1.1 · 1.2 · 1.3 · … արտադրյալը (արտադրիչների քանակը N է)։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double  member= 1.1;
            double sol = 1;
            int n = 1;
            while (n <= quantity)
            {
                sol *= member;
                member += 0.1;
                           
                n++;
            }

            Console.WriteLine(sol);
            Console.ReadKey();
        }
    }
}
