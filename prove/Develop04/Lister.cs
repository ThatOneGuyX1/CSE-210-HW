using System;

public class Lister : Activity
{
    private List<string> _prompts = new List<string>();

    private List<string> _answers = new List<string>();

    private string GetPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(0,_prompts.Count())];
    }

    private void SetPrompts()
    {
           _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");
    }

    public void RunLister()
    {
        runWelcome();
        SetPrompts();
        string prompt = GetPrompt();
        Console.WriteLine(prompt);
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        PassTime(10);
        while (endTime > currentTime)
        {
            Console.WriteLine("Enter in an answer:");
            _answers.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }
        Console.WriteLine($" You entered {_answers.Count()} answers.");
        SaveAnswers(prompt);
        DisplayEndMessage();
        Console.ReadLine();

    }

    public override void SetDescription()
    {
       _description = "This activity will help you postive experiences and thought. You will list answers within the duration. You can see past answers in a text document.";
    }

    private void SaveAnswers(string prompt)
    {
        string fileName = "Mindfullness Answers.txt";
        using (StreamWriter outputFile =File.AppendText(fileName))
        {
            outputFile.WriteLine($"Todays Date:{DateTime.Now.ToShortDateString()}");
            outputFile.WriteLine($"Prompt: {prompt}");

            // You can add text to the file with the WriteLine method
            for (int i = 0; i < _answers.Count();i++)
            {
                outputFile.WriteLine(_answers[i]);
            }
            outputFile.WriteLine();
    
        }
    } 

}
