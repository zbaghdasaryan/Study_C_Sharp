using System;

// Делегаты. (Предположение делегата)

namespace Delegates
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Строку вывел метод сообщенный с делегатом.");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            // MyDelegate myDelegate = new MyDelegate(MyClass.Method);

            MyDelegate myDelegate = MyClass.Method; // Предположение делегата.
            myDelegate();

            // Delay.
            Console.ReadKey();
        }
    }
}
