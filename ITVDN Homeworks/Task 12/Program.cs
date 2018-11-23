using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter the key - ");
           
            string key = Console.ReadLine();

            DocumentWorker doc = null;
            Console.WriteLine();
            switch (key)
            {
                case "Pro":
                    doc = new ProDocumentWork();
                    break;
                case "Expert":
                    doc = new ExpertDocumentWorker();
                    break;
                default:
                    Console.WriteLine("wrong key ");
                    doc = new DocumentWorker();
                    break;
            }
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();
            Console.ReadKey();
        }
    }
}
