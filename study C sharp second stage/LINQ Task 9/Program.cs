using System;
using System.Collections.Generic;
using System.Linq;

// select - (Операция проекции) используется для производства конечного результата запроса.

namespace LINQ
{
    public class Result
    {
        public Result(int input, int output)
        {
            Input = input;
            Output = output;
        }

        public int Input { get; set; }
        public int Output { get; set; }
    }

    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };

            // Построить запрос.
            var query = from x in numbers
                        select new Result(x, x * 2);

            numbers[0] = 777; // Выражение запроса выполняется в момент обращения к переменной запрса в foreach.

            foreach (var item in query)
                Console.WriteLine("Input = {0}, \t Output = {1}", item.Input, item.Output);

            // Delay.
            Console.ReadKey();
        }
    }
}
