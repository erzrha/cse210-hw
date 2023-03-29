using System;

public class Address 
{
    private string _streetAddress = " ";
    private string _city = " ";
    private string _state = " ";
    private string _country = " ";
    public Address(){

    }
    public void SetAddress(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    
    }

    public string DisplayAddress()
    {
        return($"street Address: {_streetAddress} city: {_city} state: {_state}");
    }
}