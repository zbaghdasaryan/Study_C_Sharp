/*
Խնդիր_6:
Տրված են A և B (A<B) ամբողջ թվերը։ 
Արտածել աճման կարգով [A,B] հատվածին պատկանող ամբողջ թվերը, ապա նաև նրանց քանակը։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter second number ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int quantity = 0;
            int n = firstNum;
            while (n<=secondNum)
            {
                Console.WriteLine(n);
                quantity++;
                n++;
            }
            Console.WriteLine("quantity = " + quantity);
            Console.ReadKey();
        }
    }
}
