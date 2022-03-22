using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test
{
    class Rhombus : Figure
    {
        public double A_diagonal { set; get; }
        public double B_diagonal { set; get; }
        public override double GetArea() { return (A_diagonal * B_diagonal) / 2; }
    }
}
