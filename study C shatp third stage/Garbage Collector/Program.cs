using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MyClass
    {
        int k;

        public MyClass(int i)
        {
            k = i;
        }

        // Деструктор
        ~MyClass()
        {
            Console.WriteLine("Объект {0} уничтожен", k);
        }

        // Метод создающий и тут же уничтожающий объект
        public void objectGenerator(int i)
        {
            MyClass ob = new MyClass(i);
        }
    }

    class Program
    {
        static void Main()
        {
            int i = 1;
            MyClass obj = new MyClass(0);

            for (; i < 120000; i++)
            {
                obj.objectGenerator(i);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nКонец");

            Console.ReadLine();
        }
    }
}