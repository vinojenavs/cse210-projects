using System;
class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetShippingAddress()
    {
        return _address.GetFullAddress();
    }
    public bool InUSA()
    {
        return _address.InUSA();
    }

}