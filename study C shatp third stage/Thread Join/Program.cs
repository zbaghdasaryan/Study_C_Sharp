using System;
using System.Threading;

namespace ThreadSample
{
    class Program
    {
        // Метод выполяняющийся во Вторичном потоке.
        private static void ThreadFunc()
        {
            Console.WriteLine("ID Вторичного потока: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Вторичный поток завершился.");
        }

        static void Main()
        {
            // Создание нового потока.
            var thread = new Thread(new ThreadStart(ThreadFunc));

            Console.WriteLine("ID Первичного потока: {0} \n", Thread.CurrentThread.GetHashCode());
            Console.WriteLine("Запуск нового потока...");

            thread.Start();
            Console.WriteLine(Thread.CurrentThread.GetHashCode());
            // Ожидание первичным потоком, завершения работы вторичного потока.
            thread.Join(); //TODO Снять комментарий.

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write("-");
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nПервичный поток завершился.");

            // Задержка.
            Console.ReadKey();
        }
    }
}
