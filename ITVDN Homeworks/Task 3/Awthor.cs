using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Awthor
    {
        public string name;

        //public string Title { get => title; set => title = value; }
        public Awthor (string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Awthor of the book is " + name);
        }
    }
}
