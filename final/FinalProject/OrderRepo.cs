/* 
Class Name: OrderRepo
Parent Class: N/A
Subclasses: Order

Purpose: Is the base class for all Items, will have all the data needed for the loading and saving items

Version: 0.01

*/

using System;

public class OrderRepo
{
  Dictionary<int, Order> _orderInfo = new Dictionary<int, Order>();   
}