using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_car
{
    class Program
    {
        static void Main(string[] args)
        {
            var listCar = new List<Car>
            {
                new Car("Mercedes", "C240", 2003, "Silver"),
                new Car("Mercedes", "C63", 2017, "Gray"),
                new Car("BMW", "E60", 2004, "Silver"),
                new Car("Lada Niva", "2121", 2018, "Whith"),
                new Car("Mercedec", "S63", 2018, "Black"),
                new Car("Honda", "CRV", 2010, "Red"),
                new Car("Mitsubisi", "Airtrack", 2014, "Blu")
            };
            foreach (var auto in listCar)
            {
                Console.WriteLine(auto);
            }
            Console.WriteLine(new string('-', 39));
            Console.WriteLine();

            var listCustomer = new List<Customer>
            {
                new Customer("Zoro", "Mercedes","S63", "091558085"),
                new Customer("Ashot", "BMW", "E60","095512315"),
                new Customer("Tiko", "Honda", "CRV", "091115335"),
                new Customer("Ani", "Mercedes", "C63", "091542456"),
            };
            foreach (var customer in listCustomer)
            {
                Console.WriteLine(customer.ToString());
            }
            Console.WriteLine(new string('-', 33));
            Console.WriteLine();

            var query = from auto in listCar
                        select new { auto.Marka, auto.Color };
            foreach (var item in query)
            {
                Console.WriteLine("Car marka is {0} - color {1}", item.Marka, item.Color);
            }
            Console.WriteLine(new string('-', 34));
            Console.WriteLine();

            var query1 = from customer in listCustomer
                         join auto in listCar on customer.Model equals auto.Model
                         select new
                         {
                             Name = customer.Name,
                             Tel = customer.Tel,
                             Marka = customer.Marka,
             
                             Color = auto.Color,
                             Model = auto.Model,
                             Year = auto.Year
                         };
            foreach (var item in query1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0} {1} {2} {3} {4} {5}",item.Name, item.Tel, item.Marka, item.Model, item.Year, item.Color);
            }

            Console.ReadKey();
        }
    }
}
