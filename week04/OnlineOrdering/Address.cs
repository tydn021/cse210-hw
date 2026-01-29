using System;
using System.Runtime.CompilerServices;

public class Address

{
    private string _country = "";
    private string _streetAddress = "";
    private string _city = "";


    public Address(string country, string streetAddress, string city)
    {
        _country = country;
        _streetAddress = streetAddress;
        _city = city;
    }
    public bool IsInAmerica()
    {
        if (_country != "USA")
        {
            return false;
        }

        return true;
    }

    public string GetCompleteAddress()
    {
        return $"{_streetAddress} \n {_city} \n {_country}";
    }

}