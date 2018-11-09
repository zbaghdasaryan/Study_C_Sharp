using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    class Notebook:Product
    {
        public string Processor { get; private set; }
        public int RAM { get; private set; }
        public double Size { get; private set; }

        public Notebook(string name, int price, string manufacturer, string processor, int ram, double size)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Processor = processor;
            RAM = ram;
            Size = size;
        }
    }
}
