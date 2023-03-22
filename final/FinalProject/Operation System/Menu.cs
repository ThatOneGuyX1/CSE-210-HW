/* 
Class Name: OrderRepo
Parent Class: N/A
Subclasses: Order

Purpose: Is the base class for all Items, will have all the data needed for the loading and saving items

Version: 0.01

*/

using System;

public class DisplayMenu : Operation
{
    public override int Execute()
    {
        Console.WriteLine("1. Add Item");
        Console.WriteLine("2. Remove Item");
        Console.WriteLine("3. Add Customer");
        Console.WriteLine("4. Remove Customer");
        Console.WriteLine("5. Make a Sale");
        int target = int.Parse(Console.ReadLine());
        return target;
    }
}