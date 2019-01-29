using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int xPosition = 20;
            int yPosition = 30;
            Console.SetCursorPosition(xPosition, yPosition);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((char)2);
            graundWall();
            Console.ReadLine();

            bool IsGameOn = true;
            ConsoleKey command = Console.ReadKey().Key;
            do
            {
                switch (command)
                {
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(xPosition, yPosition);
                        Console.Write(" ");
                        xPosition++;
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.Write(" ");
                        xPosition--;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Write(" ");
                        yPosition--;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.Write(" ");
                        yPosition++;
                        break;
                }

                Console.SetCursorPosition(xPosition, yPosition);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine((char)2);

            } while (IsGameOn);
        }

        static void graundWall()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write((char)5);
                Console.SetCursorPosition(70, i);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write((char)5);
            }
            for (int j = 0; j < 71; j++)
            {
                Console.SetCursorPosition(j, 0);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write((char)5);
                Console.SetCursorPosition(j, 50);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write((char)5);
            }
           
            

        }
    }
}
