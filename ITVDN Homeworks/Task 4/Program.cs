using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = new int();
            Figure figure = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4));
            Console.Write("{0} P = ", figure.Type);
            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
