using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void CreatRandomeIntArray(int l, int rd1, int rd2)
        {
            int[] array = new int[l];
            Random rd = new Random();

            for (int i = 0; i < l; i++)
            {
                array[i] = rd.Next(rd1, rd2);
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("enter array length ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("enter first andome number ");
            int rd1 = int.Parse(Console.ReadLine());
            Console.Write("enter second random number (first random number shuld be less then second random number) ");
            int rd2 = int.Parse(Console.ReadLine());
            CreatRandomeIntArray(num, rd1, rd2);
            Console.ReadKey();
        }
    }
}