/* 
Class Name: CSVItemRepo
Parent Class: ItemRepo
Subclasses:

Purpose: Is the base class for all Items, will have all the data needed for the loading and saving items

Version: 0.01

*/

using System;

public class CSVItemRepo: ItemRepo
{
    public override void LoadRepo(string filename)
    {
            using (var reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(",");
                string type = values[0]; // Item type
                string name = values[1]; // Item Name
                string category = values[2]; // Catergory of Item
                string model = values[3]; // Model Number
                double price =  double.Parse(values[4]); //Price
                string loc =  values[5]; // Location
                string order = values[6]; // Ordernumber
                bool status = bool.Parse(values[7]);

                if (type.ToLower() == "serial")
                {
                    string serial = values[7];
                    Item temp = new ItemSerial(serial,name,category, model,price, loc, order,status);
                    AddInventroy(temp);
                }
                
                else if (type.ToLower() == "nonserial")
                {
                    int quan = int.Parse(values[7]); 
                    Item temp = new NonSerial(quan,name,category, model,price, loc, order,status);
                    AddInventroy(temp);
                }
                



            }
        }
    }

    public override void SaveRepo(string filename)
    {
         using(var file = new StreamWriter(filename))
        {
            file.WriteLine("Type, Name, Category,Model Number, Price, Location, Order Number");
            for(int i = 0; i <= _masterInventory.Count(); i++)
            {
                Item item = _masterInventory[i];
                file.Write($"{item.GetTypeItem()},");
                file.Write($"{item.GetItemName()},");
                file.Write($"{item.getCategory()},");
                file.Write($"{item.GetModelNumber()},");
                file.Write($"{item.GetPurchasePrice()},");
                file.Write($"{item.GetLocation()},");
                file.Write($"{item.GetOrderNumber()},");
                
            }
}

}
}