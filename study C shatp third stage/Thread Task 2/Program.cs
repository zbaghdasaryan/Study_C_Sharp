using System;
using System.Threading;

// Потоки.

namespace Threads
{
    class Program
    {
        // Статический метод, который планируется выполнять одновременно в главном (первичном) и во вторичном потоках.
        static void WriteSecond()
        {
            // CLR назначает каждому потоку свой стек и методы имеют свои собственные локальные переменные.
            // Отдельный экземпляр переменной counter создается в стеке каждого потока, 
            // поэтому для каждого потока выводятся, свои значения counter - 0,1,2.
            int counter = 0;

            while (counter < 10)
            {
                Thread.Sleep(500);
                Console.WriteLine("Thread Id {0}, counter = {1}", Thread.CurrentThread.GetHashCode(), counter);
                counter++;
            }
        }

        static void Main()
        {
            // Работа вторичного потока.
            Thread thread = new Thread(WriteSecond);
            thread.Start();

            // Работа первичного потока.
            WriteSecond();


            // Delay.
            Console.ReadKey();
        }
    }
}
