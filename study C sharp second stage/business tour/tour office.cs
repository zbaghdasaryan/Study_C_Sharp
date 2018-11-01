using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_tour
{
    public class tour_office
    {
        
        public Aeroport[] Aeroports { get ; set ; }

        public tour_office(int N)
        {
            Aeroports = new Aeroport[N];
        }


    }
}
