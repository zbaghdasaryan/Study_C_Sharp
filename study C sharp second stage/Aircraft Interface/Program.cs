using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft_Interface
{
    class Program

    {
        public interface IAircraft
        {
            string Tipe { get; }
            string Number { get; }
        }

        public abstract class Aircraft : IAircraft
        {
            public abstract string Tipe { get; }

            public abstract string Number { get; }

            public virtual void GetInfoAircraft() { }
        }
        public interface IPassanger
        {
            void Places();
        }

        class Airplane : Aircraft, IPassanger
        {
            public override string Tipe
            {
                get { return "Sukhoi Super Jet 100"; }
            }

            public override string Number
            {
                get { return "95007"; }
            }
            public override void GetInfoAircraft()
            {
                Console.WriteLine($"type {Tipe}, number {Number}");
            }

            public void Places()
            {
                Console.WriteLine("100 places");
            }
        }

        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            airplane.GetInfoAircraft();
            airplane.Places();
            Console.ReadKey();
        }
    }
}
