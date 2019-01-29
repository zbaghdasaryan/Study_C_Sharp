/*
Խնդիր_25:
Տրված n>0 ամբողջ թվի համար հաշվել 2-ի ամենամեծ աստիճանը, որը չի գերազանցում n-ը։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter any number ");
            long num = Convert.ToInt64(Console.ReadLine());

            int twodegree = 1;
            int n = 0;
            while (twodegree < num/2)
            {
                twodegree = twodegree*2;
                n++;
            }
            
            Console.WriteLine($"2^{n}={twodegree} and less then {num}");
            

            Console.ReadKey();
        }
                           
    }
}
