using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address a) {
        _name = name;
        _address = a;
    }

    public string GetName() {
        return _name;
    }

    public string GetAddress() {
        return _address.GetAddress();
    }

    public bool isUSA() {
        return _address.isUSA();
    }
}