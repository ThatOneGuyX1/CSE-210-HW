using System;

class Program
{
    static void Main(string[] args)
    {

    List<string> prompts = new List<string>
    {
        "How was your day?",
        "What was the weirdest part of your day",
        "Did you kiss a girl?",

    };
        int menuTarget  = 100;
        Menu menu1 = new Menu();
        Journal myJournal = new Journal();
        while (menuTarget != 0)
        {
            
            menuTarget = menu1.Display();
            

            if (menuTarget == 1)
            {
            Random random = new Random();
            Entry entry = new Entry();
            int randomIndex = random.Next(prompts.Count);
            entry._givenPrompt =prompts[randomIndex];
            DateTime theCurrentTime = DateTime.Now;
            entry._dateOfEntry = theCurrentTime.ToShortDateString();
            Console.WriteLine($"Prompt: {entry._givenPrompt}");
            entry._entryString = Console.ReadLine();
            myJournal._journal.Add(entry);
            }


            else if (menuTarget == 2)
            {
                myJournal.Display();
            }

            

        }

        myJournal.SaveFile();
    
    
    
    
    }
}