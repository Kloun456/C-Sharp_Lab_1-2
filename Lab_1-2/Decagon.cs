using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test
{
    class Decagon : Figure
    {
        public double Side { set; get; }
        public override double GetArea() { return 5/2 * Side * Math.Sqrt(5 + 2 * Math.Sqrt(5)); }
    }
}
