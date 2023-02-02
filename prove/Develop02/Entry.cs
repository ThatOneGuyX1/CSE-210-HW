using System;
using System.IO;


public class Entry
{
    public string _dateOfEntry;

    public string _entryString;

    public string _givenPrompt;

   public void Display()
   {
    Console.WriteLine(_dateOfEntry);
    Console.WriteLine(_givenPrompt);
    Console.WriteLine(_entryString);


   }
}
