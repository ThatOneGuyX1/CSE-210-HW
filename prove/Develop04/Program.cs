using System;

class Program
{
    static void Main(string[] args)
    {
        // Setup
        Console.Clear();
        Menu menu = new Menu();
        string x = "";

        // Menu loop
        while (x.ToLower()!= "quit")
        {
            x = menu.DisplayMenu();
            
            // Run Breather
            if (x.ToLower() == "breath")
            {
                Breather breath = new Breather();
                breath.SetDescription();
                breath.RunBreather();
            }

            // Run Reflect
            else if (x.ToLower() == "reflect")
            {
                Reflect refelct = new Reflect();
                refelct.SetDescription();
                refelct.RunReflect();

            }

            // Run Lister
            else if (x.ToLower() == "list")
            {
                Lister list = new Lister();
                list.SetDescription();
                list.RunLister();
                
            }

            // End Message for program
             else if (x.ToLower() == "quit")
            {
                Console.WriteLine("Thank you for your time.");
                
            }
            
            // Alert user of mistakes in input
            else
            {
                Console.WriteLine("Answer not recgonized");
            }
        }
        
    }
}