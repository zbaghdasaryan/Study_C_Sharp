using System;
using System.Collections;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }

    class Numbers
    {
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 6; i++)
            {
                yield return i * i;
            }
        }
    }
}