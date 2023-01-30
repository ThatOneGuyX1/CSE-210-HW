using System;
using System.IO;
using static Entry;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();

    public void Display()
    {
        {
            foreach (Entry entry in _journal)
                {
                    entry.Display();
                }
        }
    }

    public void SaveFile()
    {
        string fileName = "myJournal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName,append:true))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry selected in _journal)
            {
                outputFile.WriteLine($"The Date: {selected._dateOfEntry}");
                outputFile.WriteLine($"The Prompt: {selected._givenPrompt}");
                outputFile.WriteLine($"Dear Diary: {selected._entryString}");
                outputFile.WriteLine();

            }
    
        }
    } 

    public void LoadFile()
    {
        _journal.Clear();
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        { 
            string[] parts = line.Split(",");
            string dateTemp = parts[0];
            string entryTemp= parts[1];

            Entry entry = new Entry();
            entry._dateOfEntry = dateTemp;
            entry._entryString = entryTemp;

            _journal.Add(entry);
        }
    }

}