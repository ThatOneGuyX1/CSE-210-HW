using System;


public class Activity
{
    protected int _duration;

    private string _welcomeMessage = "Welcome to the mindfullness assitant.";

    private string _endMessage = "Good Job!!";

    protected string _description; // Is overridden in each child class

    protected int _timePassed = 0;

    // Constructs the activity 
    public Activity()
    {
        GetDuration();
    }
    // Takes user input to set the duration
    public virtual void GetDuration()
    {
        Console.WriteLine("How long should the activity last in seconds?");
        SetDuration(int.Parse(Console.ReadLine()));
    }

    protected void SetDuration (int time)
    {
        _duration = time;
        Console.WriteLine($"Time set is {_duration} seconds.");
    }

    private void DisplayWelcomeMessage()
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
        while((count < step) && (_timePassed <= _duration))
        {
            Thread.Sleep(1000); // Waits on second
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); // Clears the line, since there are 2 digit numbers
            _timePassed += 1; // Counts one second
            count += 1;
            Console.Write(_timePassed);
        }
        Console.WriteLine("");
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
        // Displays the welcome items for each activity.
        Console.Clear();
        DisplayWelcomeMessage();
        DisplayDesription();
        Console.WriteLine("Press enter to begin.");
        Console.ReadLine();
    }

}