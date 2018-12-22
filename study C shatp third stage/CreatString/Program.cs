using System;

namespace CreateString
{
    static class Program
    {
        static void Main()
        {
            // "Hello"
            string s = "Hello";
            Console.WriteLine(s);
            Console.WriteLine(s.GetHashCode());
            s=s.Insert(2, "mm");
            Console.WriteLine(s);
            Console.WriteLine(s.GetHashCode());
            // "-----------------------------------------------"
            string s2 = new string('-', 20);
            Console.WriteLine(s2);
            //"Hello-----------------------------------------------"
            s += s2;  //s = s + s2;
            Console.WriteLine(s);
            //"5"
            string s4 = 5.ToString();
            Console.WriteLine(s4);
            //"1 + 2 = 3"
            string s5 = string.Format("{0} + {1} = {2}", 1, 2, 1 + 2);
            Console.WriteLine(s5);
            Console.ReadKey();
        }
    }
}
