/*
Խնդիր_29:
Եռանիշ թվի առաջին թվանշանը ջնջել։ Եթե ստացված թիվը բազմապատկվի 7-ով, 
կստացվի սկզբնական թիվը։ Գտնել այդպիսի թվերը։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_29_Array
{
    class Program
    {
        static void numWithoutFirstDigit()
        {
            
            int[] arrayDigitFirst = new int[3];
            for (int j = 100; j <= 999; j++)
            {
                arrayDigitFirst[0] = j;
                for (int i = 1; i < 3; i++)
                {
                    arrayDigitFirst[i] = arrayDigitFirst[0] % 10;
                    arrayDigitFirst[0] /= 10;
                }
                int newnum = 10 * arrayDigitFirst[2] + arrayDigitFirst[1];                
                if (j == 7 * newnum)
                    Console.WriteLine($"the number is {j}");
            }
        }
        static void Main(string[] args)
        {
            numWithoutFirstDigit();
            Console.ReadKey();
        }
    }
}
