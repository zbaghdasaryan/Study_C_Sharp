using System;

// Делегаты.

namespace Delegates
{
    delegate Delegate3 Functional(Delegate1 delegate1, Delegate2 delegate2);
    delegate string Delegate1();
    delegate string Delegate2();
    delegate string Delegate3();

    class Program
    {
        public static Delegate3 MethodF(Delegate1 delegate1, Delegate2 delegate2)
        {
            return delegate { return delegate1.Invoke() + delegate2.Invoke(); };
        }

        public static string Method1() { return "Hello "; }
        public static string Method2() { return "world!"; }

        static void Main()
        {
            Functional functional = new Functional(MethodF);

            Delegate3 delegate3 = functional.Invoke(new Delegate1(Method1), new Delegate2(Method2));

            Console.WriteLine(delegate3.Invoke());

            // Delay.
            Console.ReadKey();
        }
    }
}
