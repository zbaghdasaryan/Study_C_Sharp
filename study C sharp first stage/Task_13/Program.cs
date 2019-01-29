/*
 Խնդիր_13:
 Տրված է N բնական թիվը։ Հաշվել այդ թվի քառակուսին՝ օգտագործելով հետևյալ բանաձևը. 
 N2 = 1 + 3 + 5 + … + (2*N – 1). 
 Հերթական գումարելին ավելացնելիս արտածել գումարի ընթացիկ արժեքը 
 (արդյունքում կարտածվեն 1-ից մինչև N բոլոր թվերի քառակուսիները)։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int square = 0;
            
            for (int i = 1; i <= num; i ++)
            {
                square += 2*i-1;
            }
            
            Console.WriteLine("square="+ square);
            Console.ReadKey();
        }
    }
}
