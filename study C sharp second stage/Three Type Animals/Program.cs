using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Type_Animals
{
    class ThreeTypeAnimals
    {

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public double Mass { get; set; }
        public int Age { get; set; }

        public ThreeTypeAnimals()
        {

        }

        public ThreeTypeAnimals(string Name, string Gender, string Color, double Mass, int Age)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Color = Color;
            this.Mass = Mass;
            this.Age = Age;            
        }
        //public virtual void Voic()
        //{
        //    Console.WriteLine("");
        //}
    }

    class FlayingAnimals : ThreeTypeAnimals
    {
        public double WingLength { get; set; }

        public FlayingAnimals(double WingLength, string Name, string Gender, string Color, double Mass, int Age) : base(Name, Gender, Color, Mass, Age)
        {
            this.WingLength = WingLength;
        }

        public new string GetType()
        {
            return "Fly animals";
        }

        public override string ToString()
        {
            return $"animal name is {Name}\nanimal mass {Mass} kg\nanimal wing length is {WingLength} m\nanimal collor is {Color}\nanimal gender {Gender}";
        }
    }

    class LandAnimals : ThreeTypeAnimals
    {
        public bool Predator { get; set; }


        public LandAnimals(bool Predator, string Name, string Gender, string Color, double Mass, int Age) : base(Name, Gender, Color, Mass, Age)
        {
            this.Predator = Predator;
        }

        public new string GetType()
        {
            return "Land animals";
        }

        public override string ToString()
        {
            return $"animal name is {Name}\nanimal mass {Mass}\nanimal is {(Predator ? "gishatich" : "yntani")}\nanimal collor is {Color}\nanimal gender {Gender}";
        }
    }

    class WatherAnimals : ThreeTypeAnimals
    {
        public bool DangerousForMen { get; set; }

        public WatherAnimals(bool DangerousForMen, string Name, string Gender, string Color, double Mass, int Age) : base(Name, Gender, Color, Mass, Age)
        {
            this.DangerousForMen = DangerousForMen;
        }

        public new string GetType()
        {
            return "Wather animals";
        }

        public override string ToString()
        {
            return $"animal name is {Name}\nanimal mass {Mass}\nanimal is {(DangerousForMen ? "vtangavor e" : "vtangavor che")}\nanimal collor is {Color}\nanimal gender {Gender}";
        }      
    }

    class Program
    {
        static void Main(string[] args)
        {
            ThreeTypeAnimals[] animals = new ThreeTypeAnimals[15];
             
            animals[0] = new FlayingAnimals(0.2, "agrav", "vorc", "dark grey", 0.35, 200);
            animals[1] = new FlayingAnimals(0.5, "bad", "eg", "white and black", 0.5, 4);
            animals[2] = new FlayingAnimals(1.0, "aragil", "vorc", "white", 3.5, 10);
            animals[3] = new FlayingAnimals(2.0, "arciv", "vorc", "black", 15, 9);
            animals[4] = new FlayingAnimals(0.2, "agrav", "vorc", "dark grey", 0.35, 200);

            animals[5] = new LandAnimals(true, "aryuc", "vorc", "yellow", 100, 20);
            animals[6] = new LandAnimals(false, "shun", "eg", "grey", 15, 10);
            animals[7] = new LandAnimals(false, "katu", "eg", "white", 5, 8);
            animals[8] = new LandAnimals(true, "arj", "vorc", "brown", 200, 18);
            animals[9] = new LandAnimals(false, "muk", "eg", "gery", 0.2, 1);

            animals[10] = new WatherAnimals(true, "akula", "vorc", "gery", 200, 8);
            animals[11] = new WatherAnimals(false, "sig", "vorc", "silver", 0.2, 1);
            animals[12] = new WatherAnimals(false, "ishxan", "eg", "dark silver", 0.3, 1);
            animals[13] = new WatherAnimals(true, "ocadzuk", "eg", "gery", 5, 1);
            animals[14] = new WatherAnimals(true, "utnwtik", "eg", "red", 50, 15);

            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] is FlayingAnimals)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(((FlayingAnimals)animals[i]).ToString());
                    Console.WriteLine();
                }
                else if (animals[i] is LandAnimals)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(((LandAnimals)animals[i]).ToString());
                    Console.WriteLine();
                }
                else if (animals[i] is WatherAnimals)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(((WatherAnimals)animals[i]).ToString());
                    Console.WriteLine();
                }                
            }
            Console.ReadKey();
        }
    }
}
