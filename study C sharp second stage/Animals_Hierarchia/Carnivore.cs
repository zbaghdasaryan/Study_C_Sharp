using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Hierarchia
{
    class Carnivore : Animal
    {
        public string whatItEat { get; set; }
    }
    class Lion : Carnivore
    {
        public string color { get; set; }
        public string GetLionInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            return $"animal name is {name}\nanimal weight is {averageWeight}\nanimal collor is {color}\nanimal eat {whatItEat}";
        }
    }

    class Hyena : Carnivore
    {
        public string color { get; set; }
        public string GetHyenaInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            return $"animal name is {name}\nanimal weight is {averageWeight}\nanimal collor is {color}\nanimal eat {whatItEat}";
        }
    }
}
