using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Invoice invoice = new Invoice(1011, "customer", "provider") { Artical = "lapTop", Quantity = 1 };
            invoice.CostCalculation(true);
            invoice.CostCalculation(false);
            Console.ReadKey();
        }
    }
}
