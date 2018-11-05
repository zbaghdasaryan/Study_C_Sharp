using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Hierarchia
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit napo = new Rabbit()
            {
                name = " napo",
                averageWeight = 5,
                Color = "White",
                whatItEat = "Grass"
            };
            //napo.Name = "napo";
            //napo.Weight = 5;
            //napo.Color = "white";
            //napo.WhatItEat = "grass";

            Console.WriteLine(napo.GetRabbitInfo());
            Console.WriteLine();
            Console.WriteLine("if you want to see the next example, press any key ...");
            Console.WriteLine();
            Console.ReadKey();

            Lion aryuc = new Lion()
            {
                name = "Lion",
                averageWeight = 150,
                color = "Yellow",
                whatItEat = "meat"
            };
            Console.WriteLine(aryuc.GetLionInfo());
            Console.WriteLine();
            Console.ReadKey();

            Hyena shakal = new Hyena()
            {
                name = "Hyena",
                averageWeight = 50,
                color = "Gray",
                whatItEat = "meat"
            };
            Console.WriteLine(shakal.GetHyenaInfo());
            Console.WriteLine( );
            Console.ReadKey();

            Man mard = new Man()
            {
                name = "Grish",
                averageWeight = 80,
                color = "Cream",
                WhatEat = "inch patahi"
            };
            Console.WriteLine(mard.GetManInfo());
            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
