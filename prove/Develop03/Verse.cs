using System;

public class Verse
{
    private List<Word> _verseText = new List<Word>();

    
    public void HideWord()
    {
        int x = 0;
        int count = 0;
        while (x != 1)
        {
            Random random = new Random();
            count += 1;
            int max = _verseText.Count;
            int position = random.Next(0,max);
            if (_verseText[position].CheckVisiblity() == true)
            {
                _verseText[position].SetVisiblity(false);
                x = 1;
            }  
            else if (count == max)
            {
                x = 1;
            }
        }
        
    }
    public void DispalyVerse()
    {
        foreach(Word w in _verseText)
        {
            if(w.CheckVisiblity() == true)
            {
                w.showWord();
            }
            
            else if (w.CheckVisiblity() == false)
            {
                Console.Write("___ ");
            }
        }
        Console.WriteLine();
    }
    public void SetVerse(string verseText)
    {
        string[] split = verseText.Split(" ");
        foreach (string x in split)
        {
            Word temp = new Word(x);
            _verseText.Add(temp);
        }
    }

}