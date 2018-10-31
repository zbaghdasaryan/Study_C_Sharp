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

namespace Fuel_Consumption
{
    class CarFuel
    {
        private string carName;        
        private byte motorVolume;
        private byte fuelConsumption;
      

        public CarFuel()
        {

        }

        public CarFuel(string anun, byte motoricaval, byte vareliqicaxs)
        {
            carName = anun;
            motorVolume = motoricaval;
            fuelConsumption = vareliqicaxs;        
        }

        public void SetCarName(string anun)
        {
            carName = anun;
        }
        
        public void SetMotorVolume(byte motoricaval)
        {
            motorVolume = motoricaval;
        }
        public void SetFuelConsumption(byte vareliqicaxs)
        {
            fuelConsumption = vareliqicaxs;
        }
        public byte GetMotorVolume()
        {
            return motorVolume;
        }

       

        public void PrintCarNaem()
        {
            Console.WriteLine("Car is {0}", carName);
        }
        public void PrintMotorVolume()
        {
            Console.WriteLine("Car motor volume is {0}", motorVolume);
        }
        public void PrintFuelConsumption()
        {
            Console.WriteLine("Car fuel consumption for 100 km is {0} liter", fuelConsumption);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CarFuel car1 = new CarFuel();
            Console.Write("please enter car model- ");
            string name = Console.ReadLine();
            car1.SetCarName(name);
            Console.Write("please enter car motor volume- ");
            byte motorvolume = Convert.ToByte(Console.ReadLine());
            car1.SetMotorVolume(motorvolume);
            Console.WriteLine();
            if (car1.GetMotorVolume() <= 2 && car1.GetMotorVolume() > 1)

                car1.SetFuelConsumption((byte)8);
            else if (car1.GetMotorVolume() <= 3 && car1.GetMotorVolume() > 2)
                car1.SetFuelConsumption((byte)12);
            else if (car1.GetMotorVolume() <= 4 && car1.GetMotorVolume() > 3)
                car1.SetFuelConsumption((byte)17);
            else if (car1.GetMotorVolume() <= 5 && car1.GetMotorVolume() > 4)
                car1.SetFuelConsumption((byte)22);
            else car1.SetFuelConsumption((byte)27);

            car1.PrintCarNaem();
            car1.PrintMotorVolume();
            car1.PrintFuelConsumption();
            Console.ReadKey();
        }

    }

}
