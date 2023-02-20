using System;

public class Reference
{
    public string _targetBook;

    public string _targetChapter;

    public int _targetStartVerse;

    public int _targetEndVerse;

    
    public void getBook()
    {
        Console.Write("Please enter what book you want: ");
        _targetBook = Console.ReadLine();
    }

    public void getChapter()
    {
        Console.Write("Please enter what chapter you want: ");
        _targetChapter = Console.ReadLine();
    }

    public void getVerse()
    {
        Console.Write("Please Enter what verse(s) you want (for single verses use format 3-3):");
        string verse = Console.ReadLine();
        string[] temp = verse.Split('-');
        _targetStartVerse = int.Parse(temp[0]);
        _targetEndVerse = int.Parse(temp[1]);
        
        
    }
}