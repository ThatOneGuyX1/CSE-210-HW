using System;


public class Breather : Activity
{
    private List<string> _prompts = new List<string>();

    public override void SetDescription()
    {
       _description = "This activity will help you focus on your breathing and relax your body. Follow the prompts on screen.";
    }

    public void RunBreather()
    {
        runWelcome();
        
        while (_timePassed < _duration)
        {
            Console.WriteLine("Breath in");
            //Count 3 Seconds
            PassTime(3);
            Console.WriteLine("Breath out");
            //Count 4 Seconds
            PassTime(4);
            
        }
        DisplayEndMessage();
        Console.ReadLine();
    }

}