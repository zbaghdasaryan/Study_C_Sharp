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
        public byte GetWeight()
        {
            return weight;
        }
        public string GetGender()
        {
            return gender;
        }

        public void PrintHuman()
        {
            Console.WriteLine("you create a new human ");
            Console.WriteLine();
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
            Console.Write("please enter human first name - ");
            string firstname = Console.ReadLine();
            mard1.SetFirstName(firstname);

            Console.Write("please enter human last name - ");
            string lastname = Console.ReadLine();
            mard1.SetLastName(lastname);

            Console.Write("please enter human age - ");
            byte age = Convert.ToByte(Console.ReadLine());
            mard1.SetAge(age);

            Console.Write("please enter human weight - ");
            byte weight = Convert.ToByte(Console.ReadLine());
            mard1.SetWeight(weight);

            Console.Write("please enter human gender - ");
            string gender = Console.ReadLine();
            mard1.SetGender(gender);

            Console.WriteLine();


            mard1.PrintHuman();
            mard1.PrintFirstNaem();
            mard1.PrintLastNaem();
            mard1.PrintAge();
            mard1.PrintWeight();
            mard1.PrintGender();

            if (mard1.GetWeight() <= 50 && mard1.GetGender() == "male")
                Console.WriteLine("\n human is thin man");
            else if (mard1.GetWeight() > 50 && mard1.GetWeight() < 85 && mard1.GetGender() == "male")
                Console.WriteLine("\n human have a normal weight");
            if (mard1.GetWeight() <= 50 && mard1.GetGender() == "female")
                Console.WriteLine("\n human have a normal weight");
            else if (mard1.GetWeight() > 50 && mard1.GetWeight() < 85 && mard1.GetGender() == "female")
               
            Console.WriteLine("\n human is a fat");
            else
                
            Console.WriteLine("\n fat men ");
            
            Console.ReadKey();
        }
    }
}
