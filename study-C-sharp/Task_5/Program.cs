using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int K = 2; K <= num ; K+=2)
            {
                Console.Write(K + " + ");
                sum = sum + K;
            }
            Console.CursorLeft = Console.CursorLeft - 2;
            
            Console.WriteLine("= " + sum);
            Console.ReadKey();
        }
    }
}
//int sum = (num/2)*((num/2) + 1);
//Console.WriteLine("sum="+sum);
//Console.ReadKey();

