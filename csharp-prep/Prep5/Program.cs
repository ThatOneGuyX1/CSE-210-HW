using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {   
        string name;
        Console.Write("What is your name? ");
        name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumer()
    {
        string temp;
        int number;
        Console.Write("What is your favorite number? ");
        temp = Console.ReadLine();
        number = int.Parse(temp);
        return number;
    }

    static int SquareNumber(int number)
    {
        int numsqrd = number * number;
        return numsqrd;
    }

    static void DisplayResult(string userName, int numberSqrd)
    {
        Console.WriteLine($"Your name is {userName}. Your favorite number squared is {numberSqrd}.");
    }
    
    static void Main(string[] args)
    {
        // Variables
        string userName;
        int favNumber;
        int numberSqrd;
        // Functions
        
        DisplayWelcome();
        userName = PromptUserName();
        favNumber = PromptUserNumer();
        numberSqrd = SquareNumber(favNumber);
        DisplayResult(userName, numberSqrd);

    }

}