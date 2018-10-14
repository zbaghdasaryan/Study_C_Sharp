/*
Խնդիր_21:
Արտածել տրված թվի բոլոր բաժանարարները։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter any number ");
            long num = Convert.ToInt64(Console.ReadLine());
            
            
            for (int i = 1; i < num; i++)
            {
                if (num%i==0)
                    Console.WriteLine(i); 
                
            }
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}