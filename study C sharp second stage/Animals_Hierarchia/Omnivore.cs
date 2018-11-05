using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Hierarchia
{
    class Omnivore:Animal
    {
        public string WhatEat { get; set; }
    }
    class Man:Omnivore
    {
        public string color { get; set; }
        public string GetManInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return $"animal name is {name}\nanimal weight is {averageWeight}\nanimal collor is {color}\nanimal eat {WhatEat}";
        }
    }
}
