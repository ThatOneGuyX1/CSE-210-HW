using System;

class Program
{
    static void Main(string[] args)
    {

        int menuTarget  = 100;
        Menu menu1 = new Menu();

        Prompt promptList = new Prompt();
        promptList.LoadFile();

        Journal myJournal = new Journal();
        myJournal.LoadFile();

        while (menuTarget != 0)
        {
            
            menuTarget = menu1.Display();
            

            if (menuTarget == 1)
            {
            Random random = new Random();
            Entry entry = new Entry();
            int randomIndex = random.Next(promptList._prompts.Count);
            entry._givenPrompt =$"The Prompt: {promptList._prompts[randomIndex]}";
            DateTime theCurrentTime = DateTime.Now;

            entry._dateOfEntry = $"The Date: {theCurrentTime.ToShortDateString()}";
            Console.WriteLine($"{entry._givenPrompt}");
            entry._entryString = $"Dear Diary: {Console.ReadLine()}";
            myJournal._journal.Add(entry);
            }

            else if (menuTarget == 2)
            {
                myJournal.Display();
            }

            else if (menuTarget == 3)
            {
                promptList.addPrompt();
            }
    
        }

        myJournal.SaveFile();
        promptList.saveFile();
    
    
    
    
    }
}