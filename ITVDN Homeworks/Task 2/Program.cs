using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter the first side of rectangle side1 = ");
            //Считывание значений из стандартного входного потока в переменную side
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter the second side of rectangl side2 = ");
            //Считывание значений из стандартного входного потока в переменную side2
            double side2 = Convert.ToDouble(Console.ReadLine());

            //Создание экземпляра класса и передача в пользовательский конструктор двух аргументов
            Rectangle rectangle = new Rectangle(side1, side2);
            //Отображение периметра и площади прямоугольника
            Console.WriteLine("Perimeter = {0}, Area= {1}", rectangle.Perimeter, rectangle.Area);
           

           
            Console.ReadKey();
        }
    }
}
