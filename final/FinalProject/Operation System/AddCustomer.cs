/* 
Class Name: OrderRepo
Parent Class: N/A
Subclasses: Order

Purpose: Is the base class for all Items, will have all the data needed for the loading and saving items

Version: 0.01

*/

using System;

public class AddCustomer : Operation
{
    private CustomerRepo _repo;

    public AddCustomer(CustomerRepo repo)
    {
        _repo = repo;
    }
    public override int Execute()
    {
        Console.WriteLine("Enter the following information");
        Console.WriteLine("Cutomer Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Cutomer Phone:");
        string phone = Console.ReadLine();
        Console.WriteLine("Cutomer Email:");
        string email = Console.ReadLine();
        Console.WriteLine("Cutomer Address:");
        string adress = Console.ReadLine();

        Customer cust = new Customer(name,phone, email, adress);
        _repo.AddCustomer(cust);
    

        return 0;
    }

}
