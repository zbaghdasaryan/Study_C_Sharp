using System;

namespace ValueType_ReferenceType2
{
    struct User
    {
        public string name;
        public int age;
    }

    class Person
    {
        public string name;
        public int age;
    }

    class Program
    {
        static void ChangeUser1(ref User user)
        {
            user.name = "ZZZ";
            user.age = 20;
        }

        static void ChangeUser2(Person person)
        {
            person.name = "ZZZ";
            person.age = 20;
        }
        static void Main(string[] args)
        {
            User user = new User { name = "AAA", age = 30 };

            ChangeUser1(ref user);
           // ChangeUser1(user);

            //Person person = new Person { name = "AAA", age = 30 };
           // ChangeUser2(person);
            Console.WriteLine(user.name + " " + user.age);
           // Console.WriteLine(person.name + " " + person.age);
            Console.ReadKey();
        }
    }
}
