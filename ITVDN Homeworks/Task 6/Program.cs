using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(485, 486.5, 548, 552, 7.25, 7.33);

            converter.ToUsd(486500);
            converter.FromUsd(100);
            converter.FromRub(1000);
            converter.ToEur(500000);
            Console.ReadKey();
        }
    }
}
