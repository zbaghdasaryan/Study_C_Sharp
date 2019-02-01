using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site_JSON_Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Company[] comp = JsonReader.GetCompanies(@"https://www.itjobs.am/api/v1.0/companies");

         
            Random random = new Random();
            foreach (Company item in comp)
            {
                File.AppendAllText("text.txt", item.ToString());
                Console.ForegroundColor = (ConsoleColor)random.Next(1, 15);
                Console.WriteLine(item);
                Console.WriteLine();
                //Console.ReadKey();
            }
        }
    }
}
