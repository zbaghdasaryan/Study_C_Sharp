using System;
using System.Text.RegularExpressions;

namespace Replace
{
    class Program
    {
        static void Main()
        {
            string result = string.Empty;

            // Замена даты в формате (месяц/день/год) на дату в формате(день-месяц-год).
            result = Regex.Replace("04/17/2012",
                                    "\\b(?<month>\\d{1,2})/(?<day>\\d{1,2})/(?<year>\\d{2,4})\\b",
                                    "${day}-${month}-${year}");

            Console.WriteLine(result);

            // Замена недопустимых символов пустыми символами.
            result = Regex.Replace("@_H e l l o-777.,:;'!@#$%^&*()_-+<>?/",
                                  @"[^\w\.@-]", "");


            Console.WriteLine(result);

            // Задержка.
            Console.ReadKey();
        }
    }
}
