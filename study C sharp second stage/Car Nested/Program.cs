using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Nested
{
    class Car
    {
        class Zapaska
        {            
            public int pressure;
            

            public int Diametr { get ; set ; }

            public void Pchel(int pressure)
            {
                this.pressure = pressure;
            }
        }
        Zapaska zapas = new Zapaska();
        
        public int PressureInWheel { get; set; }
        public int ZapasPressue
        {
            get
            {
                return zapas.pressure;
            }
        }
        public int ZapasDiametr
        {
            get
            {
                return zapas.Diametr;
            }
            set
            {
                zapas.Diametr = value;
            }
        }

        public void PchelAkery(int pressHimnakan, int pressZapas)
        {
            PressureInWheel = pressHimnakan;
            zapas.pressure = pressZapas;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car avto = new Car();
            avto.ZapasDiametr = 15;
            Console.WriteLine(avto.ZapasDiametr);

            avto.PchelAkery(2300, 2100);         
            Console.WriteLine(avto.PressureInWheel);
            Console.WriteLine(avto.ZapasPressue);
            Console.ReadKey();
        }
    }
}
