using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekdays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter numbers from 1 to 7");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Monday");
            }
            else if (num == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("Tuesday");
            }
            else if (num == 3)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("Wednsday");
            }
            else if (num == 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("Thursday");
            }
            else if (num == 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("Frisday");
            }
            else if (num == 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("Saturday");
            }
            else if (num == 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("Sunday");
            }
            Console.ReadKey();

        }
    }
}
