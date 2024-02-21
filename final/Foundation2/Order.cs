using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Order
{
    public List<Product> Products { get; private set; } = new List<Product>();
    public Customer Customer { get; private set; }

    public Order(Customer customer)
    {
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal TotalPrice() => Products.Sum(product => product.TotalCost()) + (Customer.IsUSA() ? 5m : 35m);

    public string PackingLabel()
    {
        var label = new StringBuilder();
        foreach (var product in Products)
        {
            label.Append($"{product.Name}, {product.ProductId}\n");
        }
        return label.ToString();
    }

    public string ShippingLabel() => $"{Customer.Name}\n{Customer.Address.FullAddress()}";
}