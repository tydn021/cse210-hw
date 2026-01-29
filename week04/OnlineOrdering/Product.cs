using System;

public class Product
{
    private string _productName = "";
    private string _productID = "";
    private decimal _price = 0;
    private int _quantity = 0;

    public Product(string productName, string productID, decimal price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public decimal TotalPrice()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_productName} {_productID}";
    }
}