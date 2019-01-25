using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number from 1-7");
            int num = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            switch (num)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(flag ? "Monday" : "Wrong operation");
                        break;
                    }

                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(flag ? "Tuesday" : "Wrong operation");
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(flag ? "Wednesday" : "Wrong operation");
                        break;
                    }
                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(flag ? "Thursday" : "Wrong operation");
                        break;
                    }
                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(flag ? "Friday" : "Wrong operation");
                        break;
                    }
                case 6:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(flag ? "Saturday" : "Wrong operation");
                        break;
                    }
                case 7:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(flag ? "Sunday" : "Wrong operation");
                        break;
                    }
                default: flag = false; break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flag ? "" : "Wrong operation");
            Console.ReadKey();


        }
    }
}
