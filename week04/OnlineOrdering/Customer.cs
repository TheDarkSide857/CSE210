using System;

class Customer
{
    private string _name { get; set; }
    private string _email { get; set; }
    private Address _shippingAddress { get; set; }
    public string Name => _name;
    public string ShippingAddress => _shippingAddress.GetFormattedAddress();
    public Customer(string name, string email, Address shippingAddress)
    {
        _name = name;
        _email = email;
        _shippingAddress = shippingAddress;
    }

    public bool LivesInUSA()
    {
        return _shippingAddress.IsInUSA();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Email: {_email}");
        Console.WriteLine("Shipping Address:");
        Console.WriteLine(_shippingAddress.GetFormattedAddress());
    }
}