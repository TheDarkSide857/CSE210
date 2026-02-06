using System;

class Address
{
    private string _street { get; set; }
    private string _city { get; set; }
    private string _state { get; set; }
    private string _zipCode { get; set; }
    private string _country { get; set; }
    public Address(string street, string city, string state, string zipCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES";
    }
    public string GetFormattedAddress()
    {
        return $"{_street}\n{_city}, {_state} {_zipCode}\n{_country}";
    }
}