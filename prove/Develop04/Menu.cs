using System;


public class Menu
{
    public string DisplayMenu()
    {
        Console.WriteLine("Please choose an activity or type quit");
        Console.WriteLine("Breath");
        Console.WriteLine("List");
        Console.WriteLine("Reflect");
        Console.WriteLine("quit");

        return Console.ReadLine();
    }
}