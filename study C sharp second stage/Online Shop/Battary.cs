using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    class Battary : Product
    {
        public int MAmper { get; set; }

        public Battary(string name, int price, string manufacturer, int mamper)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            MAmper = mamper;
        }
    }
}
