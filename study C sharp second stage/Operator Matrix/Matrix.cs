using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Matrix
{
    class Matrix
    {
        int[,] array;

        int rows, collumns;

        public int Rows
        {
            get { return rows; }
            set
            {
                if (value > 0)
                    rows = value;
            }
        }

        public int Collumns
        {
            get { return collumns; }
            set
            {
                if (value > 0)
                    collumns = value;
            }
        }

        public int this[int i, int j]
        {
            get { return array[i, j]; }

            set { array[i, j] = value; }
        }

        public Matrix(int countOfRows, int countOfCollumns)
        {
            Rows = countOfRows;
            Collumns = countOfCollumns;
            array = new int[Rows, Collumns];
        }

        public void Show()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Collumns; j++)
                {
                    Console.Write("{0,6}", array[i, j]);
                }
                Console.WriteLine();
            }            
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix mult = new Matrix(a.Rows, b.Collumns);
            for (int i = 0; i < a.Rows; i++)
                for (int k = 0; k < b.Collumns; k++)
                    for (int j = 0; j < a.Collumns; j++)

                        mult[i, k] += a[i, j] * b[j, k];

            return mult;
        }
    }
}
