/*Խնդիր_8:

Տրված են A և B(A<B) ամբողջ թվերը։ 
Գտնել[A,B] հատվածին պատկանող 3-ին պատիկ առաջին թիվը։
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter second number ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int n = firstNum;

            while ( n <= secondNum)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine(n);
                    n++;
                    break;
                    
                }
            }

            Console.ReadKey();
        }
    }
}
