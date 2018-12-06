using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // База данных сотрудников.
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Salary = 94000,
                    StartDate = DateTime.Parse("1/4/1992")
                },
                new Employee
                {
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Salary = 123000,
                    StartDate = DateTime.Parse("12/3/1985")
                },
                new Employee
                {
                    FirstName = "Andrew",
                    LastName = "Andreev",
                    Salary = 1000000,
                    StartDate = DateTime.Parse("1/12/2005")
                },
                new Employee
                {
                    FirstName="Gayush",
                    LastName="Poghosyan",
                    Salary=200000,
                    StartDate =DateTime.Parse("02/12/2011")
                },
                new Employee
                {
                    FirstName="Begemotik",
                    LastName="Armaghanyan",
                    Salary=180000,
                    StartDate = DateTime.Parse("01/03/2016")
                },
                new Employee
                {
                    FirstName="Makaron",
                    LastName="Kirakosyan",
                    Salary=180000,
                    StartDate =DateTime.Parse("01/03/2016")
                }
            };

            // Выражение запроса.
            var query = // query - переменная запрса.
                        from employee in employees // from - объявляет переменную диапазона employee.
                        where employee.Salary > 100000 // where - фильтр
                        orderby employee.LastName, employee.FirstName
                        select new // select - Опреация проекции.
                        {
                            LastName = employee.LastName,
                            FirstName = employee.FirstName
                        };

            Console.WriteLine("Высокооплачиваемые сотрудники:\n");

            foreach (var item in query)
                Console.WriteLine("{0} {1}\n", item.LastName, item.FirstName);

            // Delay.
            Console.ReadKey();
        }
    }
}
