/*Գրել 1-ին interface-ը որը իր մեջ ունի հետևյալ մեթոդները
Տեղաշարժվել
Ձայն արձակել

2-րդ interface-ը
շնչել

3-րդ ինտեռֆեյսը
Մտածել
Ապա իմպլեմետացնել interface-ը:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Task
{
    public enum AnimalType
    {
        camaqain,
        jrain,
        odain
    }

    interface IMuveAndVoice
    {
        void Move();
        void Voice();
    }

    interface IBreathe
    {
        void Breathe();
    }

    interface IThink
    {
        void Think();
    }

    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract AnimalType Type { get; set; }
    }

    class Humen : Animal, IMuveAndVoice, IBreathe, IThink
    {
        public override string Name { get; set; }
        public override AnimalType Type { get; set; }

        public void Breathe()
        {
            Console.WriteLine("humen breathe");
        }

        public void Move()
        {
            Console.WriteLine("humen move");
        }

        public void Think()
        {
            Console.WriteLine("humen think");
        }

        public void Voice()
        {
            Console.WriteLine("humen voice");
        }
    }
    class Eagle : Animal, IMuveAndVoice, IBreathe
    {
        public override string Name { get ; set ; }
        public override AnimalType Type { get ; set ; }

        public void Breathe()
        {
            Console.WriteLine("eagle breathe");
        }

        public void Move()
        {
            Console.WriteLine("eagle move");
        }

        public void Voice()
        {
            Console.WriteLine("eagle voice");
        }
    }

    class Horse : Animal, IMuveAndVoice, IBreathe
    {
        public override string Name { get; set; }
        public override AnimalType Type { get; set; }

        public Horse(string name, AnimalType type)
        {
            Name = name;
            Type = type;
        }

        public void Move()
        {
            Console.WriteLine("horse move");
        }

        public void Voice()
        {
            Console.WriteLine("horse voice");
        }

        public void Breathe()
        {
            Console.WriteLine("horse breathe");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse("dzi", AnimalType.camaqain);
            Humen humen = new Humen
            {
                Name = "Mard",
                Type = AnimalType.camaqain
            };
            Eagle eagle = new Eagle
            {
                Name = "Arciv",
                Type = AnimalType.odain
            };

            object[] ob = new object[] { horse, humen, eagle };

            foreach (var ierordandamy in ob)
            {
                if (ierordandamy is Humen)
                {
                    Console.WriteLine((ierordandamy as Humen).Name);
                }

                if (ierordandamy is Horse)
                {
                    Console.WriteLine((ierordandamy as Horse).Name);
                }

                if (ierordandamy is Animal)
                {
                    Console.WriteLine((ierordandamy as Animal).Name);
                }

                if (ierordandamy is IThink)
                {
                    (ierordandamy as IThink).Think();
                }
                if (ierordandamy is IMuveAndVoice)
                {
                    (ierordandamy as IMuveAndVoice).Move();
                    (ierordandamy as IMuveAndVoice).Voice();
                }
                if (ierordandamy is Eagle)
                {
                    (ierordandamy as Eagle).Breathe();
                }
            }
            Console.ReadKey();
        }
    }
}
