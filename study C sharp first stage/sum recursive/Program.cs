using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_recursive
{
    class Program
    {
        static int sumNumbers(int n)
        {
            if (n == 0)
                return 1;
            else return sumNumbers(n)+sumNumbers(n-1);

        }
            

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(sumNumbers(num));

        }
    }
}
