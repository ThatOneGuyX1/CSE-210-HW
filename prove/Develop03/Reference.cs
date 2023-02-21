using System;

public class Reference
{
    private string _targetBook;

    private string _targetChapter;

    private int _targetStartVerse;

    private int _targetEndVerse;

    
    public void setBook()
    {
        Console.Write("Please enter what book you want: ");
        _targetBook = Console.ReadLine();
    }

    public void setChapter()
    {
        Console.Write("Please enter what chapter you want: ");
        _targetChapter = Console.ReadLine();
    }

    public void setVerse()
    {
        Console.Write("Please Enter what verse(s) you want (for single verses use format 3-3):");
        string verse = Console.ReadLine();
        string[] temp = verse.Split('-');
        _targetStartVerse = int.Parse(temp[0]);
        _targetEndVerse = int.Parse(temp[1]);
        
        
    }

    public string getBook()
    {
        return _targetBook;
    }

    public string getChapter()
    {
        return _targetChapter;
    }

    public int getStartVerse()
    {
        return _targetStartVerse;
    }

    public int getEndVerse()
    {
        return _targetEndVerse;
    }





}