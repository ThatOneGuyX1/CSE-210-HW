using System;

public class Fraction
{
    private int _top;

    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = _top;
    }

    public void GetTop(string top)
    {
        _top = int.Parse(top);
        _bottom = 1;
    }

    public void GetBoth(string top, string bottom)
    {
        _top = int.Parse(top);
        _bottom = int.Parse(bottom);

    }

    public string GetFractionString()
    {
        return ($"{_top}/{_bottom}");
    }

    public double GetDecimalValue()
    {
        double temp = (double)_top / (double)_bottom;
        return temp;
    }




}