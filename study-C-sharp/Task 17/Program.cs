/*
Խնդիր_17:
Գտնել տրված թվի կենտ թվանշաններից ամենափոքրը։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter any number ");
            long num = Convert.ToInt64(Console.ReadLine());
            int ham = 9;
            for (; num > 0; num /= 10)
            {

                int digit = (ushort)(num % 10);

                if (digit < ham && digit % 2 != 0)
                    ham = digit;
            }
            Console.WriteLine(ham);
            Console.ReadKey();
        }
    }
}
