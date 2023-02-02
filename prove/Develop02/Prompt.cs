using System;

class Prompt
{
    public List<string> _prompts = new List<string>();

    public void addPrompt()
    {
        Console.Write("Enter a prompt: ");
        string temp = Console.ReadLine();
        Console.WriteLine($"'{temp} is now in prompt list."); 
        _prompts.Add(temp);

    }

    public void saveFile()
    {
                string fileName = "myPrompts.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (string selected in _prompts)
            {
                outputFile.WriteLine(selected);

            }
    
        }
        
    }

    public void LoadFile()
    {
         _prompts.Clear();
        string filename = "myPrompts.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        { 
            string temp = line;
            _prompts.Add(line);
        }
    }
}
