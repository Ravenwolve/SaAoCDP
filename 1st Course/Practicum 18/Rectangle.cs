using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace P1_10
{
    internal class Rectangle : Figure
    {
        protected double a, b;
        public Rectangle() 
        {
            a = 0;
            b = 0;
        }
        public Rectangle(double side)
        {
            if (side > 0)
            {
                a = side;
                b = side;
            }
        }
        public Rectangle(double length, double width)
        {
            if (length > 0)
                a = length;
            if (width > 0)
                b = width;
        }
        public override double Square() { return a * b; }
        public override double Perimeter() { return a + b; }
        public override string ToString() { return a.ToString() + 'X' + b.ToString(); }
    }
}
