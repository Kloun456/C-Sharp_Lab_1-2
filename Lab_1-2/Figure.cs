using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test
{
    abstract class Figure
    {
        public string Name { set; get; }
        public abstract double GetArea();
    }
}
