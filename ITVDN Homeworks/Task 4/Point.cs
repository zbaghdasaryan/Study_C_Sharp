using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Point
    {
        string name;
        public string Name
        {
            get { return name; }
        }

        int x, y;
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get {return y; }
        }
        public Point(string name, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
