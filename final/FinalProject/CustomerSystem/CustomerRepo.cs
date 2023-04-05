/* 
Class Name: CustomerRepo
Parent Class: ----
Subclasses: CSVCustomerRepo

Purpose: Is the base class for all customer, will have all the data needed for the loading and saving customer info
Version: 0.01

*/
using System;

public class CustomerRepo
{
    protected List<Customer> _masterCustomerList = new List<Customer>();
    public virtual void LoadRepo()
    {
        // Empty Shell
    }

    public virtual void SaveRepo()
    {
        //Empty Shell
    }

    public void AddCustomer(Customer dude)
    {
        _masterCustomerList.Add(dude);
    }
    public List<Customer> GetList()
    {
        return _masterCustomerList;
    }

}