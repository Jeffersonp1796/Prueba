using System;
public class Product
{
    public int Id { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal Tax { get; set; }

    public Product(int id, string description, decimal price, decimal tax)
    {
        Id = id;
        Description = description;
        Price = price;
        Tax = tax;
    }

    public Product() { }

    public override string ToString()
    {
        return $"Id: {Id}, Description: {Description}, Price: {Price:C}, Tax: {Tax:P}";
    }

    public decimal ValueToPay()
    {
        return Price + (Price * Tax);
    }
}
