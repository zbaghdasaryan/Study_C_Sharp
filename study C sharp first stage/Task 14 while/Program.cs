using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task_14_while
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
                ulong temp = num;
                while (temp > 0)

                {
                    sum += (ushort)(temp % 10);
                    Console.Write(temp % 10 + " + ");
                    temp /= 10;

                }
                Console.CursorLeft = Console.CursorLeft - 2;
                Console.WriteLine("= " + sum);
                
                if (num==(ulong)2*sum)
                {
                    Console.WriteLine("yes");
                }
                else
                    Console.WriteLine("no");
            }
        }
    }
}
