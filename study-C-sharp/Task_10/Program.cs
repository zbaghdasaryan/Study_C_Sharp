using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int n = 0; n <= num; n++)
            {
                sum += (num + n) * (num + n);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
