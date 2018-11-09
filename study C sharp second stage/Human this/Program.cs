/*
 Սահմանել մարդ class -ը որի մեջ լինի հետևյալ field-ները Անուն, Ազգանուն, Տարիք, Քաշ, Սեռ, 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Human
{
    class Human
    {

        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public byte Age { get ; set ; }
        public byte Weight { get ; set ; }
        public string Gender { get ; set ; }

        public Human()
        {

        }

        public Human(string FirstName):this()
        {
            this.FirstName = FirstName;
        }
        public Human(string FirstName, string LastName) : this(FirstName)
        {
            this.LastName = LastName;
        }
        public Human(string FirstName, string LastName, byte Age) : this(FirstName, LastName)       
        {
            this.Age = Age;
        }
        public Human(string FirstName, string LastName, byte Age, byte Weight) : this(FirstName, LastName, Age)
        {
            this.Weight = Weight;
        }
        public Human(string FirstName, string LastName, byte Age, byte Wheigt, string Gender) : this(FirstName, LastName, Age, Wheigt)
        {
            this.Gender = Gender;
        }


        public void GetHumanInfo()
        {
            Console.WriteLine($"human first name - {FirstName}\nhuman last name - {LastName}\nhuman age - {Age}\nhuman wheiht -{Weight} kg\nhuman gender - {Gender}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human mard1 = new Human("Nikol", "Pashinyan", (byte)34, (byte)80, "Male");
            mard1.GetHumanInfo();
            Console.ReadKey();
        }
    }
}
