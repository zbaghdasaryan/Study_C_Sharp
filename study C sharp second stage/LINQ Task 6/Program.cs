using System;
using System.Collections;
using System.Linq;

// Применение запроса к коллекции которая поддерживает IEnumerable не параметризированный.

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);

            // ЯВНОЕ указание типа Int32 переменной диапазона - n.  (var - НЕВОЗМОЖНО использовать т.к. IEnumerable не параметризированный!)
            var query = from int n in numbers
                        select n * 2;

            foreach (var item in query)
                Console.WriteLine(item);

            // Delay.
            Console.ReadKey();
        }
    }
}
