/* 
Class Name: Customer
Parent Class: CustomerRepo
Subclasses: Business, Private

Purpose: Contains all information related customer accounts 
Version: 0.01

*/
using System;

public class Customer
{
    private string _accountName;
    private string _phoneNumber;
    private string _emailAddress;
    private string _mailingAddress;
    private double  _balance = 0.0;

    protected int accountNumber;

    public Customer (string name, string phone, string email, string address, double newBal = 0)
    {
        SetName(name);
        SetPhoneNumber(phone);
        SetMailingAddress(address);
        
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

    // Additonal Functins

    public void AddBal(double newBal)
    {
        _balance += newBal;
    }
}