using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = 1;
        Console.Write("Enter 0 to exit.");
        while(num != 0)
        {
            Console.Write("Enter a number: ");
            string ent = Console.ReadLine();
            num = int.Parse(ent);
            numbers.Add(num);
        }

       int listSize = numbers.Count;

       int count = 0;
        // Sum
       for( int i = 0; i < listSize; i++)
       {
        count += i;
        
       }
       Console.WriteLine($"The sum is {count}");

       // Average 
       int Average = count/listSize;
       Console.WriteLine($"The average is {Average}");


       int target = 0; 
       for (int i = 0; i < listSize; i++)
       {
        
        if (i > target)
        {
            target = i;
        };
       }

        Console.WriteLine($"The largest number is {target}");
    }
}