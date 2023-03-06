using System;

public class Square : Shape
{
    private double _length;

    public Square(string color):base(color)
    {
        _length = 2;
    }

    public override double GetArea()
    {
        return Math.Pow(_length,2);
    }
}