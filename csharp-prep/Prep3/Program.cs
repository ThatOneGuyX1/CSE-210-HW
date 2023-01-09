using System;

class Program
{
    static void Main(string[] args)
    {
        int targetNumber;
        string guess;
        int guessNumber = 0;
        Random randomGen = new Random();
        targetNumber = randomGen.Next(1,100);
        

        while (guessNumber != targetNumber){

            Console.Write("Guess a number: ");
            guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            if (guessNumber > targetNumber){
                Console.WriteLine("Lower");
            }
            else if (guessNumber < targetNumber){
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("Congrats!!!");
    }  
}