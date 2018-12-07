using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_xash
{
    class Program
    {
        static string[] amisner = { "hunvar", "petrvar", "mart", "april", "mayis", "hunis", "hulis", "ogostos", "september", "hoktember", "noyember", "dektember" };
        
        static void Main(string[] args)
        {
            Console.WriteLine("xash utelu amisa hamarvum");
            Console.WriteLine();
            var xashuteluamis = amisner.Where(x => x.Contains("r")).Select(x=>x.ToUpper());

            foreach (var amis in xashuteluamis)
            {
                Console.WriteLine(amis);              
            }
            Console.ReadKey();
           
        }
        
    }
}
