using System;
using System.Threading;

namespace Thread_Abort
{
    class Program
    {
        // Метод выполняющийся в отдельном потоке.
        private static void Function()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                try
                {
                    Thread.Sleep(10);
                    Console.Write(".");
                }
                catch (ThreadAbortException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    // Попытка 'проглотить' исключение и продолжиться выполняться в данном цикле.
                    // То есть вернуться в цикл и продолжить выводить counter.
                    Console.WriteLine("\nThreadAbortException");

                    for (int i = 0; i < 160; i++)
                    {
                        Thread.Sleep(20);
                        Console.Write(".");
                    }

                    Console.ForegroundColor = ConsoleColor.Green;

                    // Если не вызывать Thread.ResetAbort() - исключение повторно сгенерируется после выхода из catch{}
                    // Предотвращение повторной генерации ThreadAbortException!
                    Thread.ResetAbort();
                }

            }
        }

        static void Main()
        {
            Thread thread = new Thread(new ThreadStart(Function));
            thread.Start();

            // Даем время запуститься вторичному потоку и поработать.
            Thread.Sleep(2000);

            // Прервать поток. Генерируется исключение ThreadAbortException.

            thread.Abort(); // Закоментировать!

            // Ждать завершения потока.
            thread.Join();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n" + new string('_', 80));

            // Задержка.
            //Console.ReadKey();
        }
    }
}
