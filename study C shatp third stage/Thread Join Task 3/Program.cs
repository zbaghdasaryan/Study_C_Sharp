using System;
using System.Threading;

namespace ThreadSampleMul
{
    class Program
    {
        // Общая переменная счетчик.
           [ThreadStatic] //TODO Снять комментарий
        public static int counter;

        // Рекурсивный запуск потоков.
        public static void Method()
        {
            if (counter < 100)
            {
                counter++; // Увеличение счетчика вызваных методов.
                Console.WriteLine(counter + " - СТАРТ --- " + Thread.CurrentThread.GetHashCode());
                var thread = new Thread(Method);
                thread.Start();
                thread.Join(); // Закомментировать.               
            }

            Console.WriteLine("Поток {0} завершился.", Thread.CurrentThread.GetHashCode());
        }

        static void Main()
        {
            // Запуск вторичного потока.
            var thread = new Thread(Method);
            thread.Start();
            thread.Join();

            Console.WriteLine("Основной поток завершил работу...");

            // Задержка.
            Console.ReadKey();
        }
    }
}
