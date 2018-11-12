using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    class Shop
    {
        public string Name { get; set; }
        Product[] Goods;
        int[] Product;
        public Shop(string name, Product[] goods, int[] product)
        {
            Name = name;
            Goods = goods;
            Product = product;
        }









    }
}
