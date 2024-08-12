public class FixedPriceProduct : Product
{
    // Constructor para la clase FixedPriceProduct
    public FixedPriceProduct(int id, string description, decimal price)
        : base(id, description, price, 0) // Impuesto es 0 para precio fijo
    {
    }

    // Sobrescribe el método ValueToPay para un precio fijo sin impuesto
    public override decimal ValueToPay()
    {
        return Price; // Precio fijo no cambia con el impuesto
    }

    // Opcional: Puedes sobrescribir el método ToString si deseas cambiar su formato
    public override string ToString()
    {
        return $"Id: {Id}, Description: {Description}, Fixed Price: {Price:C}";
    }
}
