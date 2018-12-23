using System;
using System.Text;

// Использование StringBuilder.

namespace StringBasics
{
    public class EntryPoint
    {
        static void Main()
        {
            var builder = new StringBuilder();

            builder.Append("StringBuilder ").Append("является ").Append("очень ... ");

            string build1 = builder.ToString();

            builder.Append("быстрым");

            string build2 = builder.ToString();

            Console.WriteLine(build1);
            Console.WriteLine(build2);

            // Delay.
            Console.ReadKey();
        }
    }
}