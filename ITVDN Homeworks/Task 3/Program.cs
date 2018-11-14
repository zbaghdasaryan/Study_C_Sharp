using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the book title");
            string title = Console.ReadLine();
            Console.WriteLine("enter the book awthor");
            string awthor = Console.ReadLine();
            Console.WriteLine("enter the book content");
            string content = Console.ReadLine();

            Book book = new Book(title, awthor, content);

            book.Show();
            Console.ReadKey();
        }
    }
}
