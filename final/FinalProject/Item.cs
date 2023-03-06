using System;


public class Item
{
    private string _itemName;

    private string _modelNumber;

    private double _purhcasePrice;

    private bool _sold;

    private string _orderNumber;

    public Item()
    {
        SetItemName();
    }


    private void SetItemName()
    {
        Console.Write("Item Name: ");
        _itemName = Console.ReadLine();
    }







}