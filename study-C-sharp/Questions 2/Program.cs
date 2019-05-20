using System;

namespace Questions_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();
        }
    }

    //class A
    //{
    //    public virtual void Foo()
    //    {
    //        Console.Write("Class A");
    //    }
    //}
    //class B : A
    //{
    //    public override void Foo()
    //    {
    //        Console.Write("Class B");
    //    }
    //}
    public struct S : IDisposable
    {
        private bool dispose;
        public void Dispose()
        {
            dispose = true;
        }
        public bool GetDispose()
        {
            return dispose;
        }
    }
}
