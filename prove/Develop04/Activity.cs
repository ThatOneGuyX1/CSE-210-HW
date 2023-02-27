using System;


public class Activity
{
    protected int _duration;

    private string _welcomeMessage = "Welcome to the mindfullness assitant.";

    private string _endMessage = "Good Job!!";

    protected string _description;

    protected int _timePassed = 0;

    public Activity()
    {
        GetDuration();
    }

    public void GetDuration()
    {
        Console.WriteLine("How long should the activity last in seconds?");
        SetDuration(int.Parse(Console.ReadLine()));
    }

    private void SetDuration (int time)
    {
        _duration = time;
        Console.WriteLine($"Time set is {_duration} seconds.");
    }

    protected void DisplayWelcomeMessage()
    {
        Console.WriteLine(_welcomeMessage);
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
    }
    
    protected void PassTime(int step)
    {
        int count = 0;
        while(count < step)
        {
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _timePassed += 1;
            count += 1;
            Console.Write(_timePassed);
        }
    }

    protected void DisplayDesription()
    {
        Console.WriteLine(_description);
    }

    public virtual void SetDescription()
    {
        _description = "Void";
    }

    protected void runWelcome()
    {
        DisplayWelcomeMessage();
        DisplayDesription();
    }

}