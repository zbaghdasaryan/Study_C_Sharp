using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Matrix
{         
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
            Console.ReadLine();
            b.Show();
            Console.ReadLine();
           // c.Show();

            c = a * b;
            Console.WriteLine("after mult\n");
            c.Show();
            Console.ReadKey();
        }
    }
}

