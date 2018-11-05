using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Hierarchia
{
    class Herbivore : Animal
    {
        public string whatItEat { get; set; }
    }
    class Rabbit : Herbivore
    {
        public string Color { get; set; }

        public string GetRabbitInfo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            return $"animal name is {name}\nanimal weight is {averageWeight}\nanimal collor is {Color}\nanimal eat {whatItEat}"; 
        }
    }
}
