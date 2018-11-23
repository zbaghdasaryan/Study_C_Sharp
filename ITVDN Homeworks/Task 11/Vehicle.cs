using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Vehicle
    {

        public uint Price { get; set; }
        public uint MaxSpeed { get; set; }
        public uint Year { get; set; }
        public Vehicle(uint Price, uint MaxSpeed, uint Year)
        {
            this.Price = Price;
            this.MaxSpeed = MaxSpeed;
            this.Year = Year;
        }
    }
    class Car : Vehicle
    {
        public Car(uint Price, uint MaxSpeed, uint Year) : base(Price, MaxSpeed, Year)
        {
        }
    }
    class Ship : Vehicle
    {

        public Ship(uint Price, uint MaxSpeed, uint Year) : base(Price, MaxSpeed, Year)
        {

        }
        private uint places;
        public uint Places
        {
            get { return places; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("places must be >0");
                }
                else
                {
                    places = value;
                }
            }
        }
        private string namePort;
        public string NamePort
        {
            get { return namePort; }
            set
            {
                if (namePort == null)
                {
                    Console.WriteLine("please enter name of port");
                }
                else
                {
                    namePort = value;
                }
            }
        }
    }
    class Plane : Vehicle
    {
        public Plane(uint Price, uint MaxSpeed, uint Year) : base(Price, MaxSpeed, Year)
        {
        }

        public int Hight { get; set; }

        public uint Places
        {
            get { return Places; }
            set
            {
                if (Places < 0)
                {
                    Console.WriteLine("places must be >0");
                }
                value = Places;
            }
        }
    }
}
