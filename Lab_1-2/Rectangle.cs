using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test
{
    class Rectangle : Figure
    {
        public double Width { set; get; }
        public double Height { set; get; }
        public override double GetArea() { return Width * Height; }
    }
}
