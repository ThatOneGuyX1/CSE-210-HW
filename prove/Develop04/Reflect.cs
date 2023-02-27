using System;


public class Reflect : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    private void SetPrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
       
    }

    private void SetQuestions()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public override void SetDescription()
    {
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. "+
            "This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    private string GetPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(0,_prompts.Count())];
    }

    private string GetQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(0,_questions.Count())];
    }



    public void RunReflect()
    {   
        int step = 10;
        Animation ani = new Animation(step);
        runWelcome();
        SetPrompts();
        SetQuestions();
        Console.ReadLine();
        Console.WriteLine(GetPrompt());
        while (_timePassed < _duration)
        {
            ani.RunLineAnimation();
            _timePassed += step;
            Console.WriteLine(GetQuestion());
        }
        
        DisplayEndMessage();
        Console.ReadLine();
    }
}