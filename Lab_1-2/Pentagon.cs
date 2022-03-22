using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test
{
    class Pentagon : Figure
    {
        public double Side { set; get; }
        public override double GetArea() { return Side / 4 * Math.Sqrt(25 + 10 * Math.Sqrt(5)); }
    }
}
