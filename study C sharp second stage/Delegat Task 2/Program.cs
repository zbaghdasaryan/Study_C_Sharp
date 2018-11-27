using System;

// Делегаты.

namespace Delegates
{
    // Класс, метод которого будет сообщен с делегатом.
    class MyClass
    {
        // Создаем метод, который планируем сообщить с делегатом.
        public void Method()
        {
            Console.WriteLine("Строку вывел метод сообщенный с делегатом.");
        }
    }

    // На 21-й строке создаем класс-делегата с именем MyDelegate,
    // метод, который будет сообщен с экземпляром данного класса-делегата, 
    // не будет ничего принимать и не будет ничего возвращать.

    public delegate void MyDelegate();  // Создаем класс делегата. (1) 

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            MyDelegate myDelegate = new MyDelegate(instance.Method); // Создаем экземпляр делегата. (2)

            myDelegate.Invoke();   // Вызываем метод сообщенный с делегатом. (3)

            myDelegate();          // Другой способ вызова метода сообщенного с делегатом. (3')

            // Delay.
            Console.ReadKey();
        }
    }
}