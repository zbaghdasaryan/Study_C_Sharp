using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
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
            for (int n = firstNum; n <= secondNum; n++)
            {
                sum = sum + n;               
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

