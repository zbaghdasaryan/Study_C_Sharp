using System;

// Абстрактный класс.

namespace Abstraction
{
    // Абстрактный класс.
    abstract class AbstractClass
    {
        public abstract void Method();
    }

    // Конкретный класс.
    class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Implementation");
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClass();

            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
