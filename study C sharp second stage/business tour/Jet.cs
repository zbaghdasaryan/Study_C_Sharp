using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_tour
{
    public class Jet
    {
        public string JetName { get ; set ; }
        public int JetDistance { get; set; }
        public int JetPlaces { get ; set ; }
        public int JetSpeed { get ; set ; }
        public string JetColor { get ; set ; }


        public Jet()
        {

        }

        public Jet(string name, int distance, int places, int speed, string color)
        {
            JetName = name;
            JetDistance = distance;
            JetPlaces = places;
            JetSpeed = speed;
            JetColor = color;
        }

       

        public void PrintJet()
        {
            Console.WriteLine("jet name is {0}\n jet fly dictanc {1} km\n jet places is {2}\n jet max speed is {3}\n jet color is {4}\n", JetName, JetDistance, JetPlaces, JetSpeed, JetColor);

        }




        //int[] jetarray = new int [5]

    }
}
