using System;

public class Word
{
    private bool _visiblity;

    private string _word;

    public Word(string x)
    {
        _word = x;
        _visiblity = true;
    }

    public void SetVisiblity(bool x)
    {
        _visiblity = x;
    }

    public bool CheckVisiblity()
    {
        if (_visiblity == true)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
  

    public void showWord()
    {
        Console.Write($"{_word} ");
    }

}