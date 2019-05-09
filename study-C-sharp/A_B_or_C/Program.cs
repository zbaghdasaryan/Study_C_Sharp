using System;

namespace A_B_or_C
{
    class Program
    {
        public abstract class A
        {
            public virtual string Print()
            {
                return "A";
            }
        }

        public class B : A
        {
            public virtual new string Print()
            {
                return "B";
            }
        }

        public class C : B
        {
            public override string Print()
            {
                return "C";
            }
        }
        static void Main(string[] args)
        {
            A ac= new C();
            Console.WriteLine(ac.Print());
            Console.ReadKey();
        }
    }
}
