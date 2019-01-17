using System;
using System.Threading;


namespace Threads
{
    class Program
    {
 
        static void WriteSecond()
        {
            for (int i = 0; i < 5; i++)
            {

            
                Console.WriteLine(new string(' ', 10) + "Secondary");
            }
        }

        static void Main()
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();

            for (int i = 0; i < 10; i++)             
            {
                Console.WriteLine("Primary");
            }
            Console.ReadKey();
        }
    }
}
