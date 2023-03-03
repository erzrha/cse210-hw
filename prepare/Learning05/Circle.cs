using System;

public class Circle : Shape
{
    private double _radius = 0;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14159*(_radius*_radius);
    }
}