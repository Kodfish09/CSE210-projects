using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer c, List<Product> p) {
        _customer = c;
        _products = p;
    }

    public double OrderTotal() {
        double total = 0;
        foreach(Product p in _products) {
            total += p.GetTPrice();
        }
        total += ShippingCost();
        return total;
    }

    public double ShippingCost() {
        bool usa = _customer.isUSA();
        if (usa == true) {
            return 5;
        } else {
            return 35;
        }
    }

    public void PackingList() {
        foreach(Product p in _products) {
            Console.WriteLine($"{p.GetID()}({p.GetName()}) --> {p.GetQuantity()} x ${p.GetPrice()}");
        }
    }

    public void ShippingLabel() {
        Console.WriteLine($"{_customer.GetName()}:\n{_customer.GetAddress()}");
    }
}