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
            Rows = countOfCollumns;
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
            Console.ReadLine();
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

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int a_rows, a_collumns, b_rows, b_collumns;

            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("the count of collumns of the first matrix must be equal the number of rows of the second matrix\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                try
                {
                    Console.Write("\nenter the count of rows of first matrix  ");
                    a_rows = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nenter the count of collumns of first matrix  ");
                    a_collumns = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nenter the count of rows of second matrix  ");
                    b_rows = Convert.ToInt32(Console.ReadLine());

                    if (a_collumns != b_rows)
                        continue;

                    Console.Write("\nenter the count of collumns of second matrix  ");
                    b_collumns = Convert.ToInt32(Console.ReadLine());

                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nenter only numbers!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Matrix a = new Matrix(a_rows, a_collumns);
            Matrix b = new Matrix(b_rows, b_collumns);
            Matrix c = new Matrix(a_rows, b_collumns);

            for (int i = 0; i < a_rows; i++)
                for (int j = 0; j < a_collumns; j++)
                    a[i, j] = random.Next(100);

            for (int i = 0; i < b_rows; i++)
                for (int j = 0; j < b_collumns; j++)
                    b[i, j] = random.Next(100);

            a.Show();
            b.Show();
            //c.Show();

            // c = a * b;
            // Console.WriteLine("after mult");
            // c.Show();
        }
    }
}

