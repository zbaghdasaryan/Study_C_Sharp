using System;
using System.Threading;

namespace ThreadSampleJoin
{
    class Program
    {
        private static void WriteChar(char chr, int count, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(20);
                Console.Write(chr);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Метод выполняющийся в третичном потоке.(Запуск из вторичного потока.)
        public static void Method3()
        {
            Console.WriteLine("Третичный поток # {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('3', 160, ConsoleColor.Yellow);
            Console.WriteLine("Третичный поток завершился.");
        }

        // Метод выполняющийся во вторичном потоке.(Запуск из первичного потока.)
        public static void Method2()
        {
            Console.WriteLine("Вторичный поток # {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('2', 80, ConsoleColor.Blue);

            // Создание третичного потока.
            var thread = new Thread(Method3);
            thread.Start();
            //   thread.Join();

            WriteChar('2', 80, ConsoleColor.Blue);
            Console.WriteLine("Вторичный поток завершился.");
        }


        // Метод выполняющийся в первичном потоке.
        static void Main()
        {
            Console.WriteLine("Первичный поток # {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('1', 80, ConsoleColor.Green);

            // Создание вторичного потока.
            var thread = new Thread(Method2);
            thread.Start();
            //   thread.Join();

            WriteChar('1', 80, ConsoleColor.Green);

            Console.WriteLine("Первичный поток завершился.");

            // Задержка.
            Console.ReadKey();
        }
    }
}
