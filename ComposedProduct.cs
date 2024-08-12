using System.Collections.Generic;
using System.Linq;

public class ComposedProduct : Product
{
    public decimal Discount { get; set; }
    public List<Product> Products { get; set; }

    public ComposedProduct(int id, string description, decimal price, decimal tax, decimal discount)
        : base(id, description, price, tax)
    {
        Discount = discount;
        Products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public override decimal ValueToPay()
    {
        decimal totalValue = Products.Sum(p => p.ValueToPay());
        return totalValue - (totalValue * Discount);
    }

    public override string ToString()
    {
        string productDescriptions = string.Join(", ", Products.Select(p => p.Description));
        return $"Id: {Id}, Description: {Description}, Price: {Price:C}, Tax: {Tax:P}, Discount: {Discount:P}, Products: [{productDescriptions}]";
    }
}
