using System;
using System.Collections.Generic;
using System.Linq;

// let - представляет новый локальный идентификатор, на который можно ссылаться в остальной части запроса.
// Его можно представить, как локальную переменную видимую только внутри выражения запроса.

namespace LINQ
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Построить коллекцию сотрудников.
            var employees = new List<Employee>
            {
                new Employee {LastName = "Ivanov", FirstName = "Ivan"},
                new Employee {LastName = "Andreev", FirstName = "Andrew"},
                new Employee {LastName = "Petrov", FirstName = "Petr"}
            };

            // Построить запрос.
            var query = from emp in employees
                        let fullName = emp.FirstName + " " + emp.LastName // let - новый локальный идентификатор.
                        orderby fullName descending
                        select fullName;

            foreach (var person in query)
                Console.WriteLine(person);

            // Delay.
            Console.ReadKey();
        }
    }
}
