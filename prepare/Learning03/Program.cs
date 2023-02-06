using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bob");
        Fraction bob = new Fraction();
        string top;
        string bottom;
        Console.WriteLine(bob.GetFractionString());
        Console.WriteLine(bob.GetDecimalValue());

        Fraction bob2= new Fraction();
        Console.Write("Enter a number: ");
        top = Console.ReadLine();
        bob2.GetTop(top);
        Console.WriteLine(bob2.GetFractionString());
        Console.WriteLine(bob2.GetDecimalValue());

        Fraction bob3 = new Fraction();
        Console.Write("Enter a number: ");
        top = Console.ReadLine();
        Console.Write("Enter a number: ");
        bottom = Console.ReadLine();
        bob3.GetBoth(top, bottom);
        Console.WriteLine(bob3.GetFractionString());
        Console.WriteLine($"{bob3.GetDecimalValue()}");



    }
}