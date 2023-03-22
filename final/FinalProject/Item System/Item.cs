/* 
Class Name:Item

Subclasses: Serial, NonSerial

Purpose: Is an abstract class that contains all attributes and methods shared by all items

Version: 0.01

Date: 3/9/23
*/

using System;

public class Item
{
    Dictionary< int, string> _locationDict = new Dictionary<int, string>
        {
            [0] = "Main Store",
            [1] = "Floor",
            [2] = "Backshed",
            [3] = "Warehouse",
            [4] = "Broken",
            [5] = "Returned",
            [99] = "INVALID LOCATION" // This will allow for an item to be created but have an invalid location
        };
    private string _itemName;
    private string _category;
    private string _modelNumber;
    private double _purchasePrice;
    private int _location;
    private bool _avalability;
    private string _orderNumber;

    public Item(string name, string category, string model, double price, string loc, string order = "0", bool status = false)
    {
        SetItemName(name);
        SetCatergory(category);
        setModelNumber(model);
        SetPurchasePrice(price);
        SetLocation(loc);
        SetAvaliblity(status);
        setOrderNumber(order);
    }

// Constructors
    public void SetItemName(string name)
    {
        _itemName = name;
    }

    public void SetCatergory(string category)
    {
        _category= category;
    }

    public void setModelNumber(string model)
    {
        _modelNumber = model;
    }

    public void SetPurchasePrice(double price)
    {
        _purchasePrice = price;
    }

    public void SetLocation(string loc)
    {
        // This converts the typed location from the user into a number for easier data processing.
        // By using a dictionary we can easliy bind the number to a location.
        while(true)
        {
            for (int i = 0; i <= _locationDict.Count()- 1; i++)  
            {
                if (_locationDict[i].ToLower() == loc.ToLower())
                {
                    _location = i ;
                    return;
                }
            }
            _location = 99;
            return;
        }
    }

    public void SetAvaliblity(bool set)
    {
        _avalability = set;
    }

    public void setOrderNumber(string orderNum)
    {
        _orderNumber = orderNum;
    }

// Getters
    public string GetItemName()
    {
        return _itemName;
    }

    public string getCategory()
    {
        return _category;
    }

    public string GetModelNumber()
    {
        return _modelNumber;
    }

    public double GetPurchasePrice()
    {
       return _purchasePrice;
    }

    public string GetLocation()
    {
        
        return $"{_locationDict[_location]}";
    }

    

    public string GetAvaliblity()
    {
        if (_avalability == true)
        {
            return " SOLD";
        }
        else
        {
            return "Avaliable";
        }
    }

    public bool GetStatus()
    {
        return _avalability;
    }
    public string GetOrderNumber()
    {
        return _orderNumber;
    }

    public virtual List<string> GetItemList()
    {
        List<string> list = new List<string>();
            list.Add($"{GetTypeItem()},"); // 0
            list.Add($"{GetItemName()},"); // 1
            list.Add($"{getCategory()},"); // 2
            list.Add($"{GetModelNumber()},"); // 3
            list.Add($"{GetPurchasePrice()},"); // 4
            list.Add($"{GetLocation()},");  // 5
            list.Add($"{GetOrderNumber()},"); //6
            list.Add($"{GetStatus()}"); //7
            return list;


    }
    public virtual string GetTypeItem()
    {
        return "ERROR";
    }
}