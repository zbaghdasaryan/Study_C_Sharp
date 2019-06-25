using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var outer = Task.Factory.StartNew(() =>      // внешняя задача
            {
                Console.WriteLine("Outer task starting...");
                var inner = Task.Factory.StartNew(() =>  // вложенная задача
                {
                    Console.WriteLine("Inner task starting...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Inner task finished.");
                }, TaskCreationOptions.AttachedToParent);
            });
           outer.Wait(); // ожидаем выполнения внешней задачи
            Console.WriteLine("End of Main");

            Console.ReadLine();

        }
    }
}
