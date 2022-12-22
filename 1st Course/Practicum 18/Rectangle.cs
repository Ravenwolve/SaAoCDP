namespace P1_10
{
    internal class Rectangle : Figure
    {
        protected double a, b;
        public Rectangle()
        {
            a = b = 0;
        }
        public Rectangle(double side)
        {
            if (side > 0)
                a = b = side;
        }
        public Rectangle(double length, double width)
        {
            if (length > 0)
                a = length;
            if (width > 0)
                b = width;
        }
        public Rectangle(Rectangle Object)
        {
            a = Object.a;
            b = Object.b;
        }
        public override double Square() 
        { 
            return a * b; 
        }
        public override double Perimeter()
        {
            return a + b;
        }
        public override string ToString()
        {
            return a.ToString() + 'x' + b.ToString();
        }
    }
}
