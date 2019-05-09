using System;

namespace ValueType_ReferenceType1
{
    struct S
    {
        public int x;
       
    }

    class C
    {
        public int x;
    }

    class Program
    {
        static void Main(string[] args)
        {
            S s1 = new S();
            S s2 = new S();

            Console.WriteLine("Structura");

            s2.x = 1;
            Console.WriteLine("s2.x = " + s2.x);

            s1 = s2;
            s2.x = 3;

            Console.WriteLine("s1.x = " + s1.x);
            Console.WriteLine("s2.x = " + s2.x);


            C c1 = new C();
            C c2 = new C();
            Console.WriteLine();
            Console.WriteLine("Class");

            c2.x = 1;
            Console.WriteLine("c2.x = " + c2.x);

            c1 = c2;
            c2.x = 2;

            Console.WriteLine("c1.x = " + c1.x);
            Console.WriteLine("c2.x = " + c2.x);

            object o = s2.x;
            Console.WriteLine(o);
            string name = "zzz";
            string name1 = name;
            name = "aaa";
            Console.WriteLine(name1);
            Console.ReadLine();

            
        }
    }
}
