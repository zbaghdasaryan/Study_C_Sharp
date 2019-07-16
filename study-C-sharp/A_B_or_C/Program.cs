using System;

namespace A_B_or_C
{
    class Program
    {
        public abstract class A
        {
            public  string Print()
            {
                return "A";
            }
        }

        public class B : A
        {
            public new string Print()
            {
                return "B";
            }
        }

        public class C : B
        {
            public new string Print()
            {
                return "C";
            }
        }
        static void Main(string[] args)
        {
            A ac= new B();
            Console.WriteLine(ac.Print());
            Console.ReadKey();
        }
    }
}
