public class FixedPriceProduct : Product
{
    public FixedPriceProduct(int id, string description, decimal price)
        : base(id, description, price, 0)
    {
    }

    public override decimal ValueToPay()
    {
        return Price;
    }
    public override string ToString()
    {
        return $"Id: {Id}, Description: {Description}, Fixed Price: {Price:C}";
    }
}
