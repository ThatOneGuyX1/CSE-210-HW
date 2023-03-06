using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        shapes.Add(new Rectangle("blue"));
        shapes.Add(new Circle("red"));
        shapes.Add(new Square("green"));

        foreach(Shape item in shapes)
        {
            Console.Write($"Color: {item.GetColor()}   Area: {item.GetArea()}");
            Console.WriteLine("");

        }
    }
}