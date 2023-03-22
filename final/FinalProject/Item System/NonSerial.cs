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

    public NonSerial(int quan,string name, string category, string model, double price, string loc, string order = "0", bool status = false) : base(name,category,model,price,loc,order, status)
    {
        SetQuantity(quan);
    }

    public void SetQuantity(int quan)
    {
        _quantity = quan;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public override string GetTypeItem()
    {
        return "NONSERIAL";
    }

     public override List<string> GetItemList()
    {
        List<string> list = base.GetItemList();

        list.Add($"{GetQuantity()}");
        return list;
        

    }
}