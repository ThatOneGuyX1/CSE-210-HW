/* 
Class Name: Customer
Parent Class: ----
Subclasses: Business, Private

Purpose: Contains all information related customer accounts 
Version: 0.02

*/
using System;

public class Customer
{
    private string _accountName;
    private string _phoneNumber;
    private string _emailAddress;
    private string _mailingAddress;
    private double  _balance = 0.0; // Default is set to 0 since a new customer will have 0 balance.

    protected int accountNumber; /// Maybe used later

    public Customer (string name, string phone, string email, string address, double newBal = 0)
    {
        SetName(name);
        SetPhoneNumber(phone);
        SetEmail(email);
        SetMailingAddress(address);
        SetBalance(newBal);
        
    }
    // Setters
    protected void SetName(string name)
    {
        _accountName = name;
    }
    private void SetPhoneNumber(string phone)
    {
        _phoneNumber = phone;
    }
    private void SetMailingAddress(string address)
    {
        _mailingAddress = address;
    }
    private void SetEmail(string email)
    {
        _emailAddress = email;
    }
    private void SetBalance(double newBal)
    {
        _balance = newBal;
    }

    // getters
    public string GetName()
    {
       return _accountName;
    }
    public string GetPhoneNumber()
    {
        return _phoneNumber;
    }
    public string GetMailingAdress()
    {
        return _mailingAddress;
    }
    public string GetEmail()
    {
        return _emailAddress;
    }
    public double GetBalance()
    {
        return _balance;
    }

    // Additonal Functions

    public void AddBal(double newBal)
    {
        _balance += newBal;
    }

    public List<string> GetCustList()
    {
        // This is a list that is only used to be able to save the data in a CSV file.
        List<string> list = new List<string>();
        list.Add(_accountName + ",");
        list.Add(_mailingAddress + ",");
        list.Add(_phoneNumber + ",");
        list.Add(_emailAddress + ",");
        list.Add($"{_balance}");
        return list; 
    }
}