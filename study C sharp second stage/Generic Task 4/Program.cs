using System;

// Универсальные шаблоны. (Универсальный делегат)

namespace Generics
{
    // На 11-й строке создаем класс-делегата с именем  MyDelegate, параметризированный двумя Указателями Места Заполнения Типом - Т и R,
    // метод который будет сообщен с экземпляром данного класса-делегата, будет принимать один аргумент, типа Указателя Места Заполнения Типом - Т,
    // и возвращать значение типа Указателя Места Заполнения Типом - R.

    delegate R MyDelegate<T, R>(T t);

    class Program
    {
        public static int Add(int i)
        {
            return ++i;
        }

        public static string Concatenation(string s)
        {
            return "Hello " + s + "!";
        }


        static void Main()
        {
            MyDelegate<int, int> myDelegate1 = new MyDelegate<int, int>(Add);
            int i = myDelegate1.Invoke(1);
           
            Console.WriteLine(i);

            MyDelegate<string, string> myDelegate2 = new MyDelegate<string, string>(Concatenation);
            string s = myDelegate2("Alex");
            Console.WriteLine(s);

            // Delay.
            Console.ReadKey();
        }
    }
}
