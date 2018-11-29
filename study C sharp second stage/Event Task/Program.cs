using System;

// События.

namespace Events
{
    public delegate void EventDelegate(double firstNumber, double secondNumber);

    public class MyClass
    {
        public event EventDelegate myEvent = null;

        public void InvokeEvent()
        {
            myEvent?.Invoke(10, 20);
        }
    }

    class Program
    {
        // Методы обработчики события.

        static private void Handler1(double x, double y)
        {
            double result = x + y;
            Console.WriteLine("x + y = " + result);
        }

        static private void Handler2(double x, double y)
        {
            double result = x - y;
            Console.WriteLine("x - y = " + result);
        }

        static private void Handler3(double x, double y)
        {
            double result = x * y;
            Console.WriteLine("x * y = " + result);
        }

        static private void Handler4(double x, double y)
        {
            if (y != 0)
            {
                double result = x / y;
                Console.WriteLine("x / y = " + result);
            }
            else Console.WriteLine("cant dividet by 0");
        }
        static void Main()
        {
            MyClass instance = new MyClass();
            instance.InvokeEvent();
            // Присоединение обработчиков событий. (Подписка на событие)
            instance.myEvent += Handler1;
            instance.myEvent += Handler2;
            instance.myEvent += Handler3;
            instance.myEvent += Handler4;

            // Метод который вызывает событие.
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Открепляем Handler2().
            instance.myEvent -= Handler2;

            instance.InvokeEvent();

            // Delay.
            Console.ReadKey();
        }
    }
}