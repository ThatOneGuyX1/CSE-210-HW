/* 
Class Name: OrderRepo
Parent Class: N/A
Subclasses: Order

Purpose: Is the base class for all Items, will have all the data needed for the loading and saving items

Version: 0.01

*/

using System;

public class AddItem : Operation
{
    private ItemRepo _repo;

    public AddItem(ItemRepo repo)
    {
        _repo = repo;
    }
    public override int Execute()
    {
        Console.WriteLine("Enter the following information");
        Console.WriteLine("Item Type:");
        string type = Console.ReadLine();
        Console.WriteLine("Item Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Category:");
        string category = Console.ReadLine();
        Console.WriteLine("Model Name:");
        string model = Console.ReadLine();
        Console.WriteLine("Price:");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Location:");
        string loc = Console.ReadLine();

        if (type.ToLower() == "serial")
        {
            Console.WriteLine("Serial Number:");
            string serial = Console.ReadLine();
            ItemSerial item = new ItemSerial(serial,name,category,model,price,loc);
            _repo.AddInventroy(item);
        }

        else if (type.ToLower() == "nonserial")
        {
            Console.WriteLine("Quantity:");
            int quan = int.Parse(Console.ReadLine());
            NonSerial item = new NonSerial(quan,name,category,model,price,loc);
            _repo.AddInventroy(item);
        }

        return 0;
    }
}