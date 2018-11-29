using System;

// Лямбда выражения и лямбда операторы.

namespace Delegates
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate;

            myDelegate = delegate { Console.WriteLine("Hello 1"); }; // Лямбда-Метод 

            myDelegate += () => { Console.WriteLine("Hello 2"); };   // Лямбда-Оператор.

            myDelegate += () => Console.WriteLine("Hello 3");        // Лямбда-Выражение.

            myDelegate();

            // Delay.
            Console.ReadKey();
        }
    }
}
