public class VariablePriceProduct : Product
{
    public string Measurement { get; set; }
    public decimal Quantity { get; set; }

    public VariablePriceProduct(int id, string description, decimal price, decimal tax, string measurement, decimal quantity)
        : base(id, description, price, tax)
    {
        Measurement = measurement;
        Quantity = quantity;
    }

    public override decimal ValueToPay()
    {
        return Price * Quantity + (Price * Quantity * Tax);
    }

    public override string ToString()
    {
        return $"Id: {Id}, Description: {Description}, Price: {Price:C}, Tax: {Tax:P}, Measurement: {Measurement}, Quantity: {Quantity}";
    }
}
