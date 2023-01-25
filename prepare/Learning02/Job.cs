using System;
public class Job
{
    public string _jobTitle;
    public string _companyName;
    public int _startYear;
    public  int _endYear;

    public void Display()
    {
        Console.WriteLine($"Job Title {_jobTitle} ({_companyName}) Start Year:{_startYear} End Year:{_endYear}");
    }
}

