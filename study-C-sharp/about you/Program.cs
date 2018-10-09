using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter your First Name ");
            string firstname = Console.ReadLine();

            Console.Write("Please enter your Last name ");
            string lastname = Console.ReadLine();

            Console.Write("Please enter Your Weight ");
            byte weigh = Convert.ToByte(Console.ReadLine());

            Console.Write("Please enter Your Birth Year ");
            short birtyear = Convert.ToInt16(Console.ReadLine());
            int year = 2018 - birtyear;

            if (weigh < 99.9)
            {
                Console.WriteLine($"Dear {firstname} {lastname} you are {year} year old and thin man");
            }
            else
            {
                Console.WriteLine($"Dear {firstname} {lastname} you are {year} year old and fat man");
            }
            Console.ReadKey();

        }
    }
}
