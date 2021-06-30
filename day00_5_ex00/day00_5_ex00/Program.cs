using System;
using System.Collections.Generic;
using day00_5_ex00;

void Simulation(Action<Customer, List<CashRegister>> choseMethod)
{
    var store = new Store(40, 3);
    var customers = new Customer[]
    {
        new  Customer("Bob", 0),
        new  Customer("Kate", 1),
        new  Customer("Jenn", 2),
        new  Customer("Alex", 3),
        new  Customer("Jon", 4),
        new  Customer("Dilan", 5),
        new  Customer("Mike", 6),
        new  Customer("Kaitlin", 7),
        new  Customer("Rose", 8),
        new  Customer("Jeniffer", 9),
    };

    foreach (var customer in customers)
    {
        store.FillCustomerCart(customer);
    }
    
}