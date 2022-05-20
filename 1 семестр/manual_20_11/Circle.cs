using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manual_20_11
{
    class Circle : Point
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double PrintSquare()
        {
            return Math.PI * radius * radius;
        }
    }
}
