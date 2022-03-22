using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        public void Add(Complex b)
        {
            Real += b.Real;
            Imag += b.Imag;
        }
        public void Substract(Complex b)
        {
            Real -= b.Real;
            Imag -= b.Imag;
        }
        public void Multiply(Complex b)
        {
            Real = Real * b.Real - Imag * b.Imag;
            Imag = Real * b.Imag + b.Real * Imag;
        }
        public void Divide(Complex b)
        {
            Real = (Real * b.Real + Imag * b.Imag) / (Math.Pow(b.Imag,2) + Math.Pow(b.Real,2));
            Imag = (b.Real * Imag - Real * b.Imag) / (Math.Pow(b.Imag, 2) + Math.Pow(b.Real, 2));
        }
    }
}
