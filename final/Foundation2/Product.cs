using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Product
{
    public string Name { get; }
    public string ProductId { get; }
    public decimal Price { get; }
    public int Quantity { get; }

    public Product(string name, string productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity < 0 ? 0 : quantity;
    }

    public decimal TotalCost() => Price * Quantity;
}