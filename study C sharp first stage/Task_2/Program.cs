using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how many time you wont to show N ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            for (int K = 0; K < firstNum; K++)
            {
                Console.WriteLine("N");

                Console.ReadKey();

            }
        }
    }
}
