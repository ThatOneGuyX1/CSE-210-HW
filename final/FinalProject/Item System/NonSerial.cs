/* 
Class Name: NonSerial
Parent class: Item
Subclasses: N/A

Purpose: A non serial tracked item. Since these are tracked by quanity the over all quanity will be created and stored here.

Version: 0.01
Date: 3/9/23
*/

using System;

public class NonSerial : Item
{
    private int _quantity;

    public NonSerial(string name, string category, string model, double price, string loc, int quan) : base(name,category,model,price,loc)
    {
        SetQuantity(quan);
    }

    public void SetQuantity(int quan)
    {
        _quantity = quan;
    }

}