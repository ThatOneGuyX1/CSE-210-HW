/* 
Class Name: ItemSerial
Parent class: Item
Subclasses: N/A

Purpose: A serial tracked item. Adds the setters and getters for an item with a serial number.

Version: 0.01
Date: 3/9/23
*/

using System;

public class ItemSerial : Item
{
    private string _serialNumber;

    public ItemSerial(string serial, string name, string category, string model, double price, string loc, string order = "0", bool status = false): base(name,category,model,price,loc,order,status)
    {
        SetSerialNumber(serial);
    }

    public void SetSerialNumber(string serial)
    {
        _serialNumber = serial;
    }

    public string GetSerialNumber()
    {
        return _serialNumber;
    }

    public override string GetTypeItem()
    {
        return "SERIAL";
    }
    public override List<string> GetItemList()
    {
        List<string> list = base.GetItemList();

        list.Add($"{GetSerialNumber()}");
        return list;
        

    }
}