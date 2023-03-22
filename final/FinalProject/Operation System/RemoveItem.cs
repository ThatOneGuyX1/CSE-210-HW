/* 
Class Name: OrderRepo
Parent Class: N/A
Subclasses: Order

Purpose: Is the base class for all Items, will have all the data needed for the loading and saving items

Version: 0.01

*/

using System;

public class RemoveItem : Operation
{
    ItemRepo _repo;

    List<Item> _list;

    public RemoveItem(ItemRepo repo)
    {
        _repo = repo;
        _list = _repo.GetList();
    }

    
    string _targetItem;
    int _counter = 0;


    public override int Execute()
    {
        Console.WriteLine("What item do you want to remove?");
        _targetItem = Console.ReadLine();
        foreach (Item thing in _list)
        {
            if (thing.GetItemName().ToLower() == _targetItem.ToLower())
            {
                _list.Remove(thing);
            }
            _counter += 1;
        }

        return 0;
    }
}