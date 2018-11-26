using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("contract");
            document.Body = "body of document";
            document.Footer = "footer of document";

            document.Show();

            Console.ReadKey();

        }
    }
}
