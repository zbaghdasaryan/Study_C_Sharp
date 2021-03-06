﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Display()
        {
            Console.WriteLine("\nНачало работы метода Display");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.Write(". ");
            }
            Console.WriteLine("\nЗавершение работы метода Display");
        }
        static void Main(string[] args)
        {
            Task task = new Task(Display);
            task.Start();
            task.Wait(); //Чтобы указать, что метод Main должен подождать до конца выполнения задачи, нам надо использовать метод Wait:
            Console.WriteLine("\nЗавершение метода Main");
            Console.ReadLine();
        }
    }
}
