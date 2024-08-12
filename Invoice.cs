using System.Collections.Generic;
using System.Linq;

public class Invoice
{
    private List<Product> _products;

    public Invoice()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetInvoice()
    {
        return $"Invoice: \n{ToString()}";
    }

    public decimal ValueToPay()
    {
        return _products.Sum(p => p.ValueToPay());
    }

    public override string ToString()
    {
        string productDescriptions = string.Join("\n", _products.Select(p => p.ToString()));
        return $"Products:\n{productDescriptions}\nTotal Value to Pay: {ValueToPay():C}";
    }
}
