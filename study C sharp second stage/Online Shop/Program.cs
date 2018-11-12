using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    class Program
    {
        static void Main(string[] args)
        {


            User user = new User(
                "Edvin",
                "Yerevan Street Paruyr Sevak, 56",
                10000,
                0
                );

            Console.WriteLine("List of goods:");
            Console.WriteLine();

            Phone mobilePhone = new Phone(
                "Samsung",
                200,
                "Korea",
                "Octa Core"
                );

            Console.WriteLine("Mobile Phone:");
            Console.WriteLine();
            Console.WriteLine("Brand: " + mobilePhone.Name);
            Console.WriteLine("Price: " + mobilePhone.Price);
            Console.WriteLine("Manufacturer: " + mobilePhone.Manufacturer);
            Console.WriteLine("Processor: " + mobilePhone.Processor);
            Console.WriteLine(new string('-', 25));
            Console.WriteLine();

            Battary phoneBattary = new Battary(
                "Energizzer",
                20,
                "China",
                3000
                );

            Console.WriteLine("Battary:");
            Console.WriteLine();
            Console.WriteLine("Brand: " + phoneBattary.Name);
            Console.WriteLine("Price: " + phoneBattary.Price);
            Console.WriteLine("Manufacturer: " + phoneBattary.Manufacturer);
            Console.WriteLine("Nominal Capacity: " + phoneBattary.MAmper);
            Console.WriteLine(new string('-', 25));
            Console.WriteLine();

            Notebook newNotebook = new Notebook(
                "Lenovo",
                500,
                "China",
                "Octa Core",
                16,
                15.4
                );

            Console.WriteLine("Notebook:");
            Console.WriteLine();
            Console.WriteLine("Brand: " + newNotebook.Name);
            Console.WriteLine("Price: " + newNotebook.Price);
            Console.WriteLine("Manufacturer: " + newNotebook.Manufacturer);
            Console.WriteLine("Processor: " + newNotebook.Processor);
            Console.WriteLine("RAM: " + newNotebook.RAM);            
            Console.WriteLine(new string('-', 25));
            Console.WriteLine();


            Product[] products = new Product[] {
                mobilePhone,
                newNotebook,
                phoneBattary
            };

            Informer informer = new Informer();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Hello {user.Name} your balance {user.Balance}");
                Console.WriteLine();

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Product {i} {products[i].Name} by price {products[i].Price} $");
                }
                Console.WriteLine();
                Console.WriteLine("Select the item number and press Enter:");
                Console.WriteLine();

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);

                if (productNumber >= 0 && productNumber < products.Length)
                {

                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough money");
                    }

                }
                else
                {
                    Console.WriteLine("There are no such products");
                }
            }
        }
    }
}

