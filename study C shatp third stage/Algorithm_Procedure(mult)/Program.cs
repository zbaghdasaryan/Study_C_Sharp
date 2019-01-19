//Если один метод вызывает другой, то необходимо более тщательно оценить сложность последнего. 
//Если в нем выполняется определённое число простых инструкций, то на оценку сложности это практически не влияет. 
//Если же метод вызывается внутри цикла, то влияние может быть намного больше.

//В качестве примера рассмотрим два метода: DoSlowly со сложностью O(n^3) и DoFastly со сложностью O(n^2).

//Если во внутренних циклах процедуры Fast происходит вызов процедуры Slow, то сложности процедур перемножаются. 
//В данном случае сложность алгоритма составляет O(n^2 )*O(n^3 )=O(n^5)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedure
{
    class Program
    {

        // Степень роста метода DoFastly O(n^3)
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

            for (int i = 0; i < inum; i++)
            {
                for (int j = 0; j < jnum; j++)
                {
                    DoSlowly(5, 6, 7);
                }
            }
        }


        static void Main(string[] args)
        {

            DoFastly(1, 1);

            Console.WriteLine("Done");

            Console.ReadKey();
        }
    }
}
