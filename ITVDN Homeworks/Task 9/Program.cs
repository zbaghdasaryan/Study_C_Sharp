using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Printer
    {
        protected ConsoleColor color;

        public Printer(ConsoleColor color)
        {
            this.color = color;
        }
        public virtual void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class ColorPrinter : Printer
    {
        public ColorPrinter(ConsoleColor color) : base(color)
        {
         
        }
        //public override void Print(string value)
        //{
        //    Console.WriteLine(value); 
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            ColorPrinter colorPrinter = new ColorPrinter(ConsoleColor.Red);
            colorPrinter.Print("hello");
          


            Printer upColorPrint = colorPrinter; //upcast

            upColorPrint.Print("Jeko");

            ColorPrinter colorPrinter1 = new ColorPrinter(ConsoleColor.Yellow);
            colorPrinter1.Print("hello");
            Console.ReadKey();

        }
    }
}
