using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Shape
    {
        public double a, h;
        public string name;
        public Shape(double a, double h, string name)
        {
            this.a = a;
            this.h = h;
            this.name = name;
        }
        public virtual double Area()
        {
            return 0;
        }
    }
    class Rectangular : Shape
    {
        public Rectangular(double a, double h, string name) : base(a, h, name) { }
        public override double Area()
        {
            return a * h;
        }
    }

    class Triangel : Shape
    {
        public Triangel(double a, double h, string name) : base(a, h, name) { }
        public override double Area()
        {
            return a * h/2;
        }
    }
 class Circule : Shape
    {
        const float pi= 3.14f;
        
        Circule(int a, int h, string name) : base(a, h, name) { }
        public Circule(int r, string name) : this(r, 0, name) { }

        public override double Area()
        {
            return a*a*pi;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangular uxxankyun = new Rectangular(10, 20, "uxxankyun");
            Console.WriteLine(uxxankyun.Area());


             Triangel erankyun = new Triangel(10, 20, "erankyun");
            Console.WriteLine(erankyun.Area());

            Circule shrjan = new Circule(10, "shrjan");
            Console.WriteLine(shrjan.Area());

            Console.ReadKey();
        }
    }
}
