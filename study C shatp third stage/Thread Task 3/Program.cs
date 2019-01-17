using System;
using System.Threading;

// Потоки.

namespace Threads
{
    class Program
    {
        static void WriteSecond()
        {
            // Thread.CurrentThread - возвращает ссылку на экземпляр текущего потока.
            Thread thread = Thread.CurrentThread;

            // Присваиваем потоку имя.
            thread.Name = "Secondary";

            // Выводим на экран информацию о текущем потоке.
            Console.WriteLine("ID потока {0}: {1}", thread.Name, thread.GetHashCode());

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(new string(' ', 15) + thread.Name + " " + counter);
                // Приостанавливаем выполнение текущего потока.
                Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            // Получаем ссылку на экземпляр текущего потока.
            Thread primaryThread = Thread.CurrentThread;

            // Присваиваем потоку имя.
            primaryThread.Name = "Primary";

            // Выводим на экран информацию о текущем потоке.
            Console.WriteLine("ID потока {0}: {1}", primaryThread.Name, primaryThread.GetHashCode());


            // Работа вторичного потока.
            Thread secondaryThread = new Thread(WriteSecond);
            secondaryThread.Start();

            // Работа первичного потока.
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(primaryThread.Name + " " + counter);
                // Приостанавливаем выполнение текущего потока.
                Thread.Sleep(1500);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
