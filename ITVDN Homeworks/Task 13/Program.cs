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
            Document document = new Document("contract", "body of document", "footer of document");
            //document.Body = "body of document";
            //document.Footer = "footer of document";

            document.Show();

            Console.ReadKey();

        }
    }
}
