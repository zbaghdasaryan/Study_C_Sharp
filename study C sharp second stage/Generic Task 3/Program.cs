using System;

// Универсальные шаблоны. (Универсальный метод)

namespace Generics
{
    class MyClass
    {
        public void Method<T>(T argument)
        {
            T variable = argument;

            Console.WriteLine(variable);
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance1 = new MyClass();
            MyClass instance2 = new MyClass();

            instance1.Method<string>("Hello world!");

            instance1.Method("hello!");
            instance2.Method(12);
            // Delay.
            Console.ReadKey();
        }
    }
}
