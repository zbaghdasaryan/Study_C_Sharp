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
            Console.WriteLine("xash utelu amisner en hamarvum\n");
            var xashuteluamis = amisner.Where(x => x.Contains("r")).Select(x=>x);
            
            foreach (var amis in xashuteluamis)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(amis);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            bool flag = true;
            foreach (var itam in xashuteluamis)
            {
                int tt = Array.IndexOf(amisner, itam);
                int yy = DateTime.Now.Month;
                if (Array.IndexOf(amisner, itam) + 1 == DateTime.Now.Month)
                {
                    Console.WriteLine("\nxash utelu amisa");
                    flag = !flag;
                    break;
                }
            }
            if (flag)
            {
           
                Console.WriteLine("\nxash utelu amis chi");
            }
            Console.ReadKey();
           
        }
        
    }
}
