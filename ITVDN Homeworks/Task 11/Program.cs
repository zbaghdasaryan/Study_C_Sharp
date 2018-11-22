using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(2000000, 250, 2018) { Places = 20, NamePort = "Sevan" };


            Console.WriteLine("vehical price is {0}, max speed is {1}, Year {2}, places {3}, vehical now is in port {4}",
                                ship.Price, ship.MaxSpeed, ship.Year, ship.Places, ship.NamePort);

            Console.ReadKey();
        }
    }
}
