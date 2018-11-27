using System;

// Делегаты.

namespace Delegates
{
    // Класс, метод которого будет сообщен с делегатом.
    class MyClass
    {
        // Создаем метод, который планируем сообщить с делегатом.
        public string Method(string name)
        {
            return "Hello " + name;
        }
    }

    // На 21-й строке создаем класс-делегата с именем MyDelegate,
    // метод, который будет сообщен с экземпляром данного класса-делегата, 
    // будет принимать один строковой аргумент и возвращать строковое значение.

    public delegate string MyDelegate(string name);  // Создаем класс делегата. (1) 

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            MyDelegate myDelegate = new MyDelegate(instance.Method); // Создаем экземпляр делегата и сообщаем с ним метод. (2)

            string greeting = myDelegate.Invoke("Jeffrey Richter"); // Вызываем метод сообщенный с делегатом. (3)

            Console.WriteLine(greeting);

            greeting = myDelegate("Grady Booch"); // Другой способ вызова метода сообщенного с делегатом. (3')

            Console.WriteLine(greeting);

            // Delay.
            Console.ReadKey();
        }
    }
}