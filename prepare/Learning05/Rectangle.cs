using System;

public class Rectangle : Shape
{
    private double _length = 0;
    private double _width = 0;

    public Rectangle(double len, double wid, string color) : base(color)
    {
        _length = len;
        _width = wid;
    }

    public override double GetArea()
    {
        return _length * _width;
    }

}