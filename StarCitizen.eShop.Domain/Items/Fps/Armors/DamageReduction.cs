namespace StarCitizen.eShop.Domain.Items.Fps.Armors;

public record DamageReduction
{
    private DamageReduction(decimal value) =>    
        Value = value;
        
    

    private DamageReduction() { }

    public decimal Value { get; init; }
    public bool InUse { get; init; } = true;

    public static DamageReduction NotApplicable = new DamageReduction { InUse = false };

    public string ValueFormatted
    {
        get
        {
            return Value.ToString("P2");
        }
    }

    public static DamageReduction Create(decimal value)
    {
        if (value < 0 || value > 100)
        {
            throw new ArgumentOutOfRangeException($"{value}");
        }

        return new DamageReduction(value);
    }
}
