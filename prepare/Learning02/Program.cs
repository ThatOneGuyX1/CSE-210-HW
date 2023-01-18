using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Resume Builder");
        Job job1 = new Job();

        Console.WriteLine("JOB 1");
        Console.Write("ENTER Job Title: ");
        job1._jobTitle = Console.ReadLine();

        Console.Write("ENTER Company Name: ");
        job1._companyName = Console.ReadLine();

        Console.Write("ENTER Start Year:  ");
        job1._startYear = int.Parse(Console.ReadLine());

        Console.Write("ENTER End Year: ");
        job1._endYear = int.Parse(Console.ReadLine());

        

        Job job2 = new Job();
        Console.WriteLine("JOB 2");
        Console.Write("ENTER Job Title: ");
        job2._jobTitle = Console.ReadLine();

        Console.Write("ENTER Company Name: ");
        job2._companyName = Console.ReadLine();

        Console.Write("ENTER Start Year:  ");
        job2._startYear = int.Parse(Console.ReadLine());

        Console.Write("ENTER End Year: ");
        job2._endYear = int.Parse(Console.ReadLine());

        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();
        resume1._jobs[0]._jobTitle;
        Console.Write("Enter Name: ");
        resume1._name = Console.ReadLine();
        resume1._myjobs.Add(job1)

        resume1.Display();


    }
}