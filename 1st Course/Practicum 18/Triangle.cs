using System;

namespace P1_10
{
    internal class Triangle : Rectangle
    {
        protected double c;
        public Triangle() :base()
        {
            c = 0;
        }
        public Triangle(double side) :base(side)
        {
            if (side > 0)
                c = side;
        }
        public Triangle(double base_, double edge) :base(base_, edge)
        {
            if (edge > 0)
                c = edge;
        }
        public Triangle(double a, double b, double c) :base(a, b)
        {
            if (c > 0)
                this.c = c;
        }
        public Triangle(Triangle Object) :base(Object)
        {
            c = Object.c;
        }
        public override double Square()
        {
            double hP = Perimeter() / 2;
            return Math.Sqrt(hP * (hP - a) * (hP - b) * (hP - c));
        }
        public override double Perimeter()
        {
            return base.Perimeter() + c;
        }
        public override string ToString()
        {
            return base.ToString() + 'x' + c.ToString();
        }
    }
}
