/* 
Class Name: OrderRepo
Parent Class: N/A
Subclasses: Order

Purpose: Is the base class for all Items, will have all the data needed for the loading and saving items

Version: 0.01

*/

using System;

public class RemoveCustomer : Operation
{
    CSVCustomerRepo _repo;

    List<Customer> _list;

    public RemoveCustomer(CSVCustomerRepo repo)
    {
        _repo = repo;
        _list = _repo.GetList();
    }

    
    int _counter = 0;


    public override int Execute()
    {
        Console.WriteLine("What customer do you want to remove?");
        string _targetCustomer = Console.ReadLine();
        foreach (Customer person in _list)
        {
            if (person.GetName().ToLower() == _targetCustomer.ToLower())
            {
                _list.Remove(person);
            }
            _counter += 1;
        }

        return 0;
    }
}