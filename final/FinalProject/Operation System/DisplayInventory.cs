/* 
Class Name: OrderRepo
Parent Class: N/A
Subclasses: Order

Purpose: Is the base class for all Items, will have all the data needed for the loading and saving items

Version: 0.01

*/

using System;

public class DisplayInventory : Operation
{
    private ItemRepo _repo;

    private List<Item> _list;

    public DisplayInventory(ItemRepo repo)
    {
        _repo = repo;
        _list = _repo.GetList();

    }

    private void Display(string line)
    {
        Console.WriteLine(line);
    }
    public override int Execute()
    {
        foreach (Item thing in _list)
        {
            Display(thing.GetTypeItem());
            Display(thing.GetItemName());
            Display(thing.getCategory());
            Display(thing.GetModelNumber());
            Display(thing.GetLocation());
            Display($"{thing.GetPurchasePrice()}");
            Display(thing.GetAvaliblity());
        }
        

        return 0;
    }
}
