using System;
public class Product
{
    // Propiedades de la clase Product
    public int Id { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal Tax { get; set; }

    // Constructor opcional para inicializar las propiedades
    public Product(int id, string description, decimal price, decimal tax)
    {
        Id = id;
        Description = description;
        Price = price;
        Tax = tax;
    }

    // Constructor por defecto
    public Product() { }

    // Método ToString para representar la clase como una cadena
    public override string ToString()
    {
        return $"Id: {Id}, Description: {Description}, Price: {Price:C}, Tax: {Tax:P}";
    }

    // Método ValueToPay que calcula el valor total a pagar, incluyendo el impuesto
    public decimal ValueToPay()
    {
        return Price + (Price * Tax);
    }
}
