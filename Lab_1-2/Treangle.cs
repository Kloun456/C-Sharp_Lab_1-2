using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test
{
    class Treangle : Figure
    {
        public double Side { set; get; }
        public double Height { set; get; }
        public override double GetArea() { return (Side * Height) / 2; }
    }
}
