using System;
using System.Threading;

namespace Thread_ForeGround
{
    class Program
    {
        private static void Function()
        {
            for (int i = 0; i < 500; i++)
            {
                Thread.Sleep(20);
                Console.Write('.');
            }
            Console.WriteLine("\nThe secondary Thread ended");
        }

        static void Main(string[] args)
        {
            var thread = new Thread(Function);
           // thread.IsBackground = false;
            thread.Start();
            Thread.Sleep(500);
            Console.WriteLine("\nThe primary Thread ended");
        }
    }
}
