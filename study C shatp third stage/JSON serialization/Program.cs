using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSON_serialization
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Company Company { get; set; }

            public Person()
            {
            }

            public Person(string name, int age, Company company)
            {
                Name = name;
                Age = age;
                Company = company;
            }
        }

        static void UseJsonConvert(Person[] pers)
        {
            string serialize = JsonConvert.SerializeObject(pers, Formatting.Indented);
            File.WriteAllText(@"D:\person.json", serialize);
            Console.WriteLine(serialize);
            Person[] peopledeser = JsonConvert.DeserializeObject<Person[]>(serialize);


            foreach (var item in peopledeser)
            {
                Company company = item.Company as Company;
                Console.WriteLine($"Name: {item.Name}, Age:{item.Age}, Company:{company.Name}");
            }
        }

        static void Main(string[] args)
        {
            Person person1 = new Person("Gago", 25, new Company("IMEX"));
            Person person2 = new Person("Luto", 35, new Company("KKG"));
            Person[] peopl = new Person[] { person1, person2 };
            UseJsonConvert(peopl);
        }
    }
}
