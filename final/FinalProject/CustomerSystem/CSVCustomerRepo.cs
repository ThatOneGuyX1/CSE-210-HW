/* 
Class Name: CSVItemRepo
Parent Class: ItemRepo
Subclasses:

Purpose: Is the base class for all Items, will have all the data needed for the loading and saving items

Version: 0.01

*/

using System;

public class CSVCustomerRepo: CustomerRepo
{
    string _header;
    string filename = "masterCustomer.csv";
    public override void LoadRepo()
    {
        
        using (var reader = new StreamReader(filename))
        {
            _header = reader.ReadLine();
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(",");

                string name = values[0]; // Item type
                string address = values[1]; // Item type
                string phone = values[2]; // Item type
                string email = values[3]; // Item type
                double balance = double.Parse(values[4]); // Item type

                AddCustomer(new Customer (name,phone,email,address,balance));
            }
        }
    }

    public override void SaveRepo()
    {
        using(var file = new StreamWriter(filename))
        {
            file.WriteLine(_header);
            for(int i = 0; i < _masterCustomerList.Count(); i++)
            {
                Customer cust = _masterCustomerList[i];
                List <string> list = cust.GetCustList();
                foreach (string line in list)
                {
                    file.Write(line);
                }
                file.WriteLine();
            }           

        }
    }
}