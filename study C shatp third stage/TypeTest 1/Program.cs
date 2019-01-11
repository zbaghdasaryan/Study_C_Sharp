using System;

// Рефлексия. Пример получения экземпляра Type.

namespace TypeTest
{
    class MyClass
    {
    }

    class Program
    {
        static void Main()
        {
            var my = new MyClass();
            Type type;

            // Способы получения экземрляра класса Type.

            // 1.
            type = my.GetType();
            Console.WriteLine("1й способ: " + type);

            // 2.
            type = Type.GetType("TypeTest.MyClass"); // Полное квалифицированое имя типа в строковом представлении.
            Console.WriteLine("2й способ: " + type);

            // 3.
            type = typeof(MyClass);
            Console.WriteLine("3й способ: " + type);

            // Delay.
            Console.ReadKey();

        }
    }
}