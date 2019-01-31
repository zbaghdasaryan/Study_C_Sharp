using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace HelloApp
{
    class Program
    {
        static async void ReadWriteAsync()
        {
            Console.WriteLine("ID 1- "+Thread.CurrentThread.ManagedThreadId);
            string s = "Hello world! One step at a time ";

            // hello.txt - файл, который будет записываться и считываться
            using (StreamWriter writer = new StreamWriter(@"D:\hello.txt", true))
            {
                Console.WriteLine("ID 2- " + Thread.CurrentThread.ManagedThreadId);
                await writer.WriteLineAsync(s+ Thread.CurrentThread.ManagedThreadId);  // асинхронная запись в файл
                Console.WriteLine("ID 3- " + Thread.CurrentThread.ManagedThreadId);
            }
            using (StreamReader reader = new StreamReader(@"D:\hello.txt"))
            {
                Console.WriteLine("ID 4- " + Thread.CurrentThread.ManagedThreadId);
                string result = await reader.ReadToEndAsync();  // асинхронное чтение из файла
                Console.WriteLine("ID 5- " + Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine(result);
            }
        }
        static void Main(string[] args)
        {
            ReadWriteAsync();

            Console.WriteLine("Некоторая работа");
            Console.Read();
        }
    }
}