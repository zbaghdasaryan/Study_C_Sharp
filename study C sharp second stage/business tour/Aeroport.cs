using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_info
{
    public class Aeroport
    {
        public string NameOfAeroport { get; set; }
        public Jet[] jetArray { get; set ; }
        int i;

        public Aeroport(string nameAeroport, int jetCount)
        {
            NameOfAeroport = nameAeroport;
            jetArray = new Jet[jetCount];
        }
        public void FillAeroport(Jet aeroplane)
        {
            
            jetArray[i++] = aeroplane;
        }
    }     
}
