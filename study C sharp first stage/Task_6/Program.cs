using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
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
            for (int n = firstNum; n <= secondNum; n++)
            {
                Console.WriteLine(n);
                quantity++;
            }
            Console.WriteLine("quantity = " + quantity);
            Console.ReadKey();
        }
    }
}

