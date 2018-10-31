/*
 Սահմանել մարդ class -ը որի մեջ լինի հետևյալ field-ները Անուն, Ազգանուն, Տարիք, Քաշ, Սեռ, 
 որտեղ բոլորը հասանաելի չեն դրսից (private են) և կարող է կատարել հետևյալ գործողությունները
 Առանձին մեթոդներով տպել բորլոր վերը թվարկածները: 
 Առանձին մեթոդներով փոփոխել վերը թվարկածները: 
 Class-ը պետք է ունենա կոնստրուկտոր, որը ինիցիալիզացնի բոլոր վերը նշված field-երը:
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
        private string firstName;
        private string lastName;
        private byte age;
        private byte weight;
        private string gender;

        public Human()
        {

        }

        public Human(string anun, string azganun, byte tariq, byte qash, string ser)
        {
            firstName = anun;
            lastName = azganun;
            age = tariq;
            weight = qash;
            gender = ser;
        }

        public void SetFirstName(string anun)
        {
            firstName = anun;
        }
        public void SetLastName(string azganun)
        {
            lastName = azganun;
        }
        public void SetAge(byte tariq)
        {
            age = tariq;
        }
        public void SetWeight(byte qash)
        {
            weight = qash;
        }
        public void SetGender(string ser)
        {
            gender = ser;
        }
        


        public void PrintFirstNaem()
        {
            Console.WriteLine("Human first name is {0}", firstName);
        }
        public void PrintLastNaem()
        {
            Console.WriteLine("Human last name is {0}", lastName);
        }
        public void PrintAge()
        {
            Console.WriteLine("Human age is {0}", age);
        }
        public void PrintWeight()
        {
            Console.WriteLine("Human weight is {0}", weight);
        }
        public void PrintGender()
        {
            Console.WriteLine("Human gender is {0}", gender);
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Human mard1 = new Human();
            mard1.SetFirstName("Ani");
            mard1.SetLastName("Armaghanyan");
            mard1.SetAge((byte)25);
            mard1.SetWeight((byte)60);
            mard1.SetGender("female");

            mard1.PrintFirstNaem();
            mard1.PrintLastNaem();
            mard1.PrintAge();
            mard1.PrintWeight();
            mard1.PrintGender();

            Console.ReadKey();
        }
        
    }
    
}
