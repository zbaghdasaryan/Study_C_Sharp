//Если основная программа вызывает методы по очереди, то их сложности складываются: O(n^2 )+O(n^3)=O(n^3). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedure
{
    class Program
    {

        // Степень роста метода DoSlowly O(n^3)  

        static void DoSlowly(int inum, int jnum, int knum)
        {
            int a = 0;

            for (int i = 0; i < inum; i++)
            {
                for (int j = 0; j < jnum; j++)
                {
                    for (int k = 0; k < knum; k++)

                    {
                        a++;
                    }
                }
            }

            Console.WriteLine("a = {0}", a);
        }

        // Степень роста метода DoFastly O(n^2)

        static void DoFastly(int inum, int jnum)
        {
            int b = 0;

            for (int i = 0; i < inum; i++)
            {
                for (int j = 0; j < jnum; j++)
                {
                    b++;
                }
            }
        }

        static void Main(string[] args)
        {

            DoSlowly(2, 16, 9);
            DoFastly(2, 2);

            Console.WriteLine("Done");

            Console.ReadKey();
        }
    }
}
