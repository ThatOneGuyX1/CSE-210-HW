using System;

class Menu
{
    public int Display()
    {
        Console.WriteLine("1. New entry");
        Console.WriteLine("2. View Entries");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("0. Exit");
        string temp = Console.ReadLine();
        int selected = int.Parse(temp);
        return selected;
    }
    

}