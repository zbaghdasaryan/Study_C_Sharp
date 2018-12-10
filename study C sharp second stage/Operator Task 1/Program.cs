using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Task_1
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }

        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.x * p2.x, p1.y * p2.y);
        }

        public static Point operator /(Point p1, Point p2)
        {
            if (p2.x != 0 && p2.y != 0)
            {
                return new Point(p1.x / p2.x, p1.y / p2.y);
            }
            else return new Point(0, 0);
        }

        public static Point operator ++(Point p)
        {
            return new Point(p.x + 1, p.y + 1);
        }

        public override bool Equals(object input)
        {
            if (input is Point)
            {
                if (((Point)input).x == x && ((Point)input).y == y)
                return true;
            }
            return false;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(10, 20);
            //Point p3 = new Point(0, 0);

            //Point p3 = p2 + p1;

            //p3.x = p1.x + p2.x;
            //p3.y = p1.y + p2.y;

            //Console.WriteLine("{0}  {1}", p3.x, p3.y);
            Console.WriteLine(p1==p2);
            Console.ReadKey();
        }
    }
}
