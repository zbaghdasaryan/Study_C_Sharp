using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    class Phone:Product
    {
        public string Processor { get; private set; }

        public Phone(string name, int price, string manufacturer, string processor)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Processor = processor;
        }
        public override double GetDiscountPrice(User user)
        {
            return Price*0.5;
        }
    }
}
