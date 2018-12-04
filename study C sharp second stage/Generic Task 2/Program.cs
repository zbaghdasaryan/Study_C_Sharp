using System;

// Универсальные шаблоны.

namespace Generics
{
    class MyGenerics<TYPE1, TYPE2, TYPE3>
    {
        // Поля
        private TYPE1 variable1;
        private TYPE2 variable2;
        private TYPE3 variable3;

        // Конструктор.
        public MyGenerics(TYPE1 argument1, TYPE2 argument2, TYPE3 argument3)
        {
            this.variable1 = argument1;
            this.variable2 = argument2;
            this.variable3 = argument3;
        }

        // Свойства.
        public TYPE1 Variable1
        {
            get { return this.variable1; }
            set { this.variable1 = value; }
        }

        public TYPE2 Variable2
        {
            get { return this.variable2; }
            set { this.variable2 = value; }
        }

        public TYPE3 Variable3
        {
            get { return this.variable3;}
            set {this.variable3 = value; }
    }

    class Program
    {
        static void Main()
        {
            MyGenerics<int, int, int> instance1 = new MyGenerics<int, int, int>(1, 2, 20);
            Console.WriteLine(instance1.Variable1 + instance1.Variable2);

            MyGenerics<string, int, double> instance2 = new MyGenerics<string, int, double>("Number ", 1, 20.1);
            Console.WriteLine(instance2.Variable1 + instance2.Variable2);

            MyGenerics<string, string, byte> instance3 = new MyGenerics<string, string, byte>("Hello ", "World",8);
            Console.WriteLine(instance3.Variable1 + instance3.Variable2);

            // Delay.
            Console.ReadKey();
        }
    }
}
