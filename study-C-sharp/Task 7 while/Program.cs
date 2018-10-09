/*
Խնդիր_7:
Տրված են A և B (A<B) ամբողջ թվերը։ 
Գտնել [A,B] հատվածին պատկանող բոլոր ամբողջ թվերի գումարը։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter second number ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int n = firstNum;

            while (n <= secondNum)
            {
                sum = sum + n;
                n++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
