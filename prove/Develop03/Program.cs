using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Scripture master = new Scripture();

        master.LoadFile();

        master.AskScripture();

        master.SetScripture();

        bool running = true;

        while (running != false)
        {
            Console.WriteLine("Type quit if you want to quit.");
            string temp = Console.ReadLine();
            if (temp == "quit")
            {
                running = false;
            }

            else
            {   
                Console.Clear();
                master.Memorize();
                Console.ReadLine();
            }
        }

    }
}