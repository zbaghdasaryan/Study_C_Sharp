using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray1 = new string[5];
            string[] stringArray2 = new string[] { "1", "2", "3", "4" };
            string[] stringArray3 = new[] { "1", "2", "3", "4" };
            stringArray1[0] = "tiv";

            List<int> intList1 = new List<int>();
            intList1.Add(2);
            intList1.Add(4);
            intList1.Add(7);
            intList1.Add(12);

            List<int> intList2 = new List<int>
            {
                2,
                4,
                7,
                12
            };
            

            List<int> intList3 = new List<int> { 1, 1, 2, 3, 5, 78 };

            foreach (var item in intList3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------\n");
            Console.ReadKey();

            intList3.Add(22);
            intList3.Remove(2);
            intList3.RemoveAt(1);
            intList3.RemoveAll(item => item > 5);

            foreach (var item in intList3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------\n");
            Console.ReadKey();

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(0, "qwezzz");
            dic.Add(2, "azzqerz");
            dic.Add(1, "sdzzdfsfz");
            dic.Add(3, "zzfgsfz");
            
            if (!dic.ContainsKey(0))
            {
                dic.Add(0, "zzzz");
            }
            else dic[0] = "zzzz";

            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------\n");
            Console.ReadKey();
        }
    }
}
