using System;
using System.Linq;

// into - подобно let, позволяет определить локальный по отношению к запросу идентификатор.

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Построить запрос.
            // Разделение чисел на четные и нечетные.
            var query = from x in numbers
                        group x by x % 2 into partition
                        where partition.Key == 0
                        select new { Key = partition.Key, Count = partition.Count(), Group = partition };


            foreach (var item in query)
            {
                Console.WriteLine("mod2 == {0}", item.Key);
                Console.WriteLine("Count == {0}", item.Count);

                foreach (var number in item.Group)
                    Console.Write("{0}, ", number);

                Console.WriteLine();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
