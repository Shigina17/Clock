using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manual_20_11
{
    class Rectangle : Point
    {
        public double width;
        public double length;

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public override double PrintSquare()
        {
            return width * length;
        }
    }
}
