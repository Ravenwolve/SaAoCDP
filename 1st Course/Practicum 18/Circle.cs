using System;

namespace P1_10
{
    internal class Circle : Figure
    {
        protected double r;
        public Circle() { r = 0; }
        public Circle(double radius) { r = radius; }
        public override double Square() { return Math.PI * r * r; }
        public override double Perimeter() { return 2 * Math.PI * r; }
        public override string ToString() { return r.ToString(); }
    }
}
