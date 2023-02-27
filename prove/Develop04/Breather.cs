using System;


public class Breather : Activity
{
    private List<string> _prompts = new List<string>();

    public override void SetDescription()
   {
       _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
            "This will help you recognize the power you have and how you can use it in other aspects of your life.";
   }

    public void RunBreather()
    {
        runWelcome();
        Console.ReadLine();
        while (_timePassed < _duration)
        {
            Console.WriteLine("Breath in");
            //Count 2 Seconds
            PassTime(3);
            Console.WriteLine("Breath out");
            //Count 2 Seconds
            PassTime(4);
            
        }
        DisplayEndMessage();
        Console.ReadLine();
    }








}