using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Name = "Edvin";
            employee.FamilyName = "Hakobyan";
            employee.Post = "Developer";
            employee.Experience = 0;

            Console.WriteLine("employee {0} {1} is a {2}\n", employee.FamilyName, employee.Name, employee.Post);
            employee.ShowSalary();
            Console.ReadKey();
        }
    }
}
