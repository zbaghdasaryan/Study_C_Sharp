using System;

// Анонимные (лямбда) методы.

namespace Delegates
{
    // Создаем класс делегата.
    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            // Создаем экземпляр класса-делегата MyDelegate и сообщаем с ним анонимный метод.
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello world!"); };

            // Вызов анонимного метода, сообщенного с делегатом.
            myDelegate();

            // Delay.
            Console.ReadKey();
        }
    }
}
