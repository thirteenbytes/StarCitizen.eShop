namespace StarCitizen.eShop.Domain.Facilities;

public sealed record Quantity
{
    private Quantity(int value) =>
        Value = value;

    public int Value { get; private set; }

    public static Quantity Set(int value)
    {
        if (value >= 0)
        {
            return new Quantity(value);
        }

        throw new ArgumentOutOfRangeException();
    }
    
    public void Add(int quantity) =>    
        Value += quantity;

    public void Subtract(int quantity)
    {
        if(quantity < Value   )
        {
            Value -= quantity;
        }
        throw new QuanityIsZeroException();
    }
    
    

}
