using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Customer
{
    public string Name { get; private set; }
    public Address Address { get; private set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsUSA() => Address.Country == "USA";
}