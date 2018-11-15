using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Age = 25;
            Console.WriteLine(user.FirstNaem);
            user.FirstNaem = "Jeko";

            Console.WriteLine(user.date.ToString());
            Console.WriteLine(user.Age);
            Console.WriteLine(new string('*', 50));

            User user2 = new User("login", "jeko", "meko", 50);

            Console.WriteLine(user2.FirstNaem);
            Console.ReadKey();
        }
    }
}
