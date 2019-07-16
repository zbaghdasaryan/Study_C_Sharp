namespace A
{
    private class B
    {
        void f()
        { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.f();
        }
    }
}