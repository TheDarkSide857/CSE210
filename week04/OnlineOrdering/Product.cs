using System;

class Product
{
    private string name { get; set; }
    private decimal price { get; set; }
    private string productId { get; set; }
    private int quantity { get; set; }
    public string Name => name;
    public string ProductId => productId;
    public Product(string name, decimal price, string productId, int quantity)
    {
        this.name = name;
        this.price = price;
        this.productId = productId;
        this.quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return price * quantity;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Product ID: {productId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Price: {price:C}");
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Total Cost: {GetTotalCost():C}");
    }
}
