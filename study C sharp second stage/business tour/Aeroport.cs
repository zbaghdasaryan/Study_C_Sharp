using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_tour
{
    public class Aeroport
    {
        public string NameOfAeroport { get; set; }
        public Jet[] jetArry { get; set ; }
        int i;


        public Aeroport(string nameAeroport, int N)
        {
            NameOfAeroport = nameAeroport;
            jetArry = new Jet[N];
        }

        public void FillAeroport(Jet aeroplane)
        {
            jetArry[i++] = aeroplane;
        }






    }     
}
