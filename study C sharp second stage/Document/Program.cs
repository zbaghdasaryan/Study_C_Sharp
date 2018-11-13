using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("SRM\n");
     
            document.Body = "Super Jet 100\n";
        
            document.Footer = "project manager Z. Baghdasaryan";
            document.Show();

            Console.ReadKey();
        }
        
    }
}
