/* 
Class Name: OrderRepo
Parent Class: N/A
Subclasses: Order

Purpose: Is the base class for all Items, will have all the data needed for the loading and saving items

Version: 0.01

*/

using System;

public class Order
{
   private int _orderNumber;

   private Customer _customerAccount;

   private List<Item> _cart = new List<Item>();

   private bool _fulfilemnt;

   public Order(int order, Customer cust, List<Item> cart, bool status = false)
   {
        SetCart(cart);
        SetCustomer(cust);
        SetFulfilment(status);
        SetOrderNumber(order);
   }

   public void SetOrderNumber(int order)
   {
        _orderNumber = order;
   }
   public void SetCustomer(Customer cust)
   {
        _customerAccount = cust;
   }

   public void SetCart(List<Item> cart)
   {
        _cart = cart;
   }

    public void SetFulfilment(bool status)
    {
        _fulfilemnt = status;
    }
    public int GetOrderNumber()
   {
        return _orderNumber;
   }
   public Customer GetCustomer()
   {
        return _customerAccount;
   }

   public List<Item> GetCart()
   {
        return _cart;
   }

    public bool GetFulfilment()
    {
        return _fulfilemnt;
    }




}