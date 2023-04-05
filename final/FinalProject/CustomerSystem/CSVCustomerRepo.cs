/* 
Class Name: CSVItemRepo
Parent Class: ItemRepo
Subclasses:------

Purpose: Saves and Loads the master inventory from/ to a CSV file
            a csv file was chosen so that it could be imported and more easily manipulated in the file by a user.

Version: 0.03

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
            _header = reader.ReadLine(); // Sets the header
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(",");

                string name = values[0]; // ICustomer Name
                string address = values[1]; // Customer Address
                string phone = values[2]; // Customer Phone Number
                string email = values[3]; // Customer Email
                double balance = double.Parse(values[4]); // Customer balance

                AddCustomer(new Customer (name,phone,email,address,balance)); // Adds to the master list
            }
        }
    }

    public override void SaveRepo()
    {
        using(var file = new StreamWriter(filename))
        {
            file.WriteLine(_header); // Writes the header, this causes it to be the same each time

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