using System;

public class Customer

{
    private string _fullName;
    private Address _address;
    public Customer(string fullName, Address address)
    {
        _address = address;
        _fullName = fullName;
    }

    public bool checkAmerica()
    {
        _address.IsInAmerica();
        return _address.IsInAmerica();
    }

    public string GetShippingLabel()
    {
        return $"{_fullName} \n {_address.GetCompleteAddress()}";
    }
}