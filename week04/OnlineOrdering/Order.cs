using System;
using System.Net.Http.Headers;
using System.Numerics;
class Order
{
    private Customer _customerName;
    private List<Product> _products;
    public Order(Customer customerName)
    {
        _customerName = customerName;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customerName.InUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: ";
        foreach (var product in _products)
        {
            label += "- " + product.GetPackingLabel();
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: {_customerName.GetName()}\n{_customerName.GetShippingAddress()}";
    }
}