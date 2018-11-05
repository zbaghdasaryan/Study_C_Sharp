using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Hierarchia
{
    public class Animal
    {
        public string name { get ; set ; }
        public double averageWeight { get ; set ; }

        public Animal()
        {

        }

        public Animal(string name, double weight)
        {
            this.name = name;
            this.averageWeight = weight;
        }
    }
    

}
