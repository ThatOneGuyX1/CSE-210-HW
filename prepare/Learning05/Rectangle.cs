using System;

public class Rectangle : Shape
{
    private double _length;

    private double _width;

    public Rectangle(string color):base(color)
    {
        _length = 2;
        _width = 3;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}