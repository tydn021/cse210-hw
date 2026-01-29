using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private Customer _customer;
    private List<Product> _product= new List<Product>();

    public Order(Customer customer, List<Product> product)
    {
        _customer = customer;
        _product= product;
    }

    public decimal CalculateTotalPrice()
    {
        decimal _totalPrice = 0;

        foreach (Product price in _product)
        {
            _totalPrice += price.TotalPrice();
        }
        if (_customer.checkAmerica() == false)
        {
            _totalPrice += 35;
        }
        else
        {
            _totalPrice += 5;
        }
        return _totalPrice;
    }
    public string CreatePackingLabel()
    {
        string packingLabel = "";
        foreach(Product part in _product)
        {
            packingLabel += part.GetPackingLabel() + "\n";
        }
        return packingLabel;
    }
    public string CreateShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += _customer.GetShippingLabel();
        return shippingLabel;
    }
}