using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Redactor redactor = new Redactor();
            redactor.ChooseDocument("c# manual.doc");

            redactor.Creat();
            redactor.Open();
            redactor.Change();
            redactor.Save();

            Console.ReadKey();
        }
    }
}
