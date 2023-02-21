using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment a1 = new Assignment("Ian Searle", "Math");
        Console.WriteLine(a1.GetSummary());


        MathAssignment m1 = new MathAssignment("Luke", "Fractions", "Section 1.2", "12-34 evens");

        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Sam", "English 101", "The causes of Autisms by Greg");


        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());


    }
}