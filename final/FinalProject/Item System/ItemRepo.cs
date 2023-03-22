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

    protected List<Item> _masterInventory = new List<Item>();

    public  virtual void SaveRepo(string filename)
    {
        return;
    }

    public  virtual void LoadRepo(string filename)
    {
        return;
    }

    public void AddInventroy(Item thingie)
    {
        _masterInventory.Add(thingie);
    }

    public List<Item> GetList()
    {
        return _masterInventory;
    }
}
