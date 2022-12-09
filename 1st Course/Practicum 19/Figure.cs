using System;
namespace P1_10
{
    abstract internal class Figure : IComparable<Figure>
    {
        abstract public double Square();
        abstract public double Perimeter();

        int IComparable<Figure>.CompareTo(Figure other)
        {
            if (Square() < other.Square())
                return -1;
            else if (Square() == other.Square())
                return 0;
            else return 1;
        }
    }
}
