using System;
using System.Collections.Generic;
using System.Linq;

// select - (Опреация проекции) используется для производства конечного результата запроса.

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };

            // Построить запрос.
            var query = from x in numbers
                        select new { Input = x, Output = x * 2 };

            foreach (var item in query)
                Console.WriteLine("Input = {0}, \t Output = {1}", item.Input, item.Output);

            // Delay.
            Console.ReadKey();
        }
    }
}
