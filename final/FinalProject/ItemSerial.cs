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

    public ItemSerial(string name, string category, string model, double price, string loc, string serial) : base(name,category,model,price,loc)
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

}