using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aircraft_info
{
    class Program
    {
        static void Main(string[] args)
        {            
            Aeroport aeroport1 = new Aeroport("Zvartnoc", 5);
            Aeroport aeroport2 = new Aeroport("Gyumri", 3);
           
            Jet jet1 = new Jet("bisness_jet_1", 200, 8, 400, "black");
            Jet jet2 = new Jet("bisness_jet_2", 300, 10, 450, "yellow");
            Jet jet3 = new Jet("bisness_jet_3", 400, 12, 500, "whith");
            Jet jet4 = new Jet("bisness_jet_4", 600, 15, 550, "red");
            Jet jet5 = new Jet("bisness_jet_5", 700, 20, 600, "green");

            aeroport1.FillAeroport(jet1);
            aeroport1.FillAeroport(jet2);
            aeroport1.FillAeroport(jet3);
            aeroport1.FillAeroport(jet4);
            aeroport1.FillAeroport(jet5);

            aeroport2.FillAeroport(new Jet("bisness_jet_6",500,50,800,"grey"));
            aeroport2.FillAeroport(new Jet("bisness_jet_7", 500, 40, 800, "black"));
            aeroport2.FillAeroport(new Jet("bisness_jet_8", 500, 10, 800, "blue"));

            // information about first aeroport
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"aircrafts in {aeroport1.NameOfAeroport} aeroport \n");
            for (int i = 0; i < aeroport1.jetArry.Length; i++)               
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(aeroport1.jetArry[i].GetJetInfo());                
            }
            
            // information about second aeroport
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine ($"aircrafts in {aeroport2.NameOfAeroport} aeroport \n");
            for (int i = 0; i < aeroport2.jetArry.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(aeroport1.jetArry[i].GetJetInfo());
            }

            Console.ReadKey();



        }
    }
}
