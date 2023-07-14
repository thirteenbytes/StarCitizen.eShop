namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;
public sealed record Capacity
{
    private Capacity(decimal value) =>    
        Value = value;
    
    private Capacity() { }  
    public decimal Value { get; init; }
    public bool InUse { get; init; } = true;

    public static Capacity NotApplicable = new Capacity {  InUse = false };

    public static Capacity Create(decimal? value)
    {
        if (value.HasValue)
        {
            if (value < 0) throw new ArgumentOutOfRangeException($"{value}");
            return new Capacity(value.Value);
        }

        return NotApplicable;
    }                               
}

