using System;
using System.Threading;

namespace Thread_Join_2
{
    class Program
    {
        public static void WriteChar(char chr, int count, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(20);
                Console.Write(chr);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void Method3()
        {
            Console.WriteLine($"\nThe third Thread ID is: "+Thread.CurrentThread.GetHashCode());
            WriteChar('3', 160, ConsoleColor.Yellow);
            Console.WriteLine("\nThe third Thread ended");
        }

        public static void Method2()
        {
            Console.WriteLine($"\nThe second Thread ID is: " + Thread.CurrentThread.GetHashCode());
            WriteChar('2', 80, ConsoleColor.Red);
            var thread = new Thread(Method3);
            thread.Start();
            thread.Join();
            WriteChar('2', 80, ConsoleColor.Red);
            Console.WriteLine("\nThe second Thread ended");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"\nThe primary Thread ID is: " + Thread.CurrentThread.GetHashCode());
            WriteChar('1', 80, ConsoleColor.Green);

            var thread = new Thread(Method2);
            thread.Start();
            thread.Join();
            WriteChar('1', 80, ConsoleColor.Green);
            Console.WriteLine("\nThe primary Thread ended");
            Console.ReadKey();
        }
    }
}
