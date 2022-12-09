using System;

namespace P1_10
{
    internal class Triangle : Rectangle
    {
        protected double c;
        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public Triangle(double side)
        {
            if (side > 0)
            {
                a = side;
                b = side;
                c = side;
            }
        }
        public Triangle(double base_, double edge)
        {
            if (base_ > 0)
                a = base_;
            if (edge > 0)
            {
                b = edge;
                c = edge;
            }
        }
        public Triangle(double a, double b, double c)
        {
            if (a > 0)
                this.a = a;
            if (b > 0)
                this.b = b;
            if (c > 0)
                this.c = c;
        }
        public override double Square() {
            double hP = Perimeter()/2;
            return Math.Sqrt(hP * (hP - a) * (hP - b) * (hP - c));
        }
        public override double Perimeter() { return a + b + c; }
        public override string ToString() { return a.ToString() + 'X' + b.ToString() + 'X' + c.ToString(); }
    }
}
