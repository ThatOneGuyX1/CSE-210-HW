using System;

class Program
{
    static void Main(string[] args)
    {
        // Start up and set up
        ItemRepo _masterItem = new CSVItemRepo();
        _masterItem.LoadRepo("masterItem.csv");

        CustomerRepo _masterCustomer = new CSVCustomerRepo();
        _masterCustomer.LoadRepo();;

        OrderRepo _masterOrder = new OrderRepo();

        Dictionary<int, Operation> _masterOps = new Dictionary<int, Operation>();
        _masterOps.Add(0, new DisplayMenu());
        _masterOps.Add(1, new AddItem(_masterItem));
        _masterOps.Add(2, new RemoveItem(_masterItem)); 
        _masterOps.Add(3, new DisplayInventory(_masterItem));
        _masterOps.Add(4, new AddCustomer(_masterCustomer));
        _masterOps.Add(5, new AddCustomer(_masterCustomer));


        
        int x = 0;
        while( x <= 90)
        {
            x = _masterOps[x].Execute();        
        }

        _masterItem.SaveRepo("masterItem.csv");
        _masterCustomer.SaveRepo();
    }
}