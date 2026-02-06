using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Online Ordering System!");

        Address address1 = new Address("1321 Lincoln Ave", "Pacific Grove", "CA", "93950", "USA");
        Product product1 = new Product("Skibidi Toilet", 19.99m, "W123", 2);
        Product product2 = new Product("G-Toilet", 21.99m, "W123", 2);
        Customer customer1 = new Customer("Jonathan Harker", "U", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        Console.WriteLine($"Total Cost for Order 1: {order1.CalculateTotalCost():C}");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Address address2 = new Address("2284 Madero St", "Mexico City", "MX", "A1B 2C3", "Mexico");
        Product product3 = new Product("Cameraman", 29.99m, "G456", 1);
        Product product4 = new Product("Speakerman", 9.99m, "T789", 3);
        Customer customer2 = new Customer("Alonso Quijano", "U", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);
        Console.WriteLine($"Total Cost for Order 2: {order2.CalculateTotalCost():C}");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}