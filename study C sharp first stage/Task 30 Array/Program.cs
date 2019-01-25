/*
Խնդիր_30:
Գտնել բոլոր այն քառանիշ թվերը, որոնցում կրկնվող թվանշան չկա և որոնցում առաջին և
վերջին երկու թվանշաններից կազմված թվերի տարբերությունը հավասար է այդ թվի թվանշանների գումարին։
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_30_Array
{
    class Program
    {
        static void numWithoutFirstDigit()
        {
            int[] arrayDigitFirst = new int[5];

            for (int j = 1023; j < 9876; j++)
            {
                int flag = 0;
                arrayDigitFirst[0] = j;
                for (int i = 1; i < 5; i++)
                {
                    arrayDigitFirst[i] = arrayDigitFirst[0]%10;
                    arrayDigitFirst[0] /= 10;
                }                
                for (int n = 1; n < 4; n++)
                {
                    for (int m = n + 1; m < 5; m++)
                    {
                        if (arrayDigitFirst[n] == arrayDigitFirst[m])
                        {
                            flag = 1;
                            goto ttt;
                        }
                    }
                }
          ttt:
                if (flag == 1)
                    continue;
                Console.WriteLine(j);
                //for (int n = 1; n < 4; n++)
                //{
                //    for (int m = 4; m >0; m--)
                //    {
                //        if (arrayDigitFirst[n] != arrayDigitFirst[m]) ;
                //        Console.WriteLine(arrayDigitFirst[0]);
                //    }                    
            }
        }

        static void Main(string[] args)
        {
            numWithoutFirstDigit();
            Console.ReadKey();
        }





    }
}


