using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select shape:");
            Console.WriteLine("1: Rectangle");
            Console.WriteLine("2: Circle");
            Console.WriteLine("3: Rhombus");
            while (true)
            {
                Console.Write("Shape: ");
                int number = TrueNumber(1, 4);
                if (number == 1)
                {
                    Console.WriteLine("Enter Length of Rectangle Sides: ");
                    Console.Write("W = ");
                    int A = TrueNumber(0, int.MaxValue);
                    Console.Write("H = ");
                    int B = TrueNumber(0, int.MaxValue);
                    Rectangle(A, B);
                }
                else if (number == 2)
                {
                    Console.WriteLine("Enter Radius of Circle: ");
                    Console.Write("R = ");
                    int R = TrueNumber(0, int.MaxValue);
                    Circle(R);
                }
                else
                {
                    Console.WriteLine("Enter Width and Height of Rhombus: ");
                    Console.Write("W = ");
                    int A = TrueNumber(0, int.MaxValue);
                    Console.Write("H = ");
                    int B = TrueNumber(0, int.MaxValue);
                    Rhombus(A, B);
                }
            }
        }

        private static void Rectangle(int w, int h)
        {
            Console.WriteLine();
            long A = (long)w * h;
            int min = w <= h ? w : h;
            int max = min == w ? h : w;

            w = max;
            h = min;

            int wScale = Console.WindowWidth / 3;
            int hScale = wScale * min / max * 7 / 10;

            hScale = hScale > 2 ? hScale : 3;
            hScale |= 1;

            int x = Console.CursorLeft + 10;
            int y = Console.CursorTop;

            int wLength = max.ToString().Length;
            int hLength = min.ToString().Length;
            int ALength = $"A = {A}".Length;

            for (int i = 1; i <= hScale; i++)
            {
                Console.CursorLeft = 10;
                for (int j = 1; j <= wScale; j++)
                {
                    if (i == 1 || i == hScale)
                        Console.Write('+');
                    else
                    {
                        if (j == 1 || j == wScale)
                            Console.Write('+');
                        else
                            Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.SetCursorPosition(x + wScale / 2 - wLength + 1, y - 1);
            Console.Write(max);
            Console.SetCursorPosition(x - hLength, y + hScale / 2);
            Console.Write(min);
            Console.SetCursorPosition(x + (wScale - ALength) / 2, y + hScale / 2);
            Console.Write($"A = {A}");
            Console.SetCursorPosition(0, y + hScale);
            Console.WriteLine();
        }

        private static void Circle(int r)
        {
            int y = Console.CursorTop;
            int h = 10;
            int w = 22;
            int a = 10;
            int b = 15;
            Double A = Math.PI * r * r;
            int ALength = $"A = {A:0.00}".Length;

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 40; j++)
                {
                    double temp = 1.0 * (h - i) * (h - i) / (a * a) + 1.0 * (w - j) * (w - j) / (b * b);
                    if (temp > 0.95 && temp < 1.05)
                        Console.Write('+');
                    else
                        Console.Write(' ');
                }
            }
            Console.SetCursorPosition(w, y + h + 1);
            Console.Write("+------------->");
            Console.SetCursorPosition(w + 4, y + h);
            Console.Write($"R = {r}");
            Console.SetCursorPosition(w - ALength / 2, y + h + 4);
            Console.Write($"A = {A:0.00}");
            Console.SetCursorPosition(0, y + 22);
        }

        private static void Rhombus(int w, int h)
        {
            Console.WriteLine();
            long A = (long)w * h;
            int min = w <= h ? w : h;
            int max = min == w ? h : w;

            w = max;
            h = min;

            int wScale = Console.WindowWidth / 4;
            int hScale = wScale * min / max * 7 / 10;

            hScale = hScale > 2 ? hScale : 3;
            hScale |= 1;

            int x = Console.CursorLeft + 12;
            int y = Console.CursorTop;

            int wLength = max.ToString().Length;
            int hLength = min.ToString().Length;
            int ALength = $"A = {A}".Length;

            for (int i = 1; i <= hScale; i++)
            {
                Console.CursorLeft = i + 12;
                for (int j = 1; j <= wScale; j++)
                {
                    if (i == 1 || i == hScale)
                        Console.Write('+');
                    else
                    {
                        if (j == 1 || j == wScale)
                            Console.Write('+');
                        else
                            Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }

            for (int i = 1; i < hScale; i++)
            {
                Console.SetCursorPosition(x - 2, y + i);
                if (i == 1)
                    Console.Write('^');
                else if (i == hScale - 1)
                    Console.Write('-');
                else
                    Console.Write('|');
            }
            Console.SetCursorPosition(10 - hLength, y + hScale / 2);
            Console.Write(min);

            Console.SetCursorPosition(x + wScale / 2 - wLength + 1, y - 1);
            Console.Write(max);

            Console.SetCursorPosition(x + (wScale - ALength) / 2 + hScale / 2, y + hScale / 2);
            Console.Write($"A = {A}");
            Console.SetCursorPosition(0, y + hScale);
            Console.WriteLine();
        }

        static int TrueNumber(int min, int max)
        {
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number) && number >= min && number < max))
                Console.WriteLine("Wrong Selection");
            return number;
        }
    }
}