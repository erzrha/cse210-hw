using System;

public class Customer  : Address
{
    protected string _name = " ";
    Address address = new Address();

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        address.SetAddress(street, city, state, country);
    }

    public string ShippingLabel()
    {
        return($"Name: {_name}, {address.DisplayAddress()}");
    }
}