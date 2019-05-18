using System;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Сколько раз в этом цикле будет выполняться строка i = j - i;
            //int j = 2;
            //for (int i = 2; i < 32; i = i * 2)
            //{
            //    while (i < j)
            //    {
            //        j = j * 2;
            //    }
            //    i = j - i;
            //}

            //Что будет выведено на консоль в результате выполнения следующего цикла:
            //for (int i = 1; i < 3; i++)
            //{
            //    switch (i)
            //    {
            //        default:
            //            Console.WriteLine($"i = {i++}");
            //            break;
            //    }
            //}

            //Какое число(или какие числа) выведет на консоль следующая программа и почему:
            //    int i = 0;

            //    Console.Write($"\ni1={i++} + \ncalc={Calculate(i)}");
            //    Console.WriteLine("\ncw i= "+i);

            //    Console.ReadKey();
            //}

            //public static int Calculate(int i)
            //{
            //    Console.Write("\ncalc cw="+i++);
            //    return i;

            //Какие из следующих вариантов представляют правильный способ вызова данного метода(правильных вариантов может быть несколько):
            //    Display();

            //    Display(1);

            //    Display(1, 2);

            //    Display(1, 2, 3);

            //    Display(new int[] { 1, 2, 3 });
            //}
            //static void Display(params int[] numbers)
            //{
            //    int result = 0;
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        result += numbers[i];
            //    }
            //    Console.WriteLine(result);
            //Person person = new Person("Tom", 31, "tom@gmail.com");
            //Console.WriteLine(person.name+" "+ person.age+" "+ person.email);
            //Console.ReadKey();
            //B obj1 = new A();
            //obj1.Foo();

            //B obj2 = new B();
            //obj2.Foo();

            //A obj3 = new B();
            //obj3.Foo();
            //int i = 1;
            //object obj = i;
            //++i;
            //Console.WriteLine(i);
            //Console.WriteLine(obj);
            //Console.WriteLine((short)obj);
            //string s1 = string.Format("abccba");
            //string s2 = "abc" + "cba";
            //string s3 = "abccba";

            //Console.WriteLine(s1 == s2);
            //Console.WriteLine(s1.GetHashCode());
            //Console.WriteLine(s2.GetHashCode());
            //Console.WriteLine((object)s1 == (object)s2);
            //Console.WriteLine((object)s1.GetHashCode());
            //Console.WriteLine((object)s2.GetHashCode());
            //Console.WriteLine(s2 == s3);
            //Console.WriteLine(s2.GetHashCode());
            //Console.WriteLine(s3.GetHashCode());
            //Console.WriteLine((object)s2 == (object)s3);
            //Track track = new Track();
            //Auto auto = track;
            //auto.Move();

            //Console.ReadKey();
            Message mes = new Message(Hello);
            mes += Hi;
            mes -= Hello;
           // mes -= Hi;
            mes();
            Console.Read();
        }

        //class Person
        //{
        //    public string name = "Ben";
        //    public int age = 18;
        //    public string email = "ben@gmail.com";

        //    public Person(string name)
        //    {
        //        this.name = name;
        //    }
        //    public Person(string name, int age) : this(name)
        //    {
        //        this.age = age;
        //    }
        //    public Person(string name, int age, string email) : this("Bob", age)
        //    {
        //        this.email = email;
        //    }
        //}
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
        //class Auto
        //{
        //    public virtual void Move()
        //    {
        //        Console.WriteLine("Auto is moving");
        //    }
        //}
        //class Track : Auto
        //{
        //    public override void Move()
        //    {
        //        Console.WriteLine("Track is moving");
        //    }
        //}
        delegate void Message();
        private static void Hello() { Console.WriteLine("Hello"); }
        private static void Hi() { Console.WriteLine("Hi"); }

    }
}

