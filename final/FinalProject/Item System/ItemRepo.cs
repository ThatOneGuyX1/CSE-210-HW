/* 
Class Name: ItemRepo
Parent Class: N/A
Subclasses: Item

Purpose: Is the base class for all Items, will have all the data needed for the loading and saving items

Version: 0.01

*/

using System;

public class ItemRepo
{
    List<Item> _masterInventory = new List<Item>();
    public void SaveRepo()
    {
        return;
    }

    public  virtual void LoadRepo()
    {
        return;
    }

    public void AddInventroy(Item thingie)
    {
        _masterInventory.Add(thingie);
    }
}
