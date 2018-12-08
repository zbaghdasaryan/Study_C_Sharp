using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_car
{
    struct Customer
    {
        readonly string name;
        readonly string marka;
        readonly string model;
        readonly string telNumber;

        public Customer(string name, string marka, string model, string telNumber)
        {
            this.name = name;
            this.marka = marka;
            this.model = model;
            this.telNumber = telNumber;
        }

        public string Name
        {
            get { return name; }
        }
        public string Marka
        {
            get { return marka; }
        }
        public string Model
        {
            get { return model; }
        }
        public string Tel
        {
            get { return telNumber; }
        }
        public override string ToString()
        {
            return name + " tel. " + telNumber + " marka " + marka +" model " + model;
        }
    }
}
