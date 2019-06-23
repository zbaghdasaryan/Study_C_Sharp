using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task Id "+ Thread.CurrentThread.ThreadState);
            Task task1 = new Task(() => Console.WriteLine("Task1"));
            task1.Start();

            Console.WriteLine("Task Id " + Thread.CurrentThread.ThreadState);
            Console.WriteLine("Task Id " + Thread.CurrentThread.GetHashCode());
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2"));

            Console.WriteLine("Task Id " + Thread.CurrentThread.GetHashCode());
            Task task3 = Task.Run(() => Console.WriteLine("Task3"));
            Console.ReadLine();
        }
    }
}
