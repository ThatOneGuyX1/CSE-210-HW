/* 
Class Name: Business
Parent Class: Customer
Subclasses: -----

Purpose: Creates a sepcial type of customer where multiple names on the account 
Version: 0.02

NOTE: Not currently being used. I need to give more thought on how to intergrate this with other functions.
*/
using System;

public class Business : Customer
{
    Dictionary <int, List<String>> _namesOnAccount = new Dictionary<int, List<string>>();
    // 1:  < name, Phone, Email>
    public Business (string name, string phone, string email, string address, double newBal = 0) : base(name,phone,email,address,newBal)
    {
       
    }
    public void addNamesOnAccount(int pos, List<string> contactInfo)
    {
       _namesOnAccount.Add(pos,contactInfo);
    }
    
    public List<string> GetNames(int pos)
    {
        List<string> temp = new List<string>();
        temp = _namesOnAccount[pos];
        return temp;
    }
    
    







}
