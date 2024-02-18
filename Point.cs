using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Point
    {
        int x, y;
        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "x=" + x + " y=" + y;
        }

        public double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
