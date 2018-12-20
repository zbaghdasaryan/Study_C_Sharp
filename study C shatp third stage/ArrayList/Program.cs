using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_List
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList info = new ArrayList();
            string temp;
            do
            {
                Console.WriteLine("any information?");
                if ((temp = Console.ReadLine()) != "") 
                info.Add(temp);
            }
            while (temp != "");
            foreach (var item in info)
            {
                Console.WriteLine("information is ---> {0}", item);                
            }
            Console.ReadKey();
        }
    }
}
