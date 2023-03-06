using System;


public class Shape
{
    private string _color;


    public Shape(string color)
    {
        SetColor(color);
    }

    private void SetColor(string colorSet)
    {
        _color = colorSet;
    }

    public string GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return 2.2;
    }

}