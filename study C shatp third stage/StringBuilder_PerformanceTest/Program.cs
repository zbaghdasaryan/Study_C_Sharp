using System;
using System.Text;

// Использование StringBuilder и замеры производительности.

namespace StringBasics
{
    public class EntryPoint
    {
        static void Main()
        {
            string simpleString = "";

            DateTime time = DateTime.Now;

            // Замер скорости построения обычных строк.
            for (int i = 0; i < 100000; i++)
            {
                simpleString += "a";
            }

            TimeSpan timeSS = DateTime.Now - time;

            Console.WriteLine("Обычная строка построилась за {0}.", timeSS);

            var builder = new StringBuilder();

            time = DateTime.Now;

            // Замер скорости построения строк с использованием StringBuilder.
            for (int i = 0; i < 100000; i++)
            {
                builder.Append("a");
            }

            TimeSpan timeSB = DateTime.Now - time;

            Console.WriteLine("При помощи StringBuilder построилась за {0}.", timeSB);

            Console.WriteLine("Длина обычной строки: {0} символов", simpleString.Length);

            simpleString = builder.ToString();

            Console.WriteLine("Длина StringBuilder строки: {0} символов", simpleString.Length);
            Console.ReadKey();
            // Delay.
            //       Console.ReadKey();
        }
    }
}