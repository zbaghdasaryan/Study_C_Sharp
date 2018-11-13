// Задание
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Требуется: 
// Создать класс с именем Address.
// В теле класса, требуется создать поля: index, country, city, street, house, apartment.  
// Для каждого поля, создать свойство с двумя методами доступа. 
// Создать экземпляр класса Address. 
// В поля экземпляра записать информацию о почтовом адресе. 
// Выведите на экран значения полей описывающих адрес.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    //Создание класса Address с полями index, country, city, street, house, apartment.
    class Address
    {
        // Переменные, над которыми нет смысла производить арифметических операций,
        // следует создавать с типом string. (Например: index, или год рождения...)

        //Поле строкового типа с модификатором доступа private. Доступ к закрытым членам можно получить только внутри тела класса.

        string index;
        string country;
        string city;
        string street;
        string home;
        string apartment;

        //Создание свойства с модификатором доступа public. Public доступ является уровнем доступа с максимальными правами. Ограничений доступа не существует.
        public string Index { get => index; set => index = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string Home { get => home; set => home = value; }
        public string Apartment { get => apartment; set => apartment = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создание экземпляра класса по сильной ссылке.
            Address address = new Address();

            //Обращение к свойствуам класса Address и вызов метода 'set' для присвоения значения.
            address.Index = "1001";
            address.Country = "Armenia";
            address.City = "Yerevan";
            address.Street = "Baghramyan";
            address.Home = "1";
            address.Apartment = "2";

            //С помощью метода Console.WriteLine обращение к свойствам класса Address и вызов метода 'get' для отображения значения.
            Console.WriteLine(address.Index);
            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.Home);
            Console.WriteLine(address.Apartment);

            Console.ReadKey();
        }
    }
}
