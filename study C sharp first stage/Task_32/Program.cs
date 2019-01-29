/*
Խնդիր_32:
Տրված է N բնական թիվը։ 
Օգտագործելով մեկ ցիկլ հաշվել 1 + 1/(1!) + 1/(2!) + 1/(3!) + … + 1/(N!) գումարը 
(N!-ով նշանակված է 1-ից N թվերի արտադրյալը)։ 
Ստացված թիվը հանդիսանում է e հաստատունի մոտավոր արժեքը)։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int N=Convert.ToInt32(Console.ReadLine());            
            double sum = 1, factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
                sum += 1.0 / factorial;               
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
