using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test
{
    class Circle : Figure
    {
        public double Radius { set; get; }
        public override double GetArea() { return Math.PI * Math.Pow(Radius,2); }
    }
}
