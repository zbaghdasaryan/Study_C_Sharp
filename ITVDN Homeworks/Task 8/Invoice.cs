using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Invoice
    {
        public readonly int account;
        readonly string customer;
        readonly string provider;

        public string Artical { get; set; }
        public int Quantity { get; set; }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public void CostCalculation(bool needNds)
        {
            double cost;
            switch (Artical.ToLower())
            {
                case "laptop":
                    cost = 1500;
                    break;
                case "ssd 120gb":
                    cost = 100;
                    break;
                case "monitor lg":
                    cost = 200;
                    break;
                case "usb":
                    cost = 10;
                    break;
                default:
                    Console.WriteLine("there is no information");
                    return;
            }
            if (needNds)
            {
                cost = cost * 2;
            }
            Console.WriteLine("cost ={0} $", cost * Quantity);

        }
    }
}
