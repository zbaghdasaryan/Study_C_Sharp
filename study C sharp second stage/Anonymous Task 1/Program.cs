using System;

// Анонимные типы.

// Анонимные типы предлагают удобный способ инкапсулирования набора свойств в один объект 
// без необходимости предварительного явного определения типа.
// Имя типа создается компилятором и недоступно на уровне исходного кода.
// Анонимные типы являются ссылочными типами, которые происходят непосредственно от класса object.
// Компилятор присваивает им имена, несмотря на то что эти имена недоступны для приложения.

namespace Anonymous
{
    //class MyClass
    //{
    //    public string Name { get; internal set; }
    //    public int Age { get; internal set; }
    //}

    class Program
    {
        static void Main()
        {
            var instance = new { Name = "Zoro", Age = 34 };
            //instance.Name = "zzz"; only get !
            Console.WriteLine("Name = {0}, Age = {1}", instance.Name, instance.Age);

            Type type = instance.GetType();
           
            Console.WriteLine(type.ToString());

            // Delay.
            Console.ReadKey();
        }
    }
}
