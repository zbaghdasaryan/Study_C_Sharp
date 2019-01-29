/*
Խնդիր_26:
Գտնել տրված բնական թվից մեծ և 2-ի աստիճան հանդիսացող ամենափոքր թիվը։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter any number ");
            long num = Convert.ToInt64(Console.ReadLine());

            int twodegree = 1;
            int n = 0;
            while (twodegree < num)
            {
                twodegree = twodegree * 2;
                n++;
            }
            Console.WriteLine($"2^{n}={twodegree} min number which is degree of two and more then {num}");

            Console.ReadKey();
        }

    }
}
