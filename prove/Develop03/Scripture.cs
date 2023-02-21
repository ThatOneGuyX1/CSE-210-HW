using System;

public class Scripture
{
    public Dictionary<string, List<string>> _master = new Dictionary<string, List<string>>();
    // key is a refernce and the content is all the information
    private Reference _targetRefernce = new Reference();
    private List<Verse> _targetList = new List<Verse>();


   public void LoadFile()
    {
        using (var reader = new StreamReader("lds.csv"))
        {
            while (!reader.EndOfStream)
            {
                List<string> temp = new List<string>();
                var line = reader.ReadLine();
                var values = line.Split(",");

                temp.Add(values[5]); // Book
                temp.Add(values[14]); // Chapter
                temp.Add(values[15]); // Verse Number
                temp.Add(values[16]); // Content
                string key = $"{temp[0]} {temp[1]}:{temp[2]}";
                _master[key] = temp;


            }
        }
    }
    public void AskScripture()
    {

        _targetRefernce.setBook();

        _targetRefernce.setChapter();

        _targetRefernce.setVerse();

        
    }
    public void SetScripture()
    {
        int count = 0;
        int max = _targetRefernce.getEndVerse() - _targetRefernce.getStartVerse()+ 1;
        foreach (var key in _master.Keys)
        {
            string targetKey = $"{_targetRefernce.getBook()} {_targetRefernce.getChapter()}:{_targetRefernce.getStartVerse() + count}";
            if (key == targetKey)
            {
                Verse temp = new Verse();
                temp.SetVerse(_master[key][3]);
                _targetList.Add(temp);
                count += 1;
                if (max == count)
                {
                    count = 0;
                }
            }
        }
        foreach (Verse v in _targetList)
        {
            v.DispalyVerse();
        }

    }

    public void Memorize()
    {
        foreach (Verse v in _targetList)
        {
            v.HideWord();
            v.DispalyVerse();
        }
    }
}

