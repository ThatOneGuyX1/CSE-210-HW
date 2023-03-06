using System;

public class Circle : Shape
{
    private double _radius;



    public Circle(string color):base(color)
    {
        _radius = 3;
    }

    public override double GetArea()
    {
        return _radius * 2 * Math.PI;
    }
}