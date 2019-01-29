/*
Խնդիր_28:
Ներածել n թիվը։ 
Արտածել yes, եթե այն հավասար է իր թվանշանների գումարի կրկնապատիկին, 
no՝ հակառակ դեպքում։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_Sum
{
    class Program
    {
        static void digitSum(int number)
        {
            int num = number;
            int[] arrayDigit = new int[num.ToString().Length];
            for (int i = 0; i < num.ToString().Length; i++, number /= 10)            
                    arrayDigit[i] = number % 10;                
            Console.WriteLine("sum= " + arrayDigit.Sum());
            string a = 2 * arrayDigit.Sum() == num ? "yes" : "no";
                Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            digitSum(num);
            Console.ReadKey();
        }
    }
}
