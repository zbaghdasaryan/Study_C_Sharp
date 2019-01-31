using System;
using System.Threading;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        static void Factorial()
        {
            Console.WriteLine("ID - " + Thread.CurrentThread.ManagedThreadId);
            int result = 1;
            for (int i = 1; i <= 6; i++)
            {
                result *= i;
            }
            Thread.Sleep(8000);
            Console.WriteLine($"Факториал равен {result}");

        }
        // определение асинхронного метода
        static async void FactorialAsync()
        {
            Console.WriteLine("Начало метода FactorialAsync IDa - " + Thread.CurrentThread.ManagedThreadId); // выполняется синхронно
            await Task.Run(() => Factorial());                            // выполняется асинхронно
            Console.WriteLine("Конец метода FactorialAsyncIDb - " + Thread.CurrentThread.ManagedThreadId);  // выполняется синхронно
            await Task.Run(() => Factorial());
            Console.WriteLine("ffff0000Db - " + Thread.CurrentThread.ManagedThreadId);
        }

        static void Main(string[] args)
        {
            FactorialAsync();   // вызов асинхронного метода

            Console.WriteLine("Введите число: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа равен {n * n}");

            Console.Read();
        }
    }
}