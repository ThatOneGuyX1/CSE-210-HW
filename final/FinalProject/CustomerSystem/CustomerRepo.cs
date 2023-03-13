/* 
Class Name: CustomerRepo
Parent Class: N/A
Subclasses: Customer

Purpose: Is the base class for all customer, will have all the data needed for the loading and saving customer info
Version: 0.01

*/
using System;

public class CustomerRepo
{
    List<Customer> _masterCustomerList = new List<Customer>();
    public void LoadRepo()
    {

    }

    public void SaveRepo()
    {
        
    }

        public void AddInventroy(Customer dude)
    {
        _masterCustomerList.Add(dude);
    }
}