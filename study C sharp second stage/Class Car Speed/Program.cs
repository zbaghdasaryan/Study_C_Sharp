using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Car_Speed
{
    class Car
    {
        public string carName;
        public int currentSpeed;

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} Km/H", carName, currentSpeed);
        }
        public void SpeedUp(int addSpeed)
        {
            currentSpeed += addSpeed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car auto1 = new Car();
            auto1.carName = "opel";
            auto1.currentSpeed = 50;
            //Car auto2 = new Car();
            //auto2.carName = "ford";
            //auto2.currentSpeed = 100;
            for (int i = 0; i < 10; i++)
            {
                auto1.PrintState();
                auto1.SpeedUp(5);
               
                //auto2.SpeedUp(10);
                //auto2.PrintState();
            }
            Console.ReadKey();
        }
    }
}
