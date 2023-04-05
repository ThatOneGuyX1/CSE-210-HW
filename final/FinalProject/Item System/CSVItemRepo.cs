/* 
Class Name: CSVItemRepo
Parent Class: ItemRepo
Subclasses:

Purpose: Saves and Loads the master inventory from/ to a CSV file
            a csv file was chosen so that it could be imported and more easily manipulated in the file by a user.

Version: 0.01

*/

using System;

public class CSVItemRepo: ItemRepo
{

    protected List<Item> _masterCustomer = new List<Item>();
    string _header;
    public override void LoadRepo(string filename)
    {
        bool status;
        using (var reader = new StreamReader(filename))
        {
            _header = reader.ReadLine();
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
                status = bool.Parse(values[7]);


                if (type.ToLower() == "serial")
                {
                    string serial = values[8];
                    Item temp = new ItemSerial(serial,name,category, model,price, loc, order,status);
                    AddInventroy(temp);
                }
                
                else if (type.ToLower() == "nonserial")
                {
                    int quan = int.Parse(values[8]); 
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
            file.WriteLine(_header);
            for(int i = 0; i < _masterInventory.Count(); i++)
            {
                Item item = _masterInventory[i];
                List <string> list= item.GetItemList();
                foreach (string line in list)
                {
                    file.Write(line);
                }
                file.WriteLine();
            }           

        }
    }
}