using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter second number ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            
            for (int n = firstNum; n <= secondNum; n++)
            {
                
                if (n % 3 == 0)
                {
                    Console.WriteLine(n);
                    break;
                }
            }
            
            Console.ReadKey();
        }
    }
}

