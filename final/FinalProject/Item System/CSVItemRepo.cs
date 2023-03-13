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
    public override void LoadRepo()
    {
            using (var reader = new StreamReader("item.csv"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(",");

                string name = values[0]; // Book
                string category = values[1]; // Book
                string model = values[2]; // Book
                double price =  double.Parse(values[3]); // Book
                string loc =  values[4]; // Book
                string order = values[5]; // Book
               
               
                
                Item temp = new Item(name,category, model,price, loc, order);
                AddInventroy(temp);



            }
        }
    }

}