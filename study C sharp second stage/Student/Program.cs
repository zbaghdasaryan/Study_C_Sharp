using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student usanox = new Student("YSU", "Roman", 4, "Syuzi", "Avetisyan", (byte)20, "Famale");
            
            //string n = usanox.FirstName;
            Console.WriteLine(usanox.GetStudentInfo());
            Console.WriteLine();
            //if (usanox.cours > 4)         
            //    Console.WriteLine("...");
            
            Console.ReadKey();
        }
    }
}
