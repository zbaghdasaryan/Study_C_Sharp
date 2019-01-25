using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; true;)
            {
                Console.Write("enter any number ");
                ulong num = Convert.ToUInt64(Console.ReadLine());
                ushort sum = 0;

                for (; num > 0;)
                {
                    sum += (ushort)(num % 10);
                    Console.Write(num % 10 + " + ");
                    num /= 10;

                }
                Console.CursorLeft = Console.CursorLeft - 2;
                Console.WriteLine("= " + sum);
                Console.ReadKey();
            }
        }
    }
}

