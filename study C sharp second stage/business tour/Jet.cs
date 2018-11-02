using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_info
{
    public class Jet
    {
        public string JetName { private get ; set ; }
        public int JetDistance { private get; set; }
        public int JetPlaces { private get ; set ; }
        public int JetSpeed { private get ; set ; }
        public string JetColor { private get ; set ; }

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
        public string GetJetInfo()
        {
            return $" jet name is {JetName}\n jet fly dictanc {JetDistance} km\n jet places is {JetPlaces}\n jet max speed is {JetSpeed}\n jet color is {JetColor}\n";
        }                
    }
}
