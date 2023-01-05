using System;

class Program
{
    static void Main(string[] args)
    {
        string grade;
        Console.Write("What is your grade perctange? ");
        string gradePercentString = Console.ReadLine();
        float gradePercentFloat = float.Parse(gradePercentString);
        if (gradePercentFloat >= 90)
        {
            grade = "A";
        }
        else if ( gradePercentFloat >= 80 && gradePercentFloat < 90)
        {
            grade = "B";
        }
        else if ( gradePercentFloat >= 70 && gradePercentFloat < 80)
        {
            grade = "C";
        }
        else if ( gradePercentFloat >= 60 && gradePercentFloat < 70)
        {
            grade = "D";
        }
        else 
        {
            grade = "F";
        }

        if (gradePercentFloat > 70)
        {
            Console.Write($"You passed with a grade of {grade}");
        }
        else
        {
            Console.Write($"You did not pass. Your grade is {grade}");
        }

    
    }
}