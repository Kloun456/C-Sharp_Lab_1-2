using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test
{
    class Trapezoid : Figure
    {
        public double A_side { set; get; }
        public double B_side { set; get; }
        public double Height { set; get; }
        public override double GetArea() { return (A_side + B_side) / 2 * Height; }
    }
}
