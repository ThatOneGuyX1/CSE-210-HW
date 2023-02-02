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

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry selected in _journal)
            {
                outputFile.WriteLine(selected._dateOfEntry);
                outputFile.WriteLine(selected._givenPrompt);
                outputFile.WriteLine(selected._entryString);
                outputFile.WriteLine();
            }
    
        }
    } 

    public void LoadFile()
    {
        _journal.Clear();
        string filename = "myJournal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        int lineCount = 0;
        int i ;
        Entry entry = new Entry();
        while(lineCount < lines.Length)
        {
            for ( i = 0; i < 3; i++)
            {
                if (i ==0)
                {
                    entry._dateOfEntry = lines[lineCount];
                    lineCount +=1;
                }

                else if (i ==1)
                {
                    entry._givenPrompt = lines[lineCount];      
                    lineCount +=1;
                }

                else if (i == 2)
                {
                    entry._entryString =lines[lineCount];
                    lineCount +=2;
                }

                else
                {
                    lineCount +=1;
                }
                

            }
        }

            _journal.Add(entry);
            i = 0;
            entry = new Entry();
    }
}   
