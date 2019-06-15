using System;
using System.Threading;

namespace Thread_Join_1
{
    class Program
    {
        public static void ThreadFunc()
        {
            Console.WriteLine("ID for secondary Thread is: " + Thread.CurrentThread.ManagedThreadId);
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nSecondory thread is finish");

        }
        static void Main(string[] args)
        {
            var thread = new Thread(ThreadFunc);
            Console.WriteLine("ID for primary Thread is:" + Thread.CurrentThread.GetHashCode());
            Console.WriteLine("Start new Thread");
            thread.Start();
            Console.WriteLine(Thread.CurrentThread.GetHashCode());

            thread.Join();

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write("-");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPrimary thread is finish");
            Console.ReadKey();
        }
    }
}
