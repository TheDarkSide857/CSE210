using System;

class Order
{
    private Customer _customer { get; set; }
    private List<Product> _products { get; set; }
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += GetShippingCost();
        return totalCost;
    }
    private decimal GetShippingCost()
    {
        return _customer.LivesInUSA() ? 5 : 35;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
    return "Shipping Label:\n" +
        "──────────────────────\n" +
        $"{_customer.Name}\n\n" +
        $"{_customer.ShippingAddress}\n" +
        "──────────────────────";
    }
}